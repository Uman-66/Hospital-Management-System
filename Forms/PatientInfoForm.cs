using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class PatientInfoForm : Form
    {
        private int _userID;

        public PatientInfoForm(int userID)
        {
            InitializeComponent();
            _userID = userID;
            LoadData();
        }

        private void LoadData()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        u.Name,
                        p.Age,
                        p.Gender,
                        w.WardName,
                        p.BedNumber,
                        p.AdmitDate,
                        p.PerNightCharge,
                        p.PatientID,
                        ud.Name AS DoctorName,
                        a.MeetingTime,
                        b.GrandTotal,
                        b.TotalMedicineCharge,
                        b.TotalStayCharge
                    FROM Patients p
                    JOIN Users u ON p.UserID = u.UserID
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
                    // Info labels
                    lblName.Text = "Name: " + reader["Name"].ToString();
                    lblAge.Text = "Age: " + reader["Age"].ToString();
                    lblGender.Text = "Gender: " + reader["Gender"].ToString();
                    lblWard.Text = "Ward: " + reader["WardName"].ToString();
                    lblBed.Text = "Bed Number: " + reader["BedNumber"].ToString();
                    lblDoctor.Text = "Doctor: " + reader["DoctorName"].ToString();
                    lblMeeting.Text = "Meeting Time: " + reader["MeetingTime"].ToString();
                    lblAdmitDate.Text = "Admit Date: " + reader["AdmitDate"].ToString();

                    // Summary panel
                    lblPerNight.Text = "Per Night: Rs. " + reader["PerNightCharge"].ToString();

                    // Replace with correct names from designer
                    lblMedicineCost.Text = "Medicine Cost: Rs. " + reader["TotalMedicineCharge"].ToString();
                    lblStayCharge.Text = "Stay Charge: Rs. " + reader["TotalStayCharge"].ToString();
                    lblGrandTotal.Text = "Grand Total: Rs. " + reader["GrandTotal"].ToString();

                    // Load prescriptions
                    int patientID = Convert.ToInt32(reader["PatientID"]);
                    reader.Close();
                    LoadPrescriptions(patientID);
                }
            }
        }

        private void LoadPrescriptions(int patientID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        pr.MedicineName,
                        pr.MedicinePrice,
                        pr.PrescriptionDate,
                        ud.Name AS DoctorName
                    FROM Prescriptions pr
                    JOIN Doctors d ON pr.DoctorID = d.DoctorID
                    JOIN Users ud ON d.UserID = ud.UserID
                    WHERE pr.PatientID = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", patientID);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPrescriptions.DataSource = dt;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}