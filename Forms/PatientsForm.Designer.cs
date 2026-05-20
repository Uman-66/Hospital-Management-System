namespace Hospital_Management.Forms
{
    partial class PatientsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsForm));
            pnlTop = new Panel();
            lblTitle = new Label();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdmit = new Button();
            dgvPatients = new DataGridView();
            pnlTop.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(44, 62, 80);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1100, 70);
            pnlTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(372, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Patient Management";
            lblTitle.Click += lblTitle_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.FromArgb(236, 240, 241);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(btnAdmit);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 70);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new Padding(10);
            pnlSearch.Size = new Size(1100, 65);
            pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(15, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name or Patient ID...";
            txtSearch.Size = new Size(300, 37);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(41, 128, 185);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(325, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 36);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // btnAdmit
            // 
            btnAdmit.BackColor = Color.FromArgb(39, 174, 96);
            btnAdmit.Cursor = Cursors.Hand;
            btnAdmit.FlatAppearance.BorderSize = 0;
            btnAdmit.FlatStyle = FlatStyle.Flat;
            btnAdmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdmit.ForeColor = Color.White;
            btnAdmit.Location = new Point(450, 15);
            btnAdmit.Name = "btnAdmit";
            btnAdmit.Size = new Size(190, 36);
            btnAdmit.TabIndex = 2;
            btnAdmit.Text = "+ Admit New Patient";
            btnAdmit.UseVisualStyleBackColor = false;
            btnAdmit.Click += btnAdmit_Click_1;
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dgvPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.BackgroundColor = Color.White;
            dgvPatients.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPatients.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPatients.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPatients.Dock = DockStyle.Fill;
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.Font = new Font("Segoe UI", 10F);
            dgvPatients.GridColor = Color.FromArgb(220, 220, 220);
            dgvPatients.Location = new Point(0, 135);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.RowHeadersWidth = 62;
            dgvPatients.RowTemplate.Height = 35;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(1100, 515);
            dgvPatients.TabIndex = 0;
            dgvPatients.CellDoubleClick += dgvPatients_CellDoubleClick;
            // 
            // PatientsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 650);
            Controls.Add(dgvPatients);
            Controls.Add(pnlSearch);
            Controls.Add(pnlTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PatientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patients";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.DataGridView dgvPatients;
    }
}
