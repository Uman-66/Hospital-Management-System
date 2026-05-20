namespace Hospital_Management.Forms
{
    partial class PatientHistoryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientHistoryForm));
            pnlHeader = new Panel();
            label1 = new Label();
            pnlSearch = new Panel();
            label3 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            pnlPatients = new Panel();
            lblPatientsTitle = new Label();
            dgvPatient = new DataGridView();
            pnlDetail = new Panel();
            pnlDetailHeader = new Panel();
            lblDetailTitle = new Label();
            lblNameCap = new Label();
            lblPatientName = new Label();
            lblWardCap = new Label();
            lblWard = new Label();
            lblBedCap = new Label();
            lblBed = new Label();
            lblDoctorCap = new Label();
            lblDoctor = new Label();
            pnlPrescriptions = new Panel();
            label2 = new Label();
            dgvPrescriptions = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlSearch.SuspendLayout();
            pnlPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatient).BeginInit();
            pnlDetail.SuspendLayout();
            pnlDetailHeader.SuspendLayout();
            pnlPrescriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(18, 32, 100);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1569, 80);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 18);
            label1.Name = "label1";
            label1.Size = new Size(339, 60);
            label1.TabIndex = 0;
            label1.Text = "Patient History";
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.White;
            pnlSearch.Controls.Add(label3);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Location = new Point(40, 110);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(340, 180);
            pnlSearch.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(100, 110, 150);
            label3.Location = new Point(24, 24);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 0;
            label3.Text = "SEARCH PATIENT";
            label3.Click += label3_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(24, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(292, 37);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(18, 32, 100);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 32, 100);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 32, 100);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(24, 106);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 46);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍  Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pnlPatients
            // 
            pnlPatients.BackColor = Color.White;
            pnlPatients.Controls.Add(lblPatientsTitle);
            pnlPatients.Controls.Add(dgvPatient);
            pnlPatients.Location = new Point(420, 110);
            pnlPatients.Name = "pnlPatients";
            pnlPatients.Size = new Size(1109, 460);
            pnlPatients.TabIndex = 2;
            // 
            // lblPatientsTitle
            // 
            lblPatientsTitle.AutoSize = true;
            lblPatientsTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPatientsTitle.ForeColor = Color.FromArgb(18, 32, 100);
            lblPatientsTitle.Location = new Point(28, 22);
            lblPatientsTitle.Name = "lblPatientsTitle";
            lblPatientsTitle.Size = new Size(203, 36);
            lblPatientsTitle.TabIndex = 0;
            lblPatientsTitle.Text = "Patient Records";
            // 
            // dgvPatient
            // 
            dgvPatient.AllowUserToAddRows = false;
            dgvPatient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 239, 255);
            dgvPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatient.BackgroundColor = Color.White;
            dgvPatient.BorderStyle = BorderStyle.None;
            dgvPatient.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPatient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 32, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(22, 32, 60);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(18, 32, 100);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPatient.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPatient.EnableHeadersVisualStyles = false;
            dgvPatient.GridColor = Color.FromArgb(210, 218, 240);
            dgvPatient.Location = new Point(28, 62);
            dgvPatient.Name = "dgvPatient";
            dgvPatient.ReadOnly = true;
            dgvPatient.RowHeadersVisible = false;
            dgvPatient.RowHeadersWidth = 62;
            dgvPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatient.Size = new Size(1053, 378);
            dgvPatient.TabIndex = 1;
            dgvPatient.CellClick += dgvPatient_CellClick;
            // 
            // pnlDetail
            // 
            pnlDetail.BackColor = Color.White;
            pnlDetail.Controls.Add(pnlDetailHeader);
            pnlDetail.Controls.Add(lblNameCap);
            pnlDetail.Controls.Add(lblPatientName);
            pnlDetail.Controls.Add(lblWardCap);
            pnlDetail.Controls.Add(lblWard);
            pnlDetail.Controls.Add(lblBedCap);
            pnlDetail.Controls.Add(lblBed);
            pnlDetail.Controls.Add(lblDoctorCap);
            pnlDetail.Controls.Add(lblDoctor);
            pnlDetail.Location = new Point(40, 610);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Size = new Size(340, 520);
            pnlDetail.TabIndex = 3;
            // 
            // pnlDetailHeader
            // 
            pnlDetailHeader.BackColor = Color.FromArgb(18, 32, 100);
            pnlDetailHeader.Controls.Add(lblDetailTitle);
            pnlDetailHeader.Location = new Point(0, 0);
            pnlDetailHeader.Name = "pnlDetailHeader";
            pnlDetailHeader.Size = new Size(340, 60);
            pnlDetailHeader.TabIndex = 10;
            // 
            // lblDetailTitle
            // 
            lblDetailTitle.AutoSize = true;
            lblDetailTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDetailTitle.ForeColor = Color.White;
            lblDetailTitle.Location = new Point(20, 14);
            lblDetailTitle.Name = "lblDetailTitle";
            lblDetailTitle.Size = new Size(179, 32);
            lblDetailTitle.TabIndex = 0;
            lblDetailTitle.Text = "Patient Details";
            // 
            // lblNameCap
            // 
            lblNameCap.AutoSize = true;
            lblNameCap.Font = new Font("Segoe UI", 8.5F);
            lblNameCap.ForeColor = Color.FromArgb(120, 130, 160);
            lblNameCap.Location = new Point(28, 84);
            lblNameCap.Name = "lblNameCap";
            lblNameCap.Size = new Size(58, 23);
            lblNameCap.TabIndex = 1;
            lblNameCap.Text = "NAME";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPatientName.ForeColor = Color.FromArgb(18, 32, 100);
            lblPatientName.Location = new Point(28, 108);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(38, 32);
            lblPatientName.TabIndex = 2;
            lblPatientName.Text = "—";
            // 
            // lblWardCap
            // 
            lblWardCap.AutoSize = true;
            lblWardCap.Font = new Font("Segoe UI", 8.5F);
            lblWardCap.ForeColor = Color.FromArgb(120, 130, 160);
            lblWardCap.Location = new Point(28, 176);
            lblWardCap.Name = "lblWardCap";
            lblWardCap.Size = new Size(58, 23);
            lblWardCap.TabIndex = 3;
            lblWardCap.Text = "WARD";
            // 
            // lblWard
            // 
            lblWard.AutoSize = true;
            lblWard.Font = new Font("Segoe UI", 11F);
            lblWard.ForeColor = Color.FromArgb(30, 40, 80);
            lblWard.Location = new Point(28, 200);
            lblWard.Name = "lblWard";
            lblWard.Size = new Size(35, 30);
            lblWard.TabIndex = 4;
            lblWard.Text = "—";
            // 
            // lblBedCap
            // 
            lblBedCap.AutoSize = true;
            lblBedCap.Font = new Font("Segoe UI", 8.5F);
            lblBedCap.ForeColor = Color.FromArgb(120, 130, 160);
            lblBedCap.Location = new Point(28, 268);
            lblBedCap.Name = "lblBedCap";
            lblBedCap.Size = new Size(41, 23);
            lblBedCap.TabIndex = 5;
            lblBedCap.Text = "BED";
            // 
            // lblBed
            // 
            lblBed.AutoSize = true;
            lblBed.Font = new Font("Segoe UI", 11F);
            lblBed.ForeColor = Color.FromArgb(30, 40, 80);
            lblBed.Location = new Point(28, 292);
            lblBed.Name = "lblBed";
            lblBed.Size = new Size(35, 30);
            lblBed.TabIndex = 6;
            lblBed.Text = "—";
            // 
            // lblDoctorCap
            // 
            lblDoctorCap.AutoSize = true;
            lblDoctorCap.Font = new Font("Segoe UI", 8.5F);
            lblDoctorCap.ForeColor = Color.FromArgb(120, 130, 160);
            lblDoctorCap.Location = new Point(28, 360);
            lblDoctorCap.Name = "lblDoctorCap";
            lblDoctorCap.Size = new Size(162, 23);
            lblDoctorCap.TabIndex = 7;
            lblDoctorCap.Text = "ASSIGNED DOCTOR";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 11F);
            lblDoctor.ForeColor = Color.FromArgb(30, 40, 80);
            lblDoctor.Location = new Point(28, 384);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(35, 30);
            lblDoctor.TabIndex = 8;
            lblDoctor.Text = "—";
            // 
            // pnlPrescriptions
            // 
            pnlPrescriptions.BackColor = Color.White;
            pnlPrescriptions.Controls.Add(label2);
            pnlPrescriptions.Controls.Add(dgvPrescriptions);
            pnlPrescriptions.Location = new Point(420, 610);
            pnlPrescriptions.Name = "pnlPrescriptions";
            pnlPrescriptions.Size = new Size(1109, 520);
            pnlPrescriptions.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(18, 32, 100);
            label2.Location = new Point(28, 22);
            label2.Name = "label2";
            label2.Size = new Size(171, 36);
            label2.TabIndex = 0;
            label2.Text = "Prescriptions";
            // 
            // dgvPrescriptions
            // 
            dgvPrescriptions.AllowUserToAddRows = false;
            dgvPrescriptions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 239, 255);
            dgvPrescriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPrescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptions.BackgroundColor = Color.White;
            dgvPrescriptions.BorderStyle = BorderStyle.None;
            dgvPrescriptions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPrescriptions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(18, 32, 100);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPrescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(22, 32, 60);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(18, 32, 100);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPrescriptions.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPrescriptions.EnableHeadersVisualStyles = false;
            dgvPrescriptions.GridColor = Color.FromArgb(210, 218, 240);
            dgvPrescriptions.Location = new Point(28, 62);
            dgvPrescriptions.Name = "dgvPrescriptions";
            dgvPrescriptions.ReadOnly = true;
            dgvPrescriptions.RowHeadersVisible = false;
            dgvPrescriptions.RowHeadersWidth = 62;
            dgvPrescriptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrescriptions.Size = new Size(1053, 438);
            dgvPrescriptions.TabIndex = 1;
            // 
            // PatientHistoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 255);
            ClientSize = new Size(1569, 1170);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSearch);
            Controls.Add(pnlPatients);
            Controls.Add(pnlDetail);
            Controls.Add(pnlPrescriptions);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PatientHistoryForm";
            Text = "Patient History";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlPatients.ResumeLayout(false);
            pnlPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatient).EndInit();
            pnlDetail.ResumeLayout(false);
            pnlDetail.PerformLayout();
            pnlDetailHeader.ResumeLayout(false);
            pnlDetailHeader.PerformLayout();
            pnlPrescriptions.ResumeLayout(false);
            pnlPrescriptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Panel pnlSearch;
        private Label label3;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel pnlPatients;
        private Label lblPatientsTitle;
        private DataGridView dgvPatient;
        private Panel pnlDetail;
        private Panel pnlDetailHeader;
        private Label lblDetailTitle;
        private Label lblNameCap;
        private Label lblPatientName;
        private Label lblWardCap;
        private Label lblWard;
        private Label lblBedCap;
        private Label lblBed;
        private Label lblDoctorCap;
        private Label lblDoctor;
        private Panel pnlPrescriptions;
        private Label label2;
        private DataGridView dgvPrescriptions;
    }
}