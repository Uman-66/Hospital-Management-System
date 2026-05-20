using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class DoctorDashboard : Form
    {
        private int _userID;
        private int _doctorID;

        public DoctorDashboard(int userID)
        {
            InitializeComponent();
            _userID = userID;
            _doctorID = GetDoctorID(userID);
            ShowHome();
        }

        private int GetDoctorID(int userID)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT DoctorID FROM Doctors WHERE UserID = @uid", conn);
                cmd.Parameters.AddWithValue("@uid", userID);
                return Convert.ToInt32(cmd.ExecuteScalar());
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

        private void ShowHome()
        {
            DoctorHomeForm f = new DoctorHomeForm(_doctorID);
            LoadFormIntoPanel(f);
        }

        private void AddInfoLabel(Panel panel, string text, int y)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Font = new Font("Segoe UI", 10);
            lbl.Location = new Point(10, y);
            lbl.AutoSize = true;
            panel.Controls.Add(lbl);
        }

        private void AddStatLabel(Panel panel, string text, int x)
        {
            Label lbl = new Label();
            lbl.Text = text;
            lbl.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lbl.Location = new Point(x + 10, 25);
            lbl.AutoSize = true;
            panel.Controls.Add(lbl);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHome();
        }

        private void btnPrescribe_Click(object sender, EventArgs e)
        {
            PrescribeForm f = new PrescribeForm(_doctorID);
            LoadFormIntoPanel(f);
        }

        private void btnPatientHistory_Click(object sender, EventArgs e)
        {
            PatientHistoryForm f = new PatientHistoryForm(_doctorID);
            LoadFormIntoPanel(f);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new loginform().Show();
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}