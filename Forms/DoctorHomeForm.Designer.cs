namespace Hospital_Management.Forms
{
    partial class DoctorHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorHomeForm));
            pnlInfo = new Panel();
            pnlInfoHeader = new Panel();
            lblInfoTitle = new Label();
            lblNameCaption = new Label();
            lblName = new Label();
            lblSpecCaption = new Label();
            lblSpecialization = new Label();
            lblWardCaption = new Label();
            lblWard = new Label();
            lblSalaryCaption = new Label();
            lblSalary = new Label();
            pnlAppointments = new Panel();
            lblAppTitle = new Label();
            dgvAppointments = new DataGridView();
            pnlStats = new Panel();
            pnlStatPatients = new Panel();
            lblTotalPatients = new Label();
            lblCapPatients = new Label();
            pnlStatPrescriptions = new Panel();
            lblTotalPrescriptions = new Label();
            lblCapPrescriptions = new Label();
            pnlStatWard = new Panel();
            lblStatWard = new Label();
            lblCapWard = new Label();
            pnlStatSalary = new Panel();
            lblStatSalary = new Label();
            lblCapSalary = new Label();
            pnlInfo.SuspendLayout();
            pnlInfoHeader.SuspendLayout();
            pnlAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            pnlStats.SuspendLayout();
            pnlStatPatients.SuspendLayout();
            pnlStatPrescriptions.SuspendLayout();
            pnlStatWard.SuspendLayout();
            pnlStatSalary.SuspendLayout();
            SuspendLayout();
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.White;
            pnlInfo.Controls.Add(pnlInfoHeader);
            pnlInfo.Controls.Add(lblNameCaption);
            pnlInfo.Controls.Add(lblName);
            pnlInfo.Controls.Add(lblSpecCaption);
            pnlInfo.Controls.Add(lblSpecialization);
            pnlInfo.Controls.Add(lblWardCaption);
            pnlInfo.Controls.Add(lblWard);
            pnlInfo.Controls.Add(lblSalaryCaption);
            pnlInfo.Controls.Add(lblSalary);
            pnlInfo.Location = new Point(40, 40);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(340, 560);
            pnlInfo.TabIndex = 0;
            // 
            // pnlInfoHeader
            // 
            pnlInfoHeader.BackColor = Color.FromArgb(18, 32, 100);
            pnlInfoHeader.Controls.Add(lblInfoTitle);
            pnlInfoHeader.Location = new Point(0, 0);
            pnlInfoHeader.Name = "pnlInfoHeader";
            pnlInfoHeader.Size = new Size(340, 64);
            pnlInfoHeader.TabIndex = 10;
            // 
            // lblInfoTitle
            // 
            lblInfoTitle.AutoSize = true;
            lblInfoTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblInfoTitle.ForeColor = Color.White;
            lblInfoTitle.Location = new Point(20, 16);
            lblInfoTitle.Name = "lblInfoTitle";
            lblInfoTitle.Size = new Size(185, 36);
            lblInfoTitle.TabIndex = 0;
            lblInfoTitle.Text = "Doctor Profile";
            // 
            // lblNameCaption
            // 
            lblNameCaption.AutoSize = true;
            lblNameCaption.Font = new Font("Segoe UI", 8.5F);
            lblNameCaption.ForeColor = Color.FromArgb(120, 130, 160);
            lblNameCaption.Location = new Point(28, 92);
            lblNameCaption.Name = "lblNameCaption";
            lblNameCaption.Size = new Size(99, 23);
            lblNameCaption.TabIndex = 1;
            lblNameCaption.Text = "FULL NAME";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(18, 32, 100);
            lblName.Location = new Point(28, 116);
            lblName.Name = "lblName";
            lblName.Size = new Size(32, 28);
            lblName.TabIndex = 2;
            lblName.Text = "—";
            // 
            // lblSpecCaption
            // 
            lblSpecCaption.AutoSize = true;
            lblSpecCaption.Font = new Font("Segoe UI", 8.5F);
            lblSpecCaption.ForeColor = Color.FromArgb(120, 130, 160);
            lblSpecCaption.Location = new Point(28, 184);
            lblSpecCaption.Name = "lblSpecCaption";
            lblSpecCaption.Size = new Size(138, 23);
            lblSpecCaption.TabIndex = 3;
            lblSpecCaption.Text = "SPECIALIZATION";
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.Font = new Font("Segoe UI", 11F);
            lblSpecialization.ForeColor = Color.FromArgb(30, 40, 80);
            lblSpecialization.Location = new Point(28, 208);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(35, 30);
            lblSpecialization.TabIndex = 4;
            lblSpecialization.Text = "—";
            // 
            // lblWardCaption
            // 
            lblWardCaption.AutoSize = true;
            lblWardCaption.Font = new Font("Segoe UI", 8.5F);
            lblWardCaption.ForeColor = Color.FromArgb(120, 130, 160);
            lblWardCaption.Location = new Point(28, 276);
            lblWardCaption.Name = "lblWardCaption";
            lblWardCaption.Size = new Size(143, 23);
            lblWardCaption.TabIndex = 5;
            lblWardCaption.Text = "ASSIGNED WARD";
            // 
            // lblWard
            // 
            lblWard.AutoSize = true;
            lblWard.Font = new Font("Segoe UI", 11F);
            lblWard.ForeColor = Color.FromArgb(30, 40, 80);
            lblWard.Location = new Point(28, 300);
            lblWard.Name = "lblWard";
            lblWard.Size = new Size(35, 30);
            lblWard.TabIndex = 6;
            lblWard.Text = "—";
            // 
            // lblSalaryCaption
            // 
            lblSalaryCaption.AutoSize = true;
            lblSalaryCaption.Font = new Font("Segoe UI", 8.5F);
            lblSalaryCaption.ForeColor = Color.FromArgb(120, 130, 160);
            lblSalaryCaption.Location = new Point(28, 368);
            lblSalaryCaption.Name = "lblSalaryCaption";
            lblSalaryCaption.Size = new Size(151, 23);
            lblSalaryCaption.TabIndex = 7;
            lblSalaryCaption.Text = "MONTHLY SALARY";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 11F);
            lblSalary.ForeColor = Color.FromArgb(30, 40, 80);
            lblSalary.Location = new Point(28, 392);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(35, 30);
            lblSalary.TabIndex = 8;
            lblSalary.Text = "—";
            // 
            // pnlAppointments
            // 
            pnlAppointments.BackColor = Color.White;
            pnlAppointments.Controls.Add(lblAppTitle);
            pnlAppointments.Controls.Add(dgvAppointments);
            pnlAppointments.Location = new Point(420, 40);
            pnlAppointments.Name = "pnlAppointments";
            pnlAppointments.Size = new Size(1109, 560);
            pnlAppointments.TabIndex = 1;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.FromArgb(18, 32, 100);
            lblAppTitle.Location = new Point(28, 24);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(288, 36);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "Today's Appointments";
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 239, 255);
            dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.BackgroundColor = Color.White;
            dgvAppointments.BorderStyle = BorderStyle.None;
            dgvAppointments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAppointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 32, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(22, 32, 60);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(18, 32, 100);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAppointments.EnableHeadersVisualStyles = false;
            dgvAppointments.GridColor = Color.FromArgb(210, 218, 240);
            dgvAppointments.Location = new Point(28, 64);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersVisible = false;
            dgvAppointments.RowHeadersWidth = 62;
            dgvAppointments.Size = new Size(1053, 468);
            dgvAppointments.TabIndex = 1;
            // 
            // pnlStats
            // 
            pnlStats.BackColor = Color.FromArgb(240, 244, 255);
            pnlStats.Controls.Add(pnlStatPatients);
            pnlStats.Controls.Add(pnlStatPrescriptions);
            pnlStats.Controls.Add(pnlStatWard);
            pnlStats.Controls.Add(pnlStatSalary);
            pnlStats.Location = new Point(40, 640);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(1489, 180);
            pnlStats.TabIndex = 2;
            // 
            // pnlStatPatients
            // 
            pnlStatPatients.BackColor = Color.White;
            pnlStatPatients.Controls.Add(lblTotalPatients);
            pnlStatPatients.Controls.Add(lblCapPatients);
            pnlStatPatients.Location = new Point(0, 15);
            pnlStatPatients.Name = "pnlStatPatients";
            pnlStatPatients.Size = new Size(348, 150);
            pnlStatPatients.TabIndex = 0;
            // 
            // lblTotalPatients
            // 
            lblTotalPatients.AutoSize = true;
            lblTotalPatients.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalPatients.ForeColor = Color.FromArgb(18, 32, 100);
            lblTotalPatients.Location = new Point(24, 28);
            lblTotalPatients.Name = "lblTotalPatients";
            lblTotalPatients.Size = new Size(38, 45);
            lblTotalPatients.TabIndex = 0;
            lblTotalPatients.Text = "0";
            // 
            // lblCapPatients
            // 
            lblCapPatients.AutoSize = true;
            lblCapPatients.Font = new Font("Segoe UI", 9F);
            lblCapPatients.ForeColor = Color.FromArgb(120, 130, 160);
            lblCapPatients.Location = new Point(26, 100);
            lblCapPatients.Name = "lblCapPatients";
            lblCapPatients.Size = new Size(115, 25);
            lblCapPatients.TabIndex = 1;
            lblCapPatients.Text = "Total Patients";
            // 
            // pnlStatPrescriptions
            // 
            pnlStatPrescriptions.BackColor = Color.White;
            pnlStatPrescriptions.Controls.Add(lblTotalPrescriptions);
            pnlStatPrescriptions.Controls.Add(lblCapPrescriptions);
            pnlStatPrescriptions.Location = new Point(373, 15);
            pnlStatPrescriptions.Name = "pnlStatPrescriptions";
            pnlStatPrescriptions.Size = new Size(348, 150);
            pnlStatPrescriptions.TabIndex = 1;
            // 
            // lblTotalPrescriptions
            // 
            lblTotalPrescriptions.AutoSize = true;
            lblTotalPrescriptions.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrescriptions.ForeColor = Color.FromArgb(18, 32, 100);
            lblTotalPrescriptions.Location = new Point(24, 28);
            lblTotalPrescriptions.Name = "lblTotalPrescriptions";
            lblTotalPrescriptions.Size = new Size(38, 45);
            lblTotalPrescriptions.TabIndex = 0;
            lblTotalPrescriptions.Text = "0";
            // 
            // lblCapPrescriptions
            // 
            lblCapPrescriptions.AutoSize = true;
            lblCapPrescriptions.Font = new Font("Segoe UI", 9F);
            lblCapPrescriptions.ForeColor = Color.FromArgb(120, 130, 160);
            lblCapPrescriptions.Location = new Point(26, 100);
            lblCapPrescriptions.Name = "lblCapPrescriptions";
            lblCapPrescriptions.Size = new Size(155, 25);
            lblCapPrescriptions.TabIndex = 1;
            lblCapPrescriptions.Text = "Total Prescriptions";
            // 
            // pnlStatWard
            // 
            pnlStatWard.BackColor = Color.White;
            pnlStatWard.Controls.Add(lblStatWard);
            pnlStatWard.Controls.Add(lblCapWard);
            pnlStatWard.Location = new Point(746, 15);
            pnlStatWard.Name = "pnlStatWard";
            pnlStatWard.Size = new Size(348, 150);
            pnlStatWard.TabIndex = 2;
            pnlStatWard.Paint += pnlStatWard_Paint;
            // 
            // lblStatWard
            // 
            lblStatWard.AutoSize = true;
            lblStatWard.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatWard.ForeColor = Color.FromArgb(18, 32, 100);
            lblStatWard.Location = new Point(24, 28);
            lblStatWard.Name = "lblStatWard";
            lblStatWard.Size = new Size(52, 45);
            lblStatWard.TabIndex = 0;
            lblStatWard.Text = "—";
            // 
            // lblCapWard
            // 
            lblCapWard.AutoSize = true;
            lblCapWard.Font = new Font("Segoe UI", 9F);
            lblCapWard.ForeColor = Color.FromArgb(120, 130, 160);
            lblCapWard.Location = new Point(26, 100);
            lblCapWard.Name = "lblCapWard";
            lblCapWard.Size = new Size(132, 25);
            lblCapWard.TabIndex = 1;
            lblCapWard.Text = "Assigned Ward";
            // 
            // pnlStatSalary
            // 
            pnlStatSalary.BackColor = Color.White;
            pnlStatSalary.Controls.Add(lblStatSalary);
            pnlStatSalary.Controls.Add(lblCapSalary);
            pnlStatSalary.Location = new Point(1119, 15);
            pnlStatSalary.Name = "pnlStatSalary";
            pnlStatSalary.Size = new Size(348, 150);
            pnlStatSalary.TabIndex = 3;
            // 
            // lblStatSalary
            // 
            lblStatSalary.AutoSize = true;
            lblStatSalary.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStatSalary.ForeColor = Color.FromArgb(18, 32, 100);
            lblStatSalary.Location = new Point(24, 28);
            lblStatSalary.Name = "lblStatSalary";
            lblStatSalary.Size = new Size(52, 45);
            lblStatSalary.TabIndex = 0;
            lblStatSalary.Text = "—";
            // 
            // lblCapSalary
            // 
            lblCapSalary.AutoSize = true;
            lblCapSalary.Font = new Font("Segoe UI", 9F);
            lblCapSalary.ForeColor = Color.FromArgb(120, 130, 160);
            lblCapSalary.Location = new Point(26, 100);
            lblCapSalary.Name = "lblCapSalary";
            lblCapSalary.Size = new Size(130, 25);
            lblCapSalary.TabIndex = 1;
            lblCapSalary.Text = "Monthly Salary";
            // 
            // DoctorHomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 255);
            ClientSize = new Size(1569, 1170);
            Controls.Add(pnlInfo);
            Controls.Add(pnlAppointments);
            Controls.Add(pnlStats);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoctorHomeForm";
            Text = "Doctor Home";
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            pnlInfoHeader.ResumeLayout(false);
            pnlInfoHeader.PerformLayout();
            pnlAppointments.ResumeLayout(false);
            pnlAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            pnlStats.ResumeLayout(false);
            pnlStatPatients.ResumeLayout(false);
            pnlStatPatients.PerformLayout();
            pnlStatPrescriptions.ResumeLayout(false);
            pnlStatPrescriptions.PerformLayout();
            pnlStatWard.ResumeLayout(false);
            pnlStatWard.PerformLayout();
            pnlStatSalary.ResumeLayout(false);
            pnlStatSalary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlInfo;
        private Panel pnlInfoHeader;
        private Label lblInfoTitle;
        private Label lblNameCaption;
        private Label lblName;
        private Label lblSpecCaption;
        private Label lblSpecialization;
        private Label lblWardCaption;
        private Label lblWard;
        private Label lblSalaryCaption;
        private Label lblSalary;
        private Panel pnlAppointments;
        private Label lblAppTitle;
        private DataGridView dgvAppointments;
        private Panel pnlStats;
        private Panel pnlStatPatients;
        private Label lblTotalPatients;
        private Label lblCapPatients;
        private Panel pnlStatPrescriptions;
        private Label lblTotalPrescriptions;
        private Label lblCapPrescriptions;
        private Panel pnlStatWard;
        private Label lblStatWard;
        private Label lblCapWard;
        private Panel pnlStatSalary;
        private Label lblStatSalary;
        private Label lblCapSalary;
    }
}