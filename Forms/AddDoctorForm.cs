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
            //Load wards into ComboBox
            LoadWards();
        }

        private void LoadWards()
        {
            DataTable wards = DoctorDB.GetWards();
            cmbWard.DataSource = wards;
            cmbWard.DisplayMember = "WardName";
            cmbWard.ValueMember = "WardID";
        }
        //SaveFileDialog button functionality: Validates input and saves the new doctor to the database

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