using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.", "Warning");
                return;
            }

            string role = CheckLogin(username, password);


            if (role == null)
            {
                MessageBox.Show("Incorrect username or password.", "Login Failed");
                return;
            }

            this.Hide();

            if (role == "Admin")
            {
                new AdminDashboard().Show();
            }
            else if (role == "Doctor")
            {
                int userID = GetUserID(username);
                new DoctorDashboard(userID).Show();
            }
            else if (role == "Patient")
            {
                try
                {
                    int userID = GetUserID(username);
                    new PatientDashboard(userID).Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    this.Show();
                }
            }
        }

        private string CheckLogin(string username, string password)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT Role FROM Users WHERE Username = @u AND Password = @p";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                var result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : null;
            }
        }

        private int GetUserID(string username)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT UserID FROM Users WHERE Username = @u";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtUsername.Text = "admin";
            txtPassword.Text = "1234";
        }

        private void doctorButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "sara.ali";
            txtPassword.Text = "1234";
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "ali.raza";
            txtPassword.Text = "1234";
        }
    }
}