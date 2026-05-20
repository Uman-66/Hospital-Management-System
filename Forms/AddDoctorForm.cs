using System;
using System.Data;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class AddDoctorForm : Form
    {
        public AddDoctorForm()
        {
            InitializeComponent();
            LoadWards();
        }

        private void LoadWards()
        {
            DataTable wards = DoctorDB.GetWards();
            cmbWard.DataSource = wards;
            cmbWard.DisplayMember = "WardName";
            cmbWard.ValueMember = "WardID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtUsername.Text.Trim() == "" ||
                txtPassword.Text.Trim() == "" || txtSpecialization.Text.Trim() == "" ||
                txtSalary.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields.", "Warning");
                return;
            }

            try
            {
                DoctorDB.AddDoctor(
                    txtName.Text.Trim(),
                    txtUsername.Text.Trim(),
                    txtPassword.Text.Trim(),
                    txtSpecialization.Text.Trim(),
                    Convert.ToInt32(cmbWard.SelectedValue),
                    double.Parse(txtSalary.Text.Trim())
                );
                MessageBox.Show("Doctor added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}