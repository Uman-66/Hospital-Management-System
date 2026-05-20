namespace Hospital_Management.Forms
{
    partial class PatientInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInfoForm));
            lblAdmitDate = new Label();
            label2 = new Label();
            lblMeeting = new Label();
            lblDoctor = new Label();
            lblBed = new Label();
            lblWard = new Label();
            lblGender = new Label();
            lblAge = new Label();
            lblName = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            dgvPrescriptions = new DataGridView();
            lblPerNight = new Label();
            lblMedicineCost = new Label();
            lblStayCharge = new Label();
            lblGrandTotal = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).BeginInit();
            SuspendLayout();
            // 
            // lblAdmitDate
            // 
            lblAdmitDate.AutoSize = true;
            lblAdmitDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmitDate.ForeColor = Color.FromArgb(65, 95, 70);
            lblAdmitDate.Location = new Point(50, 460);
            lblAdmitDate.Name = "lblAdmitDate";
            lblAdmitDate.Size = new Size(140, 32);
            lblAdmitDate.TabIndex = 0;
            lblAdmitDate.Text = "Admit Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(55, 90, 65);
            label2.Location = new Point(50, 35);
            label2.Name = "label2";
            label2.Size = new Size(354, 60);
            label2.TabIndex = 1;
            label2.Text = "My Information";
            // 
            // lblMeeting
            // 
            lblMeeting.AutoSize = true;
            lblMeeting.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeeting.ForeColor = Color.FromArgb(65, 95, 70);
            lblMeeting.Location = new Point(820, 300);
            lblMeeting.Name = "lblMeeting";
            lblMeeting.Size = new Size(169, 32);
            lblMeeting.TabIndex = 2;
            lblMeeting.Text = "Meeting Time:";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoctor.ForeColor = Color.FromArgb(65, 95, 70);
            lblDoctor.Location = new Point(820, 215);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(91, 32);
            lblDoctor.TabIndex = 3;
            lblDoctor.Text = "Doctor:";
            // 
            // lblBed
            // 
            lblBed.AutoSize = true;
            lblBed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBed.ForeColor = Color.FromArgb(65, 95, 70);
            lblBed.Location = new Point(820, 130);
            lblBed.Name = "lblBed";
            lblBed.Size = new Size(155, 32);
            lblBed.TabIndex = 4;
            lblBed.Text = "Bed Number:";
            // 
            // lblWard
            // 
            lblWard.AutoSize = true;
            lblWard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWard.ForeColor = Color.FromArgb(65, 95, 70);
            lblWard.Location = new Point(50, 385);
            lblWard.Name = "lblWard";
            lblWard.Size = new Size(74, 32);
            lblWard.TabIndex = 5;
            lblWard.Text = "Ward:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F);
            lblGender.ForeColor = Color.FromArgb(65, 95, 70);
            lblGender.Location = new Point(50, 300);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(97, 32);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F);
            lblAge.ForeColor = Color.FromArgb(65, 95, 70);
            lblAge.Location = new Point(50, 215);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(61, 32);
            lblAge.TabIndex = 7;
            lblAge.Text = "Age:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.ForeColor = Color.FromArgb(65, 95, 70);
            lblName.Location = new Point(50, 130);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 32);
            lblName.TabIndex = 8;
            lblName.Text = "Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 252, 248);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblWard);
            panel1.Controls.Add(lblAdmitDate);
            panel1.Controls.Add(lblBed);
            panel1.Controls.Add(lblDoctor);
            panel1.Controls.Add(lblMeeting);
            panel1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1544, 520);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(252, 247, 249);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dgvPrescriptions);
            panel2.Controls.Add(lblPerNight);
            panel2.Controls.Add(lblMedicineCost);
            panel2.Controls.Add(lblStayCharge);
            panel2.Controls.Add(lblGrandTotal);
            panel2.Location = new Point(0, 520);
            panel2.Name = "panel2";
            panel2.Size = new Size(1544, 631);
            panel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(55, 90, 65);
            label1.Location = new Point(50, 28);
            label1.Name = "label1";
            label1.Size = new Size(373, 60);
            label1.TabIndex = 0;
            label1.Text = "My Prescriptions";
            // 
            // dgvPrescriptions
            // 
            dgvPrescriptions.AllowUserToAddRows = false;
            dgvPrescriptions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 246, 240);
            dgvPrescriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptions.BackgroundColor = Color.White;
            dgvPrescriptions.BorderStyle = BorderStyle.None;
            dgvPrescriptions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPrescriptions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(88, 130, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPrescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(45, 60, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(195, 130, 148);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPrescriptions.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPrescriptions.EnableHeadersVisualStyles = false;
            dgvPrescriptions.GridColor = Color.FromArgb(200, 220, 205);
            dgvPrescriptions.Location = new Point(50, 90);
            dgvPrescriptions.Name = "dgvPrescriptions";
            dgvPrescriptions.ReadOnly = true;
            dgvPrescriptions.RowHeadersVisible = false;
            dgvPrescriptions.RowHeadersWidth = 62;
            dgvPrescriptions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrescriptions.Size = new Size(950, 510);
            dgvPrescriptions.TabIndex = 1;
            // 
            // lblPerNight
            // 
            lblPerNight.AutoSize = true;
            lblPerNight.Font = new Font("Segoe UI", 13F);
            lblPerNight.ForeColor = Color.FromArgb(80, 110, 88);
            lblPerNight.Location = new Point(1060, 110);
            lblPerNight.Name = "lblPerNight";
            lblPerNight.Size = new Size(83, 36);
            lblPerNight.TabIndex = 2;
            lblPerNight.Text = "label3";
            // 
            // lblMedicineCost
            // 
            lblMedicineCost.AutoSize = true;
            lblMedicineCost.Font = new Font("Segoe UI", 13F);
            lblMedicineCost.ForeColor = Color.FromArgb(80, 110, 88);
            lblMedicineCost.Location = new Point(1060, 220);
            lblMedicineCost.Name = "lblMedicineCost";
            lblMedicineCost.Size = new Size(83, 36);
            lblMedicineCost.TabIndex = 4;
            lblMedicineCost.Text = "label5";
            // 
            // lblStayCharge
            // 
            lblStayCharge.AutoSize = true;
            lblStayCharge.Font = new Font("Segoe UI", 13F);
            lblStayCharge.ForeColor = Color.FromArgb(80, 110, 88);
            lblStayCharge.Location = new Point(1060, 330);
            lblStayCharge.Name = "lblStayCharge";
            lblStayCharge.Size = new Size(83, 36);
            lblStayCharge.TabIndex = 3;
            lblStayCharge.Text = "label4";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTotal.ForeColor = Color.FromArgb(188, 100, 120);
            lblGrandTotal.Location = new Point(1060, 460);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(121, 48);
            lblGrandTotal.TabIndex = 5;
            lblGrandTotal.Text = "label6";
            // 
            // PatientInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 240);
            ClientSize = new Size(1544, 1151);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PatientInfoForm";
            StartPosition = FormStartPosition.Manual;
            Text = "The City Hospital  -  My Information";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAdmitDate;
        private Label label2;
        private Label lblMeeting;
        private Label lblDoctor;
        private Label lblBed;
        private Label lblWard;
        private Label lblGender;
        private Label lblAge;
        private Label lblName;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvPrescriptions;
        private Label label1;
        private Label lblGrandTotal;
        private Label lblMedicineCost;
        private Label lblStayCharge;
        private Label lblPerNight;
    }
}