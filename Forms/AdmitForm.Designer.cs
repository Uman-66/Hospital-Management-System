namespace Hospital_Management.Forms
{
    partial class AdmitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmitForm));
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            lblSectionPersonal = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblSectionAccount = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblSectionWard = new Label();
            lblWard = new Label();
            cmbWard = new ComboBox();
            lblBed = new Label();
            txtBed = new TextBox();
            lblCharge = new Label();
            txtCharge = new TextBox();
            pnlFooter = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
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
            pnlHeader.Size = new Size(877, 113);
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
            lblSubtitle.Size = new Size(238, 38);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Patient Admission";
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
            lblSectionPersonal.Size = new Size(211, 33);
            lblSectionPersonal.TabIndex = 1;
            lblSectionPersonal.Text = "PERSONAL INFORMATION";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 9F);
            lblName.ForeColor = Color.FromArgb(24, 95, 165);
            lblName.Location = new Point(34, 180);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(95, 30);
            lblName.TabIndex = 2;
            lblName.Text = "Full Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(34, 213);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(808, 34);
            txtName.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.Font = new Font("Segoe UI", 9F);
            lblAge.ForeColor = Color.FromArgb(24, 95, 165);
            lblAge.Location = new Point(34, 283);
            lblAge.Margin = new Padding(4, 0, 4, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(51, 30);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 10F);
            txtAge.Location = new Point(34, 317);
            txtAge.Margin = new Padding(4, 5, 4, 5);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(385, 34);
            txtAge.TabIndex = 5;
            // 
            // lblGender
            // 
            lblGender.Font = new Font("Segoe UI", 9F);
            lblGender.ForeColor = Color.FromArgb(24, 95, 165);
            lblGender.Location = new Point(457, 283);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(87, 30);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.White;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.Flat;
            cmbGender.Font = new Font("Segoe UI", 10F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(457, 317);
            cmbGender.Margin = new Padding(4, 5, 4, 5);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(384, 36);
            cmbGender.TabIndex = 7;
            // 
            // lblSectionAccount
            // 
            lblSectionAccount.Font = new Font("Segoe UI", 8F);
            lblSectionAccount.ForeColor = Color.FromArgb(24, 95, 165);
            lblSectionAccount.Location = new Point(34, 397);
            lblSectionAccount.Margin = new Padding(4, 0, 4, 0);
            lblSectionAccount.Name = "lblSectionAccount";
            lblSectionAccount.Size = new Size(192, 33);
            lblSectionAccount.TabIndex = 8;
            lblSectionAccount.Text = "ACCOUNT CREDENTIALS";
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 9F);
            lblUsername.ForeColor = Color.FromArgb(24, 95, 165);
            lblUsername.Location = new Point(34, 437);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(99, 30);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(34, 470);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(385, 34);
            txtUsername.TabIndex = 10;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.ForeColor = Color.FromArgb(24, 95, 165);
            lblPassword.Location = new Point(457, 437);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 30);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(457, 470);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(385, 34);
            txtPassword.TabIndex = 12;
            // 
            // lblSectionWard
            // 
            lblSectionWard.Font = new Font("Segoe UI", 8F);
            lblSectionWard.ForeColor = Color.FromArgb(24, 95, 165);
            lblSectionWard.Location = new Point(34, 550);
            lblSectionWard.Margin = new Padding(4, 0, 4, 0);
            lblSectionWard.Name = "lblSectionWard";
            lblSectionWard.Size = new Size(134, 33);
            lblSectionWard.TabIndex = 13;
            lblSectionWard.Text = "WARD & BILLING";
            // 
            // lblWard
            // 
            lblWard.Font = new Font("Segoe UI", 9F);
            lblWard.ForeColor = Color.FromArgb(24, 95, 165);
            lblWard.Location = new Point(34, 590);
            lblWard.Margin = new Padding(4, 0, 4, 0);
            lblWard.Name = "lblWard";
            lblWard.Size = new Size(63, 30);
            lblWard.TabIndex = 14;
            lblWard.Text = "Ward";
            // 
            // cmbWard
            // 
            cmbWard.BackColor = Color.White;
            cmbWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWard.FlatStyle = FlatStyle.Flat;
            cmbWard.Font = new Font("Segoe UI", 10F);
            cmbWard.FormattingEnabled = true;
            cmbWard.Location = new Point(34, 623);
            cmbWard.Margin = new Padding(4, 5, 4, 5);
            cmbWard.Name = "cmbWard";
            cmbWard.Size = new Size(384, 36);
            cmbWard.TabIndex = 15;
            // 
            // lblBed
            // 
            lblBed.Font = new Font("Segoe UI", 9F);
            lblBed.ForeColor = Color.FromArgb(24, 95, 165);
            lblBed.Location = new Point(457, 590);
            lblBed.Margin = new Padding(4, 0, 4, 0);
            lblBed.Name = "lblBed";
            lblBed.Size = new Size(114, 30);
            lblBed.TabIndex = 16;
            lblBed.Text = "Bed Number";
            // 
            // txtBed
            // 
            txtBed.BackColor = Color.White;
            txtBed.BorderStyle = BorderStyle.FixedSingle;
            txtBed.Font = new Font("Segoe UI", 10F);
            txtBed.Location = new Point(457, 623);
            txtBed.Margin = new Padding(4, 5, 4, 5);
            txtBed.Name = "txtBed";
            txtBed.Size = new Size(385, 34);
            txtBed.TabIndex = 17;
            // 
            // lblCharge
            // 
            lblCharge.Font = new Font("Segoe UI", 9F);
            lblCharge.ForeColor = Color.FromArgb(24, 95, 165);
            lblCharge.Location = new Point(34, 693);
            lblCharge.Margin = new Padding(4, 0, 4, 0);
            lblCharge.Name = "lblCharge";
            lblCharge.Size = new Size(192, 30);
            lblCharge.TabIndex = 18;
            lblCharge.Text = "Per Night Charge";
            // 
            // txtCharge
            // 
            txtCharge.BackColor = Color.White;
            txtCharge.BorderStyle = BorderStyle.FixedSingle;
            txtCharge.Font = new Font("Segoe UI", 10F);
            txtCharge.Location = new Point(34, 727);
            txtCharge.Margin = new Padding(4, 5, 4, 5);
            txtCharge.Name = "txtCharge";
            txtCharge.Size = new Size(808, 34);
            txtCharge.TabIndex = 19;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(235, 243, 251);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 814);
            pnlFooter.Margin = new Padding(4, 5, 4, 5);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(877, 93);
            pnlFooter.TabIndex = 20;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(24, 95, 165);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F);
            btnSave.ForeColor = Color.FromArgb(230, 241, 251);
            btnSave.Location = new Point(700, 18);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(157, 57);
            btnSave.TabIndex = 1;
            btnSave.Text = "Admit Patient";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(181, 212, 244);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.ForeColor = Color.FromArgb(24, 95, 165);
            btnCancel.Location = new Point(543, 18);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 57);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // AdmitForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 251);
            ClientSize = new Size(877, 907);
            Controls.Add(txtCharge);
            Controls.Add(lblCharge);
            Controls.Add(txtBed);
            Controls.Add(lblBed);
            Controls.Add(cmbWard);
            Controls.Add(lblWard);
            Controls.Add(lblSectionWard);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblSectionAccount);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblSectionPersonal);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "AdmitForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Admission";
            Load += AdmitForm_Load;
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
        private Label lblName;
        private TextBox txtName;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblSectionAccount;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblSectionWard;
        private Label lblWard;
        private ComboBox cmbWard;
        private Label lblBed;
        private TextBox txtBed;
        private Label lblCharge;
        private TextBox txtCharge;
        private Panel pnlFooter;
        private Button btnCancel;
        private Button btnSave;
    }
}