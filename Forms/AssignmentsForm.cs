using System;
using System.Data;
using System.Windows.Forms;
using Hospital_Management.Databases;

namespace Hospital_Management.Forms
{
    public partial class AssignmentsForm : Form
    {
        public AssignmentsForm()
        {
            InitializeComponent();
            LoadAssignments();
        }

        private void LoadAssignments()
        {
            dgvAssignments.DataSource = AssignmentDB.GetAllAssignments();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAssignmentForm addForm = new AddAssignmentForm();
            addForm.ShowDialog();
            LoadAssignments();
        }
        private void dgvAssignments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}