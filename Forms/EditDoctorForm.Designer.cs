namespace Hospital_Management.Forms
{
    partial class EditDoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDoctorForm));
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            lblSectionPersonal = new Label();
            label1 = new Label();
            txtName = new TextBox();
            lblSectionProfessional = new Label();
            label4 = new Label();
            txtSpecialization = new TextBox();
            label3 = new Label();
            cmbWard = new ComboBox();
            label2 = new Label();
            txtSalary = new TextBox();
            pnlFooter = new Panel();
            btnSave = new Button();
            btnDischarge = new Button();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(24, 95, 165);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 113);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 14F);
            lblSubtitle.ForeColor = Color.FromArgb(230, 241, 251);
            lblSubtitle.Location = new Point(26, 47);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(155, 38);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Edit Doctor";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 8F);
            lblTitle.ForeColor = Color.FromArgb(181, 212, 244);
            lblTitle.Location = new Point(29, 17);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(252, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // lblSectionPersonal
            // 
            lblSectionPersonal.Font = new Font("Segoe UI", 8F);
            lblSectionPersonal.ForeColor = Color.FromArgb(24, 95, 165);
            lblSectionPersonal.Location = new Point(34, 140);
            lblSectionPersonal.Margin = new Padding(4, 0, 4, 0);
            lblSectionPersonal.Name = "lblSectionPersonal";
            lblSectionPersonal.Size = new Size(227, 33);
            lblSectionPersonal.TabIndex = 1;
            lblSectionPersonal.Text = "PERSONAL INFORMATION";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.FromArgb(24, 95, 165);
            label1.Location = new Point(34, 180);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(731, 30);
            label1.TabIndex = 2;
            label1.Text = "Full Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.ForeColor = Color.FromArgb(20, 35, 60);
            txtName.Location = new Point(34, 213);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(731, 34);
            txtName.TabIndex = 3;
            // 
            // lblSectionProfessional
            // 
            lblSectionProfessional.Font = new Font("Segoe UI", 8F);
            lblSectionProfessional.ForeColor = Color.FromArgb(24, 95, 165);
            lblSectionProfessional.Location = new Point(34, 293);
            lblSectionProfessional.Margin = new Padding(4, 0, 4, 0);
            lblSectionProfessional.Name = "lblSectionProfessional";
            lblSectionProfessional.Size = new Size(731, 33);
            lblSectionProfessional.TabIndex = 4;
            lblSectionProfessional.Text = "PROFESSIONAL DETAILS";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(24, 95, 165);
            label4.Location = new Point(34, 333);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(731, 30);
            label4.TabIndex = 5;
            label4.Text = "Specialization";
            // 
            // txtSpecialization
            // 
            txtSpecialization.BackColor = Color.White;
            txtSpecialization.BorderStyle = BorderStyle.FixedSingle;
            txtSpecialization.Font = new Font("Segoe UI", 10F);
            txtSpecialization.ForeColor = Color.FromArgb(20, 35, 60);
            txtSpecialization.Location = new Point(34, 367);
            txtSpecialization.Margin = new Padding(4, 5, 4, 5);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(731, 34);
            txtSpecialization.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(24, 95, 165);
            label3.Location = new Point(34, 440);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(350, 30);
            label3.TabIndex = 7;
            label3.Text = "Ward";
            // 
            // cmbWard
            // 
            cmbWard.BackColor = Color.White;
            cmbWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWard.FlatStyle = FlatStyle.Flat;
            cmbWard.Font = new Font("Segoe UI", 10F);
            cmbWard.ForeColor = Color.FromArgb(20, 35, 60);
            cmbWard.FormattingEnabled = true;
            cmbWard.Location = new Point(34, 473);
            cmbWard.Margin = new Padding(4, 5, 4, 5);
            cmbWard.Name = "cmbWard";
            cmbWard.Size = new Size(348, 36);
            cmbWard.TabIndex = 8;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(24, 95, 165);
            label2.Location = new Point(416, 440);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(350, 30);
            label2.TabIndex = 9;
            label2.Text = "Monthly Salary";
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.White;
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.Font = new Font("Segoe UI", 10F);
            txtSalary.ForeColor = Color.FromArgb(20, 35, 60);
            txtSalary.Location = new Point(416, 473);
            txtSalary.Margin = new Padding(4, 5, 4, 5);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(349, 34);
            txtSalary.TabIndex = 10;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(235, 243, 251);
            pnlFooter.Controls.Add(btnDischarge);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 564);
            pnlFooter.Margin = new Padding(4, 5, 4, 5);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(800, 93);
            pnlFooter.TabIndex = 20;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(24, 95, 165);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F);
            btnSave.ForeColor = Color.FromArgb(230, 241, 251);
            btnSave.Location = new Point(623, 18);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(157, 57);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDischarge
            // 
            btnDischarge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDischarge.BackColor = Color.FromArgb(163, 45, 45);
            btnDischarge.Cursor = Cursors.Hand;
            btnDischarge.FlatAppearance.BorderSize = 0;
            btnDischarge.FlatStyle = FlatStyle.Flat;
            btnDischarge.Font = new Font("Segoe UI", 9.5F);
            btnDischarge.ForeColor = Color.FromArgb(252, 235, 235);
            btnDischarge.Location = new Point(467, 18);
            btnDischarge.Margin = new Padding(4, 5, 4, 5);
            btnDischarge.Name = "btnDischarge";
            btnDischarge.Size = new Size(157, 57);
            btnDischarge.TabIndex = 2;
            btnDischarge.Text = "Fire";
            btnDischarge.UseVisualStyleBackColor = false;
            btnDischarge.Click += btnDischarge_Click;
            // 
            // EditDoctorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 251);
            ClientSize = new Size(800, 657);
            Controls.Add(txtSalary);
            Controls.Add(label2);
            Controls.Add(cmbWard);
            Controls.Add(label3);
            Controls.Add(txtSpecialization);
            Controls.Add(label4);
            Controls.Add(lblSectionProfessional);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(lblSectionPersonal);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditDoctorForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Doctor";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblSectionPersonal;
        private Label label1;
        private TextBox txtName;
        private Label lblSectionProfessional;
        private Label label4;
        private TextBox txtSpecialization;
        private Label label3;
        private ComboBox cmbWard;
        private Label label2;
        private TextBox txtSalary;
        private Panel pnlFooter;
        private Button btnSave;
        private Button btnDischarge;
    }
}