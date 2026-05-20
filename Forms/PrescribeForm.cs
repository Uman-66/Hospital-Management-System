using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class PrescribeForm : Form
    {
        private int _doctorID;

        public PrescribeForm(int doctorID)
        {
            InitializeComponent();
            _doctorID = doctorID;
            LoadPatients();
            LoadMedicines();
        }

        private void LoadPatients()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"SELECT p.PatientID, u.Name 
                                 FROM Patients p 
                                 JOIN Users u ON p.UserID = u.UserID
                                 JOIN Assignments a ON a.PatientID = p.PatientID
                                 WHERE a.DoctorID = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _doctorID);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbPatient.DataSource = dt;
                cmbPatient.DisplayMember = "Name";
                cmbPatient.ValueMember = "PatientID";
            }
        }

        private void LoadMedicines()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT DISTINCT MedicineName, MedicinePrice FROM Prescriptions";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbMedicine.DataSource = dt;
                cmbMedicine.DisplayMember = "MedicineName";
                cmbMedicine.ValueMember = "MedicinePrice";
            }
        }

        private void LoadPatientPrescriptions()
        {
            if (cmbPatient.SelectedValue == null) return;
            int patientID = Convert.ToInt32((cmbPatient.SelectedItem as DataRowView)?["PatientID"]);


            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        pr.MedicineName,
                        pr.MedicinePrice,
                        pr.PrescriptionDate
                    FROM Prescriptions pr
                    WHERE pr.PatientID = @id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", patientID);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPrescriptions.DataSource = dt;
            }
        }

        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPatientPrescriptions();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null || cmbMedicine.SelectedValue == null)
            {
                MessageBox.Show("Please select patient and medicine.", "Warning");
                return;
            }

            try
            {
                int patientID = Convert.ToInt32(cmbPatient.SelectedValue);
                double medicinePrice = Convert.ToDouble((cmbMedicine.SelectedItem as DataRowView)?["MedicinePrice"]);

                string medicineName = (cmbMedicine.SelectedItem as DataRowView)?["MedicineName"].ToString();


                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Prescriptions 
                                    (PatientID, DoctorID, MedicineName, MedicinePrice, PrescriptionDate)
                                    VALUES (@pid, @did, @med, @price, @date)";
                    var cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@pid", patientID);
                    cmd.Parameters.AddWithValue("@did", _doctorID);
                    cmd.Parameters.AddWithValue("@med", medicineName);
                    cmd.Parameters.AddWithValue("@price", medicinePrice);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                }

                // Recalculate bill
                BillingDB.RecalculateBill(patientID);

                MessageBox.Show("Medicine prescribed successfully!");
                LoadPatientPrescriptions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void PrescribeForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}