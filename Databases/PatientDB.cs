using System;
using System.Data;
using System.Data.SQLite;

namespace Hospital_Management.Databases
{
    public class PatientDB
    {
        public static DataTable GetAllPatients()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        p.PatientID,
                        u.Name,
                        p.Age,
                        p.Gender,
                        w.WardName,
                        p.BedNumber,
                        p.AdmitDate,
                        p.PerNightCharge
                    FROM Patients p
                    JOIN Users u ON p.UserID = u.UserID
                    JOIN Wards w ON p.WardID = w.WardID";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public static DataTable SearchPatient(string keyword)
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        p.PatientID,
                        u.Name,
                        p.Age,
                        p.Gender,
                        w.WardName,
                        p.BedNumber,
                        p.AdmitDate,
                        p.PerNightCharge
                    FROM Patients p
                    JOIN Users u ON p.UserID = u.UserID
                    JOIN Wards w ON p.WardID = w.WardID
                    WHERE u.Name LIKE @k OR p.PatientID LIKE @k";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@k", "%" + keyword + "%");
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetPatientDetails(int patientID)
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        p.PatientID,
                        u.Name,
                        u.Username,
                        p.Age,
                        p.Gender,
                        w.WardName,
                        w.WardID,
                        p.BedNumber,
                        p.AdmitDate,
                        p.PerNightCharge
                    FROM Patients p
                    JOIN Users u ON p.UserID = u.UserID
                    JOIN Wards w ON p.WardID = w.WardID
                    WHERE p.PatientID = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", patientID);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public static void AdmitPatient(string name, string username, string password, int age, string gender, int wardID, int bedNumber, string admitDate, double perNightCharge)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string insertUser = "INSERT INTO Users (Name, Username, Password, Role) VALUES (@name, @username, @password, 'Patient')";
                var cmd = new SQLiteCommand(insertUser, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();

                long userID = conn.LastInsertRowId;

                string insertPatient = @"INSERT INTO Patients (UserID, Age, Gender, WardID, BedNumber, AdmitDate, PerNightCharge) 
                                         VALUES (@uid, @age, @gender, @ward, @bed, @date, @charge)";
                var cmd2 = new SQLiteCommand(insertPatient, conn);
                cmd2.Parameters.AddWithValue("@uid", userID);
                cmd2.Parameters.AddWithValue("@age", age);
                cmd2.Parameters.AddWithValue("@gender", gender);
                cmd2.Parameters.AddWithValue("@ward", wardID);
                cmd2.Parameters.AddWithValue("@bed", bedNumber);
                cmd2.Parameters.AddWithValue("@date", admitDate);
                cmd2.Parameters.AddWithValue("@charge", perNightCharge);
                cmd2.ExecuteNonQuery();
            }
        }

        public static void UpdatePatient(int patientID, string name, int age, string gender, int wardID, int bedNumber, double perNightCharge)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string updateUser = "UPDATE Users SET Name = @name WHERE UserID = (SELECT UserID FROM Patients WHERE PatientID = @id)";
                var cmd = new SQLiteCommand(updateUser, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", patientID);
                cmd.ExecuteNonQuery();

                string updatePatient = @"UPDATE Patients SET Age = @age, Gender = @gender, WardID = @ward, 
                                         BedNumber = @bed, PerNightCharge = @charge WHERE PatientID = @id";
                var cmd2 = new SQLiteCommand(updatePatient, conn);
                cmd2.Parameters.AddWithValue("@age", age);
                cmd2.Parameters.AddWithValue("@gender", gender);
                cmd2.Parameters.AddWithValue("@ward", wardID);
                cmd2.Parameters.AddWithValue("@bed", bedNumber);
                cmd2.Parameters.AddWithValue("@charge", perNightCharge);
                cmd2.Parameters.AddWithValue("@id", patientID);
                cmd2.ExecuteNonQuery();
            }
        }

        public static void DischargePatient(int patientID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Patients WHERE PatientID = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", patientID);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetWards()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT WardID, WardName FROM Wards", conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
