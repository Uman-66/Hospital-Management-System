using System;
using System.Data;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class EditPatientForm : Form
    {
        private int _patientID;

        public EditPatientForm(int patientID)
        {
            InitializeComponent();
            _patientID = patientID;
            LoadWards();
            LoadGenders();
            LoadPatientData();
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
        }

        private void LoadPatientData()
        {
            DataTable dt = PatientDB.GetPatientDetails(_patientID);
            if (dt.Rows.Count == 0) return;
            DataRow r = dt.Rows[0];

            txtName.Text = r["Name"].ToString();
            txtAge.Text = r["Age"].ToString();
            cmbGender.SelectedItem = r["Gender"].ToString();
            cmbWard.SelectedValue = Convert.ToInt32(r["WardID"]);
            txtBed.Text = r["BedNumber"].ToString();
            txtCharge.Text = r["PerNightCharge"].ToString();
        }




        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                PatientDB.UpdatePatient(
                    _patientID,
                    txtName.Text.Trim(),
                    int.Parse(txtAge.Text.Trim()),
                    cmbGender.SelectedItem.ToString(),
                    (int)cmbWard.SelectedValue,
                    int.Parse(txtBed.Text.Trim()),
                    double.Parse(txtCharge.Text.Trim())
                );
                MessageBox.Show("Patient updated successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnDischarge_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Discharge this patient?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PatientDB.DischargePatient(_patientID);
                MessageBox.Show("Patient discharged!");
                this.Close();
            }
        }
    }
}