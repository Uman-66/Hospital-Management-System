using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class PatientDashboard : Form
    {
        private int _userID;

        public PatientDashboard(int userID)
        {
            InitializeComponent();
            _userID = userID;
            LoadWelcomeMessage();
            LoadWelcomeData();
        }

        private void LoadWelcomeMessage()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                // Load the user's name for welcome header
                string query = "SELECT Name FROM Users WHERE UserID = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _userID);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    namelabl.Text = reader["Name"].ToString();
                    lblWelcomeTitle.Text = "Welcome, " + reader["Name"].ToString() + "!";
                }
            }
        }

        private void LoadWelcomeData()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                // Load patient's current ward/bed, assigned doctor, meeting time and bill
                string query = @"
                    SELECT 
                        w.WardName,
                        p.BedNumber,
                        ud.Name AS DoctorName,
                        a.MeetingTime,
                        b.GrandTotal
                    FROM Patients p
                    JOIN Wards w ON p.WardID = w.WardID
                    LEFT JOIN Assignments a ON a.PatientID = p.PatientID
                    LEFT JOIN Doctors d ON a.DoctorID = d.DoctorID
                    LEFT JOIN Users ud ON d.UserID = ud.UserID
                    LEFT JOIN Billing b ON b.PatientID = p.PatientID
                    WHERE p.UserID = @uid";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", _userID);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblWardValue.Text = reader["WardName"].ToString();
                    lblBedValue.Text = reader["BedNumber"].ToString();
                    lblDoctorValue.Text = reader["DoctorName"] == DBNull.Value ? "Not Assigned" : reader["DoctorName"].ToString();
                    lblMeetingValue.Text = reader["MeetingTime"] == DBNull.Value ? "Not Scheduled" : reader["MeetingTime"].ToString();
                    double grandTotal = reader["GrandTotal"] == DBNull.Value ? 0 : Convert.ToDouble(reader["GrandTotal"]);
                    lblBillValue.Text = "Rs. " + grandTotal.ToString("N0");
                }
            }
        }

        private void LoadFormIntoPanel(Form form)
        {
            pnlMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Visible = true;
            pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnMyInfo_Click(object sender, EventArgs e)
        {
            PatientInfoForm f = new PatientInfoForm(_userID);
            LoadFormIntoPanel(f);
        }

        private void btnMyBill_Click(object sender, EventArgs e)
        {
            PatientBillForm f = new PatientBillForm(_userID);
            LoadFormIntoPanel(f);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginform().Show();
        }
    }
}