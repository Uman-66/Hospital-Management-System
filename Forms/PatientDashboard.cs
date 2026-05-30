using System;
using System.Windows.Forms;
using Hospital_Management.Databases;
using System.Data.SQLite;
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
        }
        private void LoadWelcomeMessage()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT Name FROM Users WHERE UserID = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _userID);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    namelabl.Text  = reader["Name"].ToString()+ " !";
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

        private void welcome_Click(object sender, EventArgs e)
        {

        }
    }
}