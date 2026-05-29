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

            // pnlHeader
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(18, 22, 40);
            pnlHeader.Controls.Add(pnlCross);
            pnlHeader.Controls.Add(lblHospitalName);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(520, 280);
            pnlHeader.TabIndex = 0;

            // pnlCross
            pnlCross.BackColor = System.Drawing.Color.Transparent;
            pnlCross.Controls.Add(pnlCrossH);
            pnlCross.Controls.Add(pnlCrossV);
            pnlCross.Location = new System.Drawing.Point(220, 46);
            pnlCross.Name = "pnlCross";
            pnlCross.Size = new System.Drawing.Size(80, 80);
            pnlCross.TabIndex = 0;

            // pnlCrossH
            pnlCrossH.BackColor = System.Drawing.Color.FromArgb(99, 179, 237);
            pnlCrossH.Location = new System.Drawing.Point(0, 27);
            pnlCrossH.Name = "pnlCrossH";
            pnlCrossH.Size = new System.Drawing.Size(80, 26);
            pnlCrossH.TabIndex = 0;

            // pnlCrossV
            pnlCrossV.BackColor = System.Drawing.Color.FromArgb(99, 179, 237);
            pnlCrossV.Location = new System.Drawing.Point(27, 0);
            pnlCrossV.Name = "pnlCrossV";
            pnlCrossV.Size = new System.Drawing.Size(26, 80);
            pnlCrossV.TabIndex = 1;

            // lblHospitalName
            lblHospitalName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblHospitalName.ForeColor = System.Drawing.Color.FromArgb(220, 225, 255);
            lblHospitalName.Location = new System.Drawing.Point(0, 148);
            lblHospitalName.Name = "lblHospitalName";
            lblHospitalName.Size = new System.Drawing.Size(520, 42);
            lblHospitalName.TabIndex = 2;
            lblHospitalName.Text = "City Care Hospital";
            lblHospitalName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitle
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(80, 95, 150);
            lblSubtitle.Location = new System.Drawing.Point(0, 194);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(520, 26);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "HOSPITAL MANAGEMENT SYSTEM";
            lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlForm
            pnlForm.BackColor = System.Drawing.Color.FromArgb(22, 27, 50);
            pnlForm.Controls.Add(lblTitle);
            pnlForm.Controls.Add(lblUsernameHint);
            pnlForm.Controls.Add(txtUsername);
            pnlForm.Controls.Add(lblPasswordHint);
            pnlForm.Controls.Add(txtPassword);
            pnlForm.Controls.Add(btnLogin);
            pnlForm.Dock = DockStyle.Fill;
            pnlForm.Location = new System.Drawing.Point(0, 280);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new System.Drawing.Size(520, 360);
            pnlForm.TabIndex = 1;

            // lblTitle
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(210, 218, 255);
            lblTitle.Location = new System.Drawing.Point(0, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(520, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sign in to your account";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblUsernameHint
            lblUsernameHint.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            lblUsernameHint.ForeColor = System.Drawing.Color.FromArgb(80, 95, 150);
            lblUsernameHint.Location = new System.Drawing.Point(80, 84);
            lblUsernameHint.Name = "lblUsernameHint";
            lblUsernameHint.Size = new System.Drawing.Size(360, 18);
            lblUsernameHint.TabIndex = 1;
            lblUsernameHint.Text = "USERNAME";

            // txtUsername
            txtUsername.BackColor = System.Drawing.Color.FromArgb(30, 36, 66);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtUsername.ForeColor = System.Drawing.Color.FromArgb(210, 215, 245);
            txtUsername.Location = new System.Drawing.Point(80, 106);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new System.Drawing.Size(360, 36);
            txtUsername.TabIndex = 2;

            // lblPasswordHint
            lblPasswordHint.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            lblPasswordHint.ForeColor = System.Drawing.Color.FromArgb(80, 95, 150);
            lblPasswordHint.Location = new System.Drawing.Point(80, 162);
            lblPasswordHint.Name = "lblPasswordHint";
            lblPasswordHint.Size = new System.Drawing.Size(360, 18);
            lblPasswordHint.TabIndex = 3;
            lblPasswordHint.Text = "PASSWORD";

            // txtPassword
            txtPassword.BackColor = System.Drawing.Color.FromArgb(30, 36, 66);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtPassword.ForeColor = System.Drawing.Color.FromArgb(210, 215, 245);
            txtPassword.Location = new System.Drawing.Point(80, 184);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new System.Drawing.Size(360, 36);
            txtPassword.TabIndex = 4;

            // btnLogin
            btnLogin.BackColor = System.Drawing.Color.FromArgb(37, 99, 180);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(28, 78, 150);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(80, 258);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(360, 52);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // Form
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(18, 22, 40);
            ClientSize = new System.Drawing.Size(520, 640);
            Controls.Add(pnlForm);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "loginform";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "City Care Hospital";
            Load += new System.EventHandler(this.loginform_Load);

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