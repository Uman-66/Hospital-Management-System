namespace Hospital_Management.Forms
{
    partial class AddDoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDoctorForm));
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            lblSectionPersonal = new Label();
            label1 = new Label();
            txtName = new TextBox();
            label7 = new Label();
            txtUsername = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            lblSectionProfessional = new Label();
            label5 = new Label();
            txtSpecialization = new TextBox();
            label4 = new Label();
            cmbWard = new ComboBox();
            label3 = new Label();
            txtSalary = new TextBox();
            pnlFooter = new Panel();
            btnSave = new Button();
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
            lblSubtitle.Size = new Size(159, 38);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Add Doctor";
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
            lblSectionPersonal.Size = new Size(214, 33);
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
            label1.Size = new Size(93, 30);
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
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.FromArgb(24, 95, 165);
            label7.Location = new Point(34, 287);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(104, 30);
            label7.TabIndex = 4;
            label7.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.FromArgb(20, 35, 60);
            txtUsername.Location = new Point(34, 320);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(349, 34);
            txtUsername.TabIndex = 5;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.FromArgb(24, 95, 165);
            label6.Location = new Point(416, 287);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 30);
            label6.TabIndex = 6;
            label6.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.FromArgb(20, 35, 60);
            txtPassword.Location = new Point(416, 320);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(349, 34);
            txtPassword.TabIndex = 7;
            // 
            // lblSectionProfessional
            // 
            lblSectionProfessional.Font = new Font("Segoe UI", 8F);
            lblSectionProfessional.ForeColor = Color.FromArgb(24, 95, 165);
            lblSectionProfessional.Location = new Point(34, 400);
            lblSectionProfessional.Margin = new Padding(4, 0, 4, 0);
            lblSectionProfessional.Name = "lblSectionProfessional";
            lblSectionProfessional.Size = new Size(202, 33);
            lblSectionProfessional.TabIndex = 8;
            lblSectionProfessional.Text = "PROFESSIONAL DETAILS";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = Color.FromArgb(24, 95, 165);
            label5.Location = new Point(34, 440);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 30);
            label5.TabIndex = 9;
            label5.Text = "Specialization";
            // 
            // txtSpecialization
            // 
            txtSpecialization.BackColor = Color.White;
            txtSpecialization.BorderStyle = BorderStyle.FixedSingle;
            txtSpecialization.Font = new Font("Segoe UI", 10F);
            txtSpecialization.ForeColor = Color.FromArgb(20, 35, 60);
            txtSpecialization.Location = new Point(34, 473);
            txtSpecialization.Margin = new Padding(4, 5, 4, 5);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(731, 34);
            txtSpecialization.TabIndex = 10;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(24, 95, 165);
            label4.Location = new Point(34, 547);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 30);
            label4.TabIndex = 11;
            label4.Text = "Ward";
            // 
            // cmbWard
            // 
            cmbWard.BackColor = Color.White;
            cmbWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWard.FlatStyle = FlatStyle.Flat;
            cmbWard.Font = new Font("Segoe UI", 10F);
            cmbWard.ForeColor = Color.FromArgb(20, 35, 60);
            cmbWard.FormattingEnabled = true;
            cmbWard.Location = new Point(34, 580);
            cmbWard.Margin = new Padding(4, 5, 4, 5);
            cmbWard.Name = "cmbWard";
            cmbWard.Size = new Size(348, 36);
            cmbWard.TabIndex = 12;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(24, 95, 165);
            label3.Location = new Point(416, 547);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 30);
            label3.TabIndex = 13;
            label3.Text = "Monthly Salary";
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.White;
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.Font = new Font("Segoe UI", 10F);
            txtSalary.ForeColor = Color.FromArgb(20, 35, 60);
            txtSalary.Location = new Point(416, 580);
            txtSalary.Margin = new Padding(4, 5, 4, 5);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(349, 34);
            txtSalary.TabIndex = 14;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(235, 243, 251);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 670);
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
            btnSave.Text = "Add Doctor";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddDoctorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 251);
            ClientSize = new Size(800, 763);
            Controls.Add(txtSalary);
            Controls.Add(label3);
            Controls.Add(cmbWard);
            Controls.Add(label4);
            Controls.Add(txtSpecialization);
            Controls.Add(label5);
            Controls.Add(lblSectionProfessional);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtUsername);
            Controls.Add(label7);
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
            Name = "AddDoctorForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Doctor";
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
        private Label label7;
        private TextBox txtUsername;
        private Label label6;
        private TextBox txtPassword;
        private Label lblSectionProfessional;
        private Label label5;
        private TextBox txtSpecialization;
        private Label label4;
        private ComboBox cmbWard;
        private Label label3;
        private TextBox txtSalary;
        private Panel pnlFooter;
        private Button btnSave;
    }
}