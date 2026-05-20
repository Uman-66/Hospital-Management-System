using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class DoctorHomeForm : Form
    {
        private int _doctorID;

        public DoctorHomeForm(int doctorID)
        {
            InitializeComponent();
            _doctorID = doctorID;
            LoadInfo();
            LoadAppointments();
            LoadStats();
        }

        private void LoadInfo()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT u.Name, d.Specialization, w.WardName, d.MonthlySalary
                    FROM Doctors d
                    JOIN Users u ON d.UserID = u.UserID
                    JOIN Wards w ON d.WardID = w.WardID
                    WHERE d.DoctorID = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _doctorID);
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblName.Text = "Name: " + reader["Name"].ToString();
                    lblSpecialization.Text = "Specialization: " + reader["Specialization"].ToString();
                    lblWard.Text = "Ward: " + reader["WardName"].ToString();
                    lblSalary.Text = "Salary: Rs. " + reader["MonthlySalary"].ToString();
                }
            }
        }

        private void LoadAppointments()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT u.Name AS Patient, p.BedNumber, w.WardName, a.MeetingTime
                    FROM Assignments a
                    JOIN Patients p ON a.PatientID = p.PatientID
                    JOIN Users u ON p.UserID = u.UserID
                    JOIN Wards w ON p.WardID = w.WardID
                    WHERE a.DoctorID = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _doctorID);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAppointments.DataSource = dt;
            }
        }

        private void LoadStats()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                var cmd1 = new SQLiteCommand("SELECT COUNT(*) FROM Assignments WHERE DoctorID = @id", conn);
                cmd1.Parameters.AddWithValue("@id", _doctorID);
                long totalPatients = (long)cmd1.ExecuteScalar();

                var cmd2 = new SQLiteCommand("SELECT COUNT(*) FROM Prescriptions WHERE DoctorID = @id", conn);
                cmd2.Parameters.AddWithValue("@id", _doctorID);
                long totalPrescriptions = (long)cmd2.ExecuteScalar();

                var cmd3 = new SQLiteCommand(@"SELECT d.MonthlySalary, w.WardName 
                    FROM Doctors d JOIN Wards w ON d.WardID = w.WardID 
                    WHERE d.DoctorID = @id", conn);
                cmd3.Parameters.AddWithValue("@id", _doctorID);
                var reader = cmd3.ExecuteReader();

                if (reader.Read())
                {
                    lblStatSalary.Text = "Salary: Rs. " + reader["MonthlySalary"].ToString();
                    lblStatWard.Text = "Ward: " + reader["WardName"].ToString();
                }

                lblTotalPatients.Text = "Patients: " + totalPatients.ToString();
                lblTotalPrescriptions.Text = "Prescriptions: " + totalPrescriptions.ToString();
            }
        }
    }
}