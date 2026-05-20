using System;
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