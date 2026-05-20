using System;
using System.Data;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
            LoadBilling();
        }

        private void LoadBilling()
        {
            // Recalculate all patient bills first
            DataTable patients = AssignmentDB.GetPatients();
            foreach (DataRow row in patients.Rows)
            {
                int patientID = Convert.ToInt32(row["PatientID"]);
                BillingDB.RecalculateBill(patientID);
            }
            dgvBilling.DataSource = BillingDB.GetAllBilling();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBilling();
            MessageBox.Show("Bills recalculated successfully!");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}