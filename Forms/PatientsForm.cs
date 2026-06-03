using System;
using System.Data;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class PatientsForm : Form
    {
        public PatientsForm()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients()
        {
            dgvPatients.DataSource = PatientDB.GetAllPatients();
        }






        //Search A Patient by name, ID, or ward and display the results in the DataGridView
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            DataTable dt;

            if (string.IsNullOrEmpty(keyword))
                dt = PatientDB.GetAllPatients();
            else
                dt = PatientDB.SearchPatient(keyword);

            // Clear existing binding and force refresh to avoid visual glitches
            dgvPatients.DataSource = null;
            dgvPatients.DataSource = dt;
            dgvPatients.Refresh();
        }
        //Add New Patient
        private void btnAdmit_Click_1(object sender, EventArgs e)
        {
            AdmitForm admitForm = new AdmitForm();
            admitForm.ShowDialog();
            LoadPatients();
        }
        //Open  New form to update or delete

        private void dgvPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int patientID = Convert.ToInt32(dgvPatients.Rows[e.RowIndex].Cells["PatientID"].Value);
                EditPatientForm editForm = new EditPatientForm(patientID);
                editForm.ShowDialog();
                LoadPatients();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}