using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class PatientHistoryForm : Form
    {
        private int _doctorID;

        public PatientHistoryForm(int doctorID)
        {
            InitializeComponent();
            _doctorID = doctorID;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (keyword == "")
            {
                MessageBox.Show("Please enter patient name or ID.", "Warning");
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
    SELECT DISTINCT
        p.PatientID,
        u.Name,
        p.Age,
        p.Gender,
        w.WardName,
        p.BedNumber,
        p.AdmitDate,
        ud.Name AS DoctorName
    FROM Patients p
    JOIN Users u ON p.UserID = u.UserID
    JOIN Wards w ON p.WardID = w.WardID
    LEFT JOIN Assignments a ON a.PatientID = p.PatientID
    LEFT JOIN Doctors d ON a.DoctorID = d.DoctorID
    LEFT JOIN Users ud ON d.UserID = ud.UserID
    WHERE u.Name LIKE @k OR p.PatientID LIKE @k
    GROUP BY p.PatientID";

                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@k", "%" + keyword + "%");
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPatient.DataSource = dt;
            }
        }

        private void dgvPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPatient.Rows[e.RowIndex];

                if (row.Cells["PatientID"].Value == DBNull.Value || row.Cells["PatientID"].Value == null) return;

                lblPatientName.Text = "Name: " + row.Cells["Name"].Value.ToString();
                lblWard.Text = "Ward: " + row.Cells["WardName"].Value.ToString();
                lblBed.Text = "Bed: " + row.Cells["BedNumber"].Value.ToString();
                lblDoctor.Text = "Doctor: " + (row.Cells["DoctorName"].Value == DBNull.Value ? "Not Assigned" : row.Cells["DoctorName"].Value.ToString());

                int patientID = Convert.ToInt32(row.Cells["PatientID"].Value);
                LoadPrescriptions(patientID);
            }
        }

        private void LoadPrescriptions(int patientID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT MedicineName, MedicinePrice, PrescriptionDate
                    FROM Prescriptions
                    WHERE PatientID = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", patientID);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPrescriptions.DataSource = dt;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}