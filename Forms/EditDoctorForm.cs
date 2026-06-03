using System;
using System.Data;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class EditDoctorForm : Form
    {
        private int _doctorID;

        public EditDoctorForm(int doctorID)
        {
            InitializeComponent();
            _doctorID = doctorID;
            LoadWards();
            LoadDoctorData();
        }
        //Load the wards in the ComboBox to allow the user to select a ward for the doctor
        private void LoadWards()
        {
            DataTable wards = DoctorDB.GetWards();
            cmbWard.DataSource = wards;
            cmbWard.DisplayMember = "WardName";
            cmbWard.ValueMember = "WardID";
        }
        //Load the existing doctor data into the form fields 
        private void LoadDoctorData()
        {
            DataTable dt = DoctorDB.GetDoctorDetails(_doctorID);
            if (dt.Rows.Count == 0) return;
            DataRow r = dt.Rows[0];

            txtName.Text = r["Name"].ToString();
            txtSpecialization.Text = r["Specialization"].ToString();
            cmbWard.SelectedValue = Convert.ToInt32(r["WardID"]);
            txtSalary.Text = r["MonthlySalary"].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorDB.UpdateDoctor(
                    _doctorID,
                    txtName.Text.Trim(),
                    txtSpecialization.Text.Trim(),
                    Convert.ToInt32(cmbWard.SelectedValue),
                    double.Parse(txtSalary.Text.Trim())
                );
                MessageBox.Show("Doctor updated successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //Delete the doctor from the database and close the form after confirmation
        private void btnDischarge_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to discharge this doctor?", "Confirm Discharge", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DoctorDB.DeleteDoctor(_doctorID);
                    MessageBox.Show("Doctor discharged successfully!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}