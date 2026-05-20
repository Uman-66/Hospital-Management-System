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
            pnlHeader.BackColor = Color.FromArgb(12, 44, 80);
            pnlHeader.Controls.Add(pnlCross);
            pnlHeader.Controls.Add(lblHospitalName);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(629, 300);
            pnlHeader.TabIndex = 0;
            // 
            // pnlCross
            // 
            pnlCross.BackColor = Color.Transparent;
            pnlCross.Controls.Add(pnlCrossH);
            pnlCross.Controls.Add(pnlCrossV);
            pnlCross.Location = new Point(273, 37);
            pnlCross.Margin = new Padding(4, 5, 4, 5);
            pnlCross.Name = "pnlCross";
            pnlCross.Size = new Size(83, 97);
            pnlCross.TabIndex = 0;
            // 
            // pnlCrossH
            // 
            pnlCrossH.BackColor = Color.FromArgb(181, 212, 244);
            pnlCrossH.Location = new Point(0, 32);
            pnlCrossH.Margin = new Padding(4, 5, 4, 5);
            pnlCrossH.Name = "pnlCrossH";
            pnlCrossH.Size = new Size(83, 33);
            pnlCrossH.TabIndex = 0;
            // 
            // pnlCrossV
            // 
            pnlCrossV.BackColor = Color.FromArgb(181, 212, 244);
            pnlCrossV.Location = new Point(27, 0);
            pnlCrossV.Margin = new Padding(4, 5, 4, 5);
            pnlCrossV.Name = "pnlCrossV";
            pnlCrossV.Size = new Size(29, 97);
            pnlCrossV.TabIndex = 1;
            // 
            // lblHospitalName
            // 
            lblHospitalName.Font = new Font("Segoe UI", 13F);
            lblHospitalName.ForeColor = Color.FromArgb(230, 241, 251);
            lblHospitalName.Location = new Point(0, 153);
            lblHospitalName.Margin = new Padding(4, 0, 4, 0);
            lblHospitalName.Name = "lblHospitalName";
            lblHospitalName.Size = new Size(629, 50);
            lblHospitalName.TabIndex = 2;
            lblHospitalName.Text = "City Care Hospital";
            lblHospitalName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 8.5F);
            lblSubtitle.ForeColor = Color.FromArgb(181, 212, 244);
            lblSubtitle.Location = new Point(0, 207);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(629, 33);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "HOSPITAL MANAGEMENT SYSTEM";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.FromArgb(235, 243, 251);
            pnlForm.Controls.Add(lblTitle);
            pnlForm.Controls.Add(lblUsernameHint);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblPasswordHint);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(btnLogin);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new Point(0, 300);
            pnlForm.Margin = new Padding(4, 5, 4, 5);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(629, 383);
            pnlForm.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 11F);
            lblTitle.ForeColor = Color.FromArgb(24, 95, 165);
            lblTitle.Location = new Point(0, 33);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(629, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sign in to your account";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsernameHint
            // 
            lblUsernameHint.Font = new Font("Segoe UI", 8.5F);
            lblUsernameHint.ForeColor = Color.FromArgb(24, 95, 165);
            lblUsernameHint.Location = new Point(114, 87);
            lblUsernameHint.Margin = new Padding(4, 0, 4, 0);
            lblUsernameHint.Name = "lblUsernameHint";
            lblUsernameHint.Size = new Size(400, 27);
            lblUsernameHint.TabIndex = 1;
            lblUsernameHint.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.FromArgb(20, 35, 60);
            txtUsername.Location = new Point(114, 117);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(399, 34);
            txtUsername.TabIndex = 2;
            // 
            // lblPasswordHint
            // 
            lblPasswordHint.Font = new Font("Segoe UI", 8.5F);
            lblPasswordHint.ForeColor = Color.FromArgb(24, 95, 165);
            lblPasswordHint.Location = new Point(114, 187);
            lblPasswordHint.Margin = new Padding(4, 0, 4, 0);
            lblPasswordHint.Name = "lblPasswordHint";
            lblPasswordHint.Size = new Size(400, 27);
            lblPasswordHint.TabIndex = 3;
            lblPasswordHint.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.FromArgb(20, 35, 60);
            txtPassword.Location = new Point(114, 217);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(399, 34);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(24, 95, 165);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F);
            btnLogin.ForeColor = Color.FromArgb(230, 241, 251);
            btnLogin.Location = new Point(114, 293);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(400, 60);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 251);
            ClientSize = new Size(629, 683);
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
        private Label lblUsernameHint;
        private TextBox txtUsername;
        private Label lblPasswordHint;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}