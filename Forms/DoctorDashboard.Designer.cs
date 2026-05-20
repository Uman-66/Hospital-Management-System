namespace Hospital_Management.Forms
{
    partial class DoctorDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDashboard));
            pnlMain = new Panel();
            pnlSidebar = new Panel();
            pnlLogoArea = new Panel();
            lblDoctorPortal = new Label();
            lblSubtitle = new Label();
            btnHome = new Button();
            btnPrescribe = new Button();
            btnPatientHistory = new Button();
            btnLogout = new Button();
            pnlSidebar.SuspendLayout();
            pnlLogoArea.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(240, 245, 240);
            pnlMain.Location = new Point(300, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1569, 1170);
            pnlMain.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(30, 58, 38);
            pnlSidebar.Controls.Add(pnlLogoArea);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Controls.Add(btnPrescribe);
            pnlSidebar.Controls.Add(btnPatientHistory);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(300, 1170);
            pnlSidebar.TabIndex = 1;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // pnlLogoArea
            // 
            pnlLogoArea.BackColor = Color.FromArgb(22, 44, 28);
            pnlLogoArea.Controls.Add(lblDoctorPortal);
            pnlLogoArea.Controls.Add(lblSubtitle);
            pnlLogoArea.Location = new Point(0, 0);
            pnlLogoArea.Name = "pnlLogoArea";
            pnlLogoArea.Size = new Size(300, 110);
            pnlLogoArea.TabIndex = 10;
            // 
            // lblDoctorPortal
            // 
            lblDoctorPortal.AutoSize = true;
            lblDoctorPortal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDoctorPortal.ForeColor = Color.FromArgb(195, 230, 200);
            lblDoctorPortal.Location = new Point(22, 22);
            lblDoctorPortal.Name = "lblDoctorPortal";
            lblDoctorPortal.Size = new Size(178, 36);
            lblDoctorPortal.TabIndex = 0;
            lblDoctorPortal.Text = "Doctor Portal";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 8.5F);
            lblSubtitle.ForeColor = Color.FromArgb(130, 175, 138);
            lblSubtitle.Location = new Point(24, 58);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(139, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "The City Hospital";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(88, 148, 100);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 105, 65);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 128, 84);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(45, 150);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(210, 46);
            btnHome.TabIndex = 0;
            btnHome.Text = "   Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnPrescribe
            // 
            btnPrescribe.BackColor = Color.FromArgb(30, 58, 38);
            btnPrescribe.Cursor = Cursors.Hand;
            btnPrescribe.FlatAppearance.BorderSize = 0;
            btnPrescribe.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 65, 44);
            btnPrescribe.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 82, 55);
            btnPrescribe.FlatStyle = FlatStyle.Flat;
            btnPrescribe.Font = new Font("Segoe UI", 10.5F);
            btnPrescribe.ForeColor = Color.FromArgb(170, 210, 175);
            btnPrescribe.Location = new Point(45, 224);
            btnPrescribe.Name = "btnPrescribe";
            btnPrescribe.Size = new Size(210, 46);
            btnPrescribe.TabIndex = 3;
            btnPrescribe.Text = "   Prescribe Medicine";
            btnPrescribe.TextAlign = ContentAlignment.MiddleLeft;
            btnPrescribe.UseVisualStyleBackColor = false;
            btnPrescribe.Click += btnPrescribe_Click;
            // 
            // btnPatientHistory
            // 
            btnPatientHistory.BackColor = Color.FromArgb(30, 58, 38);
            btnPatientHistory.Cursor = Cursors.Hand;
            btnPatientHistory.FlatAppearance.BorderSize = 0;
            btnPatientHistory.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 65, 44);
            btnPatientHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 82, 55);
            btnPatientHistory.FlatStyle = FlatStyle.Flat;
            btnPatientHistory.Font = new Font("Segoe UI", 10.5F);
            btnPatientHistory.ForeColor = Color.FromArgb(170, 210, 175);
            btnPatientHistory.Location = new Point(45, 298);
            btnPatientHistory.Name = "btnPatientHistory";
            btnPatientHistory.Size = new Size(210, 46);
            btnPatientHistory.TabIndex = 2;
            btnPatientHistory.Text = "   Patient History";
            btnPatientHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnPatientHistory.UseVisualStyleBackColor = false;
            btnPatientHistory.Click += btnPatientHistory_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(175, 65, 50);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 35, 25);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(148, 50, 38);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(45, 1080);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(210, 46);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "   Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // DoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 240);
            ClientSize = new Size(1869, 1170);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoctorDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The City Hospital  -  Doctor Portal";
            pnlSidebar.ResumeLayout(false);
            pnlLogoArea.ResumeLayout(false);
            pnlLogoArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Panel pnlSidebar;
        private Panel pnlLogoArea;
        private Label lblDoctorPortal;
        private Label lblSubtitle;
        private Button btnHome;
        private Button btnPrescribe;
        private Button btnPatientHistory;
        private Button btnLogout;
    }
}