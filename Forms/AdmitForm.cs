using System;
using System.Data;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class AdmitForm : Form
    {
        public AdmitForm()
        {
            InitializeComponent();
            LoadWards();
            LoadGenders();
        }

        private void LoadWards()
        {
            DataTable wards = PatientDB.GetWards();
            cmbWard.DataSource = wards;
            cmbWard.DisplayMember = "WardName";
            cmbWard.ValueMember = "WardID";
        }

        private void LoadGenders()
        {
            cmbGender.Items.AddRange(new[] { "Male", "Female", "Other" });
            cmbGender.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtUsername.Text.Trim() == "" ||
                txtPassword.Text.Trim() == "" || txtAge.Text.Trim() == "" ||
                txtBed.Text.Trim() == "" || txtCharge.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields.", "Warning");
                return;
            }

            try
            {
                PatientDB.AdmitPatient(
                    txtName.Text.Trim(),
                    txtUsername.Text.Trim(),
                    txtPassword.Text.Trim(),
                    int.Parse(txtAge.Text.Trim()),
                    cmbGender.SelectedItem.ToString(),
                    Convert.ToInt32(cmbWard.SelectedValue),

                    int.Parse(txtBed.Text.Trim()),
                    DateTime.Now.ToString("yyyy-MM-dd"),
                    double.Parse(txtCharge.Text.Trim())
                );
                MessageBox.Show("Patient admitted successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AdmitForm_Load(object sender, EventArgs e)
        {

        }
    }
}