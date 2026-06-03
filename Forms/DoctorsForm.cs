using System;
using System.Data;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();
            LoadDoctors();
        }
        //Load Doctors in the DataGridView
        private void LoadDoctors()
        {
            dgvDoctors.DataSource = DoctorDB.GetAllDoctors();
        }
        //Search the doctors by name, specialization, or ward and display the results in the DataGridView
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (keyword == "")
                LoadDoctors();
            else
                dgvDoctors.DataSource = DoctorDB.SearchDoctor(keyword);
        }
        //Add new Doctor in the database and refresh the DataGridView to show the new entry
        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctorForm addForm = new AddDoctorForm();
            addForm.ShowDialog();
            LoadDoctors();
        }
        //Open new Form to edit or remove doctor
        private void dgvDoctors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int doctorID = Convert.ToInt32(dgvDoctors.Rows[e.RowIndex].Cells["DoctorID"].Value);
                EditDoctorForm editForm = new EditDoctorForm(doctorID);
                editForm.ShowDialog();
                LoadDoctors();
            }
        }
    }
}