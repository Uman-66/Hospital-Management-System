using System;
using System.Data;
using System.Data.SQLite;

namespace Hospital_Management.Databases
{
    public class BillingDB
    {
        public static DataTable GetAllBilling()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        b.BillingID,
                        u.Name AS PatientName,
                        p.PatientID,
                        w.WardName,
                        p.AdmitDate,
                        p.PerNightCharge,
                        b.TotalStayCharge,
                        b.TotalMedicineCharge,
                        b.GrandTotal,
                        b.BillingDate
                    FROM Billing b
                    JOIN Patients p ON b.PatientID = p.PatientID
                    JOIN Users u ON p.UserID = u.UserID
                    JOIN Wards w ON p.WardID = w.WardID";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetPatientBill(int patientID)
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        b.BillingID,
                        u.Name AS PatientName,
                        w.WardName,
                        p.AdmitDate,
                        p.PerNightCharge,
                        b.TotalStayCharge,
                        b.TotalMedicineCharge,
                        b.GrandTotal,
                        b.BillingDate
                    FROM Billing b
                    JOIN Patients p ON b.PatientID = p.PatientID
                    JOIN Users u ON p.UserID = u.UserID
                    JOIN Wards w ON p.WardID = w.WardID
                    WHERE b.PatientID = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", patientID);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public static void RecalculateBill(int patientID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Get admit date and per night charge
                string patientQuery = "SELECT AdmitDate, PerNightCharge FROM Patients WHERE PatientID = @id";
                var cmd = new SQLiteCommand(patientQuery, conn);
                cmd.Parameters.AddWithValue("@id", patientID);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DateTime admitDate = DateTime.Parse(reader["AdmitDate"].ToString());
                    double perNight = Convert.ToDouble(reader["PerNightCharge"]);
                    reader.Close();

                    int nights = (DateTime.Now - admitDate).Days;
                    if (nights < 1) nights = 1;
                    double stayCharge = nights * perNight;

                    // Get total medicine charge
                    string medQuery = "SELECT SUM(MedicinePrice) FROM Prescriptions WHERE PatientID = @id";
                    var cmd2 = new SQLiteCommand(medQuery, conn);
                    cmd2.Parameters.AddWithValue("@id", patientID);
                    // To this
                    object medResult = cmd2.ExecuteScalar();
                    double medCharge = medResult == DBNull.Value || medResult == null ? 0 : Convert.ToDouble(medResult);

                    double grandTotal = stayCharge + medCharge;

                    // Update or insert billing
                    string checkBill = "SELECT COUNT(*) FROM Billing WHERE PatientID = @id";
                    var cmd3 = new SQLiteCommand(checkBill, conn);
                    cmd3.Parameters.AddWithValue("@id", patientID);
                    long count = (long)cmd3.ExecuteScalar();

                    if (count > 0)
                    {
                        string update = @"UPDATE Billing SET TotalStayCharge = @stay, 
                                         TotalMedicineCharge = @med, GrandTotal = @total,
                                         BillingDate = @date WHERE PatientID = @id";
                        var cmd4 = new SQLiteCommand(update, conn);
                        cmd4.Parameters.AddWithValue("@stay", stayCharge);
                        cmd4.Parameters.AddWithValue("@med", medCharge);
                        cmd4.Parameters.AddWithValue("@total", grandTotal);
                        cmd4.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd4.Parameters.AddWithValue("@id", patientID);
                        cmd4.ExecuteNonQuery();
                    }
                    else
                    {
                        string insert = @"INSERT INTO Billing (PatientID, TotalStayCharge, TotalMedicineCharge, GrandTotal, BillingDate)
                                          VALUES (@id, @stay, @med, @total, @date)";
                        var cmd4 = new SQLiteCommand(insert, conn);
                        cmd4.Parameters.AddWithValue("@id", patientID);
                        cmd4.Parameters.AddWithValue("@stay", stayCharge);
                        cmd4.Parameters.AddWithValue("@med", medCharge);
                        cmd4.Parameters.AddWithValue("@total", grandTotal);
                        cmd4.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd4.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}