using System;
using System.Data;
using System.Data.SQLite;

namespace Hospital_Management.Databases
{
    public class DoctorDB
    {
        public static DataTable GetAllDoctors()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        d.DoctorID,
                        u.Name,
                        d.Specialization,
                        w.WardName,
                        d.MonthlySalary
                    FROM Doctors d
                    JOIN Users u ON d.UserID = u.UserID
                    JOIN Wards w ON d.WardID = w.WardID";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public static DataTable SearchDoctor(string keyword)
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        d.DoctorID,
                        u.Name,
                        d.Specialization,
                        w.WardName,
                        d.MonthlySalary
                    FROM Doctors d
                    JOIN Users u ON d.UserID = u.UserID
                    JOIN Wards w ON d.WardID = w.WardID
                    WHERE u.Name LIKE @k OR d.DoctorID LIKE @k";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@k", "%" + keyword + "%");
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public static void DeleteDoctor(int doctorID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string deleteDoctor = "DELETE FROM Doctors WHERE DoctorID = @id";
                var cmd = new SQLiteCommand(deleteDoctor, conn);
                cmd.Parameters.AddWithValue("@id", doctorID);
                cmd.ExecuteNonQuery();
                string deleteUser = @"DELETE FROM Users WHERE UserID = 
                                        (SELECT UserID FROM Doctors WHERE DoctorID = @id)";
                var cmd2 = new SQLiteCommand(deleteUser, conn);
                cmd2.Parameters.AddWithValue("@id", doctorID);
                cmd2.ExecuteNonQuery();
            }
        }

        public static DataTable GetDoctorDetails(int doctorID)
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        d.DoctorID,
                        u.Name,
                        u.Username,
                        d.Specialization,
                        w.WardName,
                        w.WardID,
                        d.MonthlySalary
                    FROM Doctors d
                    JOIN Users u ON d.UserID = u.UserID
                    JOIN Wards w ON d.WardID = w.WardID
                    WHERE d.DoctorID = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", doctorID);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public static void AddDoctor(string name, string username, string password, string specialization, int wardID, double monthlySalary)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string insertUser = "INSERT INTO Users (Name, Username, Password, Role) VALUES (@name, @username, @password, 'Doctor')";
                var cmd = new SQLiteCommand(insertUser, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();

                long userID = conn.LastInsertRowId;

                string insertDoctor = @"INSERT INTO Doctors (UserID, Specialization, WardID, MonthlySalary) 
                                        VALUES (@uid, @spec, @ward, @salary)";
                var cmd2 = new SQLiteCommand(insertDoctor, conn);
                cmd2.Parameters.AddWithValue("@uid", userID);
                cmd2.Parameters.AddWithValue("@spec", specialization);
                cmd2.Parameters.AddWithValue("@ward", wardID);
                cmd2.Parameters.AddWithValue("@salary", monthlySalary);
                cmd2.ExecuteNonQuery();
            }
        }

        public static void UpdateDoctor(int doctorID, string name, string specialization, int wardID, double monthlySalary)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string updateUser = "UPDATE Users SET Name = @name WHERE UserID = (SELECT UserID FROM Doctors WHERE DoctorID = @id)";
                var cmd = new SQLiteCommand(updateUser, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", doctorID);
                cmd.ExecuteNonQuery();

                string updateDoctor = @"UPDATE Doctors SET Specialization = @spec, WardID = @ward, 
                                        MonthlySalary = @salary WHERE DoctorID = @id";
                var cmd2 = new SQLiteCommand(updateDoctor, conn);
                cmd2.Parameters.AddWithValue("@spec", specialization);
                cmd2.Parameters.AddWithValue("@ward", wardID);
                cmd2.Parameters.AddWithValue("@salary", monthlySalary);
                cmd2.Parameters.AddWithValue("@id", doctorID);
                cmd2.ExecuteNonQuery();
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