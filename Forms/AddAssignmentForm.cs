using System;
using System.Data;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class AddAssignmentForm : Form
    {
        public AddAssignmentForm()
        {
            InitializeComponent();
            LoadPatients();
            LoadDoctors();
        }

        private void LoadPatients()
        {
            DataTable patients = AssignmentDB.GetPatients();
            cmbPatient.DataSource = patients;
            cmbPatient.DisplayMember = "Name";
            cmbPatient.ValueMember = "PatientID";
        }

        private void LoadDoctors()
        {
            DataTable doctors = AssignmentDB.GetDoctors();
            cmbDoctor.DataSource = doctors;
            cmbDoctor.DisplayMember = "Name";
            cmbDoctor.ValueMember = "DoctorID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMeetingTime.Text.Trim() == "")
            {
                MessageBox.Show("Please enter meeting time.", "Warning");
                return;
            }

            try
            {
                AssignmentDB.AddAssignment(
                    Convert.ToInt32(cmbPatient.SelectedValue),
                    Convert.ToInt32(cmbDoctor.SelectedValue),
                    txtMeetingTime.Text.Trim()
                );
                MessageBox.Show("Assignment added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}