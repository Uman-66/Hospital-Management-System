using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class AdminDashboard : Form
    {
        private Form _currentForm = null; // track the loaded form

        public AdminDashboard()
        {
            InitializeComponent();
            ShowHome();
        }

        private void ShowHome()
        {
            // Remove any loaded form
            if (_currentForm != null)
            {
                pnlMain.Controls.Remove(_currentForm);
                _currentForm.Dispose();
                _currentForm = null;
            }
            // Make sure home panel is visible and bring to front
            pnlHome.Visible = true;
            pnlHome.BringToFront();
            pnlMain.Visible = true; // parent panel must be visible

            // Update stats (already done in your existing ShowHome code)


            lblTotalPatients.Text = "Total Patients: " + GetCount("SELECT COUNT(*) FROM Patients");
            lblTotalDoctors.Text = "Total Doctors: " + GetCount("SELECT COUNT(*) FROM Doctors");
            lblTotalWards.Text = "Total Wards: " + GetCount("SELECT COUNT(*) FROM Wards");
            lblTotalMedicines.Text = "Total Medicines: " + GetCount("SELECT COUNT(DISTINCT MedicineName) FROM Prescriptions");

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string wardQuery = @"
                    SELECT w.WardName, COUNT(p.PatientID) AS TotalPatients
                    FROM Wards w
                    LEFT JOIN Patients p ON p.WardID = w.WardID
                    GROUP BY w.WardID";
                SQLiteDataAdapter da = new SQLiteDataAdapter(wardQuery, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvWards.DataSource = dt;

                string doctorQuery = @"
                    SELECT u.Name AS DoctorName, COUNT(a.PatientID) AS TotalPatients
                    FROM Doctors d
                    JOIN Users u ON d.UserID = u.UserID
                    LEFT JOIN Assignments a ON a.DoctorID = d.DoctorID
                    GROUP BY d.DoctorID";
                SQLiteDataAdapter da2 = new SQLiteDataAdapter(doctorQuery, conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dgvDoctors.DataSource = dt2;
            }
        }

        private int GetCount(string query)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                return Convert.ToInt32(new SQLiteCommand(query, conn).ExecuteScalar());
            }
        }

        private void LoadFormIntoPanel(Form form)
        {
            // Hide home panel
            pnlHome.Visible = false;

            // Remove previous loaded form if exists
            if (_currentForm != null)
            {
                pnlMain.Controls.Remove(_currentForm);
                _currentForm.Dispose();
            }

            // Prepare and add the new form
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Visible = true;
            pnlMain.Controls.Add(form);
            _currentForm = form;
            form.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHome();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new PatientsForm());
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new DoctorsForm());
        }

        private void btnAssignments_Click_1(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new AssignmentsForm());
        }

        private void btnBilling_Click_1(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new BillingForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginform().Show();
        }

        private void pnlHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalDoctors_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPatients_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalDoctors_Click_1(object sender, EventArgs e)
        {

        }
    }
}