namespace Hospital_Management.Forms
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            pnlHeader = new Panel();
            pnlCross = new Panel();
            pnlCrossH = new Panel();
            pnlCrossV = new Panel();
            lblHospitalName = new Label();
            lblSubtitle = new Label();
            pnlForm = new Panel();
            adminButton = new Button();
            doctorButton = new Button();
            patientButton = new Button();
            lblTitle = new Label();
            lblUsernameHint = new Label();
            txtUsername = new TextBox();
            lblPasswordHint = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pnlHeader.SuspendLayout();
            pnlCross.SuspendLayout();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(18, 22, 40);
            pnlHeader.Controls.Add(pnlCross);
            pnlHeader.Controls.Add(lblHospitalName);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(743, 255);
            pnlHeader.TabIndex = 0;
            // 
            // pnlCross
            // 
            pnlCross.BackColor = Color.Transparent;
            pnlCross.Controls.Add(pnlCrossH);
            pnlCross.Controls.Add(pnlCrossV);
            pnlCross.Location = new Point(297, 5);
            pnlCross.Margin = new Padding(4, 5, 4, 5);
            pnlCross.Name = "pnlCross";
            pnlCross.Size = new Size(119, 116);
            pnlCross.TabIndex = 0;
            // 
            // pnlCrossH
            // 
            pnlCrossH.BackColor = Color.FromArgb(99, 179, 237);
            pnlCrossH.Location = new Point(24, 51);
            pnlCrossH.Margin = new Padding(4, 5, 4, 5);
            pnlCrossH.Name = "pnlCrossH";
            pnlCrossH.Size = new Size(74, 37);
            pnlCrossH.TabIndex = 0;
            // 
            // pnlCrossV
            // 
            pnlCrossV.BackColor = Color.FromArgb(99, 179, 237);
            pnlCrossV.Location = new Point(46, 19);
            pnlCrossV.Margin = new Padding(4, 5, 4, 5);
            pnlCrossV.Name = "pnlCrossV";
            pnlCrossV.Size = new Size(30, 90);
            pnlCrossV.TabIndex = 1;
            // 
            // lblHospitalName
            // 
            lblHospitalName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHospitalName.ForeColor = Color.FromArgb(220, 225, 255);
            lblHospitalName.Location = new Point(4, 126);
            lblHospitalName.Margin = new Padding(4, 0, 4, 0);
            lblHospitalName.Name = "lblHospitalName";
            lblHospitalName.Size = new Size(743, 70);
            lblHospitalName.TabIndex = 2;
            lblHospitalName.Text = "City Care Hospital";
            lblHospitalName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 8F);
            lblSubtitle.ForeColor = Color.FromArgb(80, 95, 150);
            lblSubtitle.Location = new Point(4, 196);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(743, 43);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "HOSPITAL MANAGEMENT SYSTEM";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.FromArgb(22, 27, 50);
            pnlForm.Controls.Add(adminButton);
            pnlForm.Controls.Add(doctorButton);
            pnlForm.Controls.Add(patientButton);
            pnlForm.Controls.Add(lblTitle);
            pnlForm.Controls.Add(lblUsernameHint);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblPasswordHint);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(btnLogin);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 255);
            pnlForm.Margin = new Padding(4, 5, 4, 5);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(743, 521);
            pnlForm.TabIndex = 1;
            // 
            // adminButton
            // 
            adminButton.BackColor = Color.FromArgb(37, 99, 180);
            adminButton.FlatAppearance.BorderColor = Color.FromArgb(18, 22, 40);
            adminButton.FlatAppearance.BorderSize = 0;
            adminButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 78, 150);
            adminButton.FlatStyle = FlatStyle.Flat;
            adminButton.ForeColor = SystemColors.ButtonFace;
            adminButton.Location = new Point(121, 41);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(170, 106);
            adminButton.TabIndex = 10;
            adminButton.Text = "button2";
            adminButton.UseVisualStyleBackColor = false;
            adminButton.Click += button2_Click_1;
            // 
            // doctorButton
            // 
            doctorButton.BackColor = Color.FromArgb(37, 99, 180);
            doctorButton.FlatAppearance.BorderColor = Color.FromArgb(18, 22, 40);
            doctorButton.FlatAppearance.BorderSize = 0;
            doctorButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 78, 150);
            doctorButton.FlatStyle = FlatStyle.Flat;
            doctorButton.ForeColor = SystemColors.ButtonFace;
            doctorButton.Location = new Point(297, 41);
            doctorButton.Name = "doctorButton";
            doctorButton.Size = new Size(161, 106);
            doctorButton.TabIndex = 9;
            doctorButton.Text = "button1";
            doctorButton.UseVisualStyleBackColor = false;
            doctorButton.Click += doctorButton_Click;
            // 
            // patientButton
            // 
            patientButton.BackColor = Color.FromArgb(37, 99, 180);
            patientButton.FlatAppearance.BorderColor = Color.FromArgb(18, 22, 40);
            patientButton.FlatAppearance.BorderSize = 0;
            patientButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 78, 150);
            patientButton.FlatStyle = FlatStyle.Flat;
            patientButton.ForeColor = SystemColors.ButtonFace;
            patientButton.Location = new Point(464, 41);
            patientButton.Name = "patientButton";
            patientButton.Size = new Size(163, 106);
            patientButton.TabIndex = 8;
            patientButton.Text = "button3";
            patientButton.UseVisualStyleBackColor = false;
            patientButton.Click += patientButton_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(210, 218, 255);
            lblTitle.Location = new Point(-13, 176);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(743, 63);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sign in to your account";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsernameHint
            // 
            lblUsernameHint.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblUsernameHint.ForeColor = Color.FromArgb(80, 95, 150);
            lblUsernameHint.Location = new Point(115, 239);
            lblUsernameHint.Margin = new Padding(4, 0, 4, 0);
            lblUsernameHint.Name = "lblUsernameHint";
            lblUsernameHint.Size = new Size(514, 30);
            lblUsernameHint.TabIndex = 1;
            lblUsernameHint.Text = "USERNAME";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(30, 36, 66);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.FromArgb(210, 215, 245);
            txtUsername.Location = new Point(115, 274);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(513, 34);
            txtUsername.TabIndex = 2;
            // 
            // lblPasswordHint
            // 
            lblPasswordHint.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblPasswordHint.ForeColor = Color.FromArgb(80, 95, 150);
            lblPasswordHint.Location = new Point(113, 349);
            lblPasswordHint.Margin = new Padding(4, 0, 4, 0);
            lblPasswordHint.Name = "lblPasswordHint";
            lblPasswordHint.Size = new Size(514, 30);
            lblPasswordHint.TabIndex = 3;
            lblPasswordHint.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(30, 36, 66);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.FromArgb(210, 215, 245);
            txtPassword.Location = new Point(115, 384);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(513, 34);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(37, 99, 180);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 78, 150);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(192, 452);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(341, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 22, 40);
            ClientSize = new Size(743, 776);
            Controls.Add(pnlForm);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "loginform";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "City Care Hospital";
            Load += loginform_Load;
            pnlHeader.ResumeLayout(false);
            pnlCross.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlCross;
        private Panel pnlCrossH;
        private Panel pnlCrossV;
        private Label lblHospitalName;
        private Label lblSubtitle;
        private Panel pnlForm;
        private Label lblTitle;
        private TextBox txtUsername;
        private Label lblPasswordHint;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button patientButton;
        private Label lblUsernameHint;
        private Button adminButton;
        private Button doctorButton;
    }
}