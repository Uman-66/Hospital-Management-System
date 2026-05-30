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
            // Use Convert.ToInt32 to safely cast from long/int
            cmbWard.SelectedValue = Convert.ToInt32(r["WardID"]);
            txtBed.Text = r["BedNumber"].ToString();
            txtCharge.Text = r["PerNightCharge"].ToString();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtBed.Text) ||
                string.IsNullOrWhiteSpace(txtCharge.Text))
            {
                MessageBox.Show("Please fill all fields.", "Warning");
                return;
            }

            // Validate numeric fields
            if (!int.TryParse(txtAge.Text.Trim(), out int age))
            {
                MessageBox.Show("Age must be a valid number.", "Warning");
                return;
            }
            if (!int.TryParse(txtBed.Text.Trim(), out int bed))
            {
                MessageBox.Show("Bed number must be a valid number.", "Warning");
                return;
            }
            if (!double.TryParse(txtCharge.Text.Trim(), out double charge))
            {
                MessageBox.Show("Per night charge must be a valid number.", "Warning");
                return;
            }

            // Ensure a gender is selected
            if (cmbGender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Warning");
                return;
            }

            // Ensure a ward is selected
            if (cmbWard.SelectedValue == null)
            {
                MessageBox.Show("Please select a ward.", "Warning");
                return;
            }

            try
            {
                // FIXED: Use Convert.ToInt32 instead of direct cast (int)
                int wardID = Convert.ToInt32(cmbWard.SelectedValue);

                PatientDB.UpdatePatient(
                    _patientID,
                    txtName.Text.Trim(),
                    age,
                    cmbGender.SelectedItem.ToString(),
                    wardID,
                    bed,
                    charge
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