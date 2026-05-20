using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class PatientBillForm : Form
    {
        private int _userID;

        public PatientBillForm(int userID)
        {
            InitializeComponent();
            _userID = userID;
            LoadBill();
        }

        private void LoadBill()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        u.Name,
                        w.WardName,
                        p.AdmitDate,
                        p.PerNightCharge,
                        p.PatientID,
                        b.TotalStayCharge,
                        b.TotalMedicineCharge,
                        b.GrandTotal
                    FROM Patients p
                    JOIN Users u ON p.UserID = u.UserID
                    JOIN Wards w ON p.WardID = w.WardID
                    LEFT JOIN Billing b ON b.PatientID = p.PatientID
                    WHERE p.UserID = @uid";

                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", _userID);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Recalculate first
                    int patientID = Convert.ToInt32(reader["PatientID"]);
                    string admitDate = reader["AdmitDate"].ToString();
                    double perNight = Convert.ToDouble(reader["PerNightCharge"]);

                    DateTime admit = DateTime.Parse(admitDate);
                    int nights = (DateTime.Now - admit).Days;
                    if (nights < 1) nights = 1;

                    reader.Close();
                    BillingDB.RecalculateBill(patientID);

                    // Reload after recalculation
                    string query2 = @"
                        SELECT 
                            u.Name,
                            w.WardName,
                            p.AdmitDate,
                            p.PerNightCharge,
                            b.TotalStayCharge,
                            b.TotalMedicineCharge,
                            b.GrandTotal
                        FROM Patients p
                        JOIN Users u ON p.UserID = u.UserID
                        JOIN Wards w ON p.WardID = w.WardID
                        LEFT JOIN Billing b ON b.PatientID = p.PatientID
                        WHERE p.UserID = @uid";

                    var cmd2 = new SQLiteCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@uid", _userID);
                    var reader2 = cmd2.ExecuteReader();

                    if (reader2.Read())
                    {
                        lblPatientName.Text = "Patient: " + reader2["Name"].ToString();
                        lblWard.Text = "Ward: " + reader2["WardName"].ToString();
                        lblAdmitDate.Text = "Admit Date: " + reader2["AdmitDate"].ToString();
                        lblNights.Text = "Nights Stayed: " + nights.ToString();
                        lblPerNight.Text = "Per Night Charge: Rs. " + reader2["PerNightCharge"].ToString();
                        lblStayCharge.Text = "Total Stay Charge: Rs. " + reader2["TotalStayCharge"].ToString();
                        lblMedCharge.Text = "Medicine Charge: Rs. " + reader2["TotalMedicineCharge"].ToString();
                        lblGrandTotal.Text = "Grand Total: Rs. " + reader2["GrandTotal"].ToString();
                    }
                }
            }
        }
    }
}