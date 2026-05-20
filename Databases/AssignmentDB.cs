using System;
using System.Data;
using System.Data.SQLite;

namespace Hospital_Management.Databases
{
    public class AssignmentDB
    {
        public static DataTable GetAllAssignments()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        a.AssignmentID,
                        up.Name AS PatientName,
                        p.PatientID,
                        ud.Name AS DoctorName,
                        d.DoctorID,
                        w.WardName,
                        a.MeetingTime
                    FROM Assignments a
                    JOIN Patients p ON a.PatientID = p.PatientID
                    JOIN Users up ON p.UserID = up.UserID
                    JOIN Doctors d ON a.DoctorID = d.DoctorID
                    JOIN Users ud ON d.UserID = ud.UserID
                    JOIN Wards w ON p.WardID = w.WardID";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public static void AddAssignment(int patientID, int doctorID, string meetingTime)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Assignments (PatientID, DoctorID, MeetingTime) 
                                 VALUES (@pid, @did, @time)";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@pid", patientID);
                cmd.Parameters.AddWithValue("@did", doctorID);
                cmd.Parameters.AddWithValue("@time", meetingTime);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateAssignment(int assignmentID, int doctorID, string meetingTime)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Assignments SET DoctorID = @did, MeetingTime = @time 
                                 WHERE AssignmentID = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@did", doctorID);
                cmd.Parameters.AddWithValue("@time", meetingTime);
                cmd.Parameters.AddWithValue("@id", assignmentID);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetPatients()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT p.PatientID, u.Name 
                                 FROM Patients p 
                                 JOIN Users u ON p.UserID = u.UserID";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetDoctors()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT d.DoctorID, u.Name 
                                 FROM Doctors d 
                                 JOIN Users u ON d.UserID = u.UserID";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}