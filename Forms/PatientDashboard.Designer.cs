namespace Hospital_Management.Forms
{
    partial class PatientDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDashboard));
            this.pnlSidebar = new Panel();
            this.lblPatientPortal = new Label();
            this.btnMyInfo = new Button();
            this.btnMyBill = new Button();
            this.btnLogout = new Button();
            this.pnlMain = new Panel();
            this.pnlWelcome = new Panel();
            this.lblWelcomeTitle = new Label();
            this.lblWardCaption = new Label();
            this.lblWardValue = new Label();
            this.lblBedCaption = new Label();
            this.lblBedValue = new Label();
            this.lblDoctorCaption = new Label();
            this.lblDoctorValue = new Label();
            this.lblMeetingCaption = new Label();
            this.lblMeetingValue = new Label();
            this.lblBillCaption = new Label();
            this.lblBillValue = new Label();
            this.namelabl = new Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.BackColor = Color.FromArgb(44, 31, 22);
            this.pnlSidebar.Controls.Add(this.lblPatientPortal);
            this.pnlSidebar.Controls.Add(this.btnMyInfo);
            this.pnlSidebar.Controls.Add(this.btnMyBill);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = DockStyle.Left;
            this.pnlSidebar.Location = new Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new Size(300, 1151);
            this.pnlSidebar.TabIndex = 0;

            // lblPatientPortal
            this.lblPatientPortal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            this.lblPatientPortal.ForeColor = Color.FromArgb(230, 195, 160);
            this.lblPatientPortal.Location = new Point(0, 55);
            this.lblPatientPortal.Name = "lblPatientPortal";
            this.lblPatientPortal.Size = new Size(300, 40);
            this.lblPatientPortal.TabIndex = 10;
            this.lblPatientPortal.Text = "Patient Portal";
            this.lblPatientPortal.TextAlign = ContentAlignment.MiddleCenter;

            // btnMyInfo
            this.btnMyInfo.BackColor = Color.FromArgb(185, 120, 55);
            this.btnMyInfo.Cursor = Cursors.Hand;
            this.btnMyInfo.FlatAppearance.BorderSize = 0;
            this.btnMyInfo.FlatStyle = FlatStyle.Flat;
            this.btnMyInfo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            this.btnMyInfo.ForeColor = Color.White;
            this.btnMyInfo.Location = new Point(62, 150);
            this.btnMyInfo.Name = "btnMyInfo";
            this.btnMyInfo.Size = new Size(175, 42);
            this.btnMyInfo.TabIndex = 0;
            this.btnMyInfo.Text = "  My Info";
            this.btnMyInfo.TextAlign = ContentAlignment.MiddleLeft;
            this.btnMyInfo.UseVisualStyleBackColor = false;
            this.btnMyInfo.Click += new EventHandler(this.btnMyInfo_Click);

            // btnMyBill
            this.btnMyBill.BackColor = Color.FromArgb(44, 31, 22);
            this.btnMyBill.Cursor = Cursors.Hand;
            this.btnMyBill.FlatAppearance.BorderSize = 0;
            this.btnMyBill.FlatStyle = FlatStyle.Flat;
            this.btnMyBill.Font = new Font("Segoe UI", 10F);
            this.btnMyBill.ForeColor = Color.FromArgb(210, 180, 150);
            this.btnMyBill.Location = new Point(62, 224);
            this.btnMyBill.Name = "btnMyBill";
            this.btnMyBill.Size = new Size(175, 42);
            this.btnMyBill.TabIndex = 3;
            this.btnMyBill.Text = "  My Bill";
            this.btnMyBill.TextAlign = ContentAlignment.MiddleLeft;
            this.btnMyBill.UseVisualStyleBackColor = false;
            this.btnMyBill.Click += new EventHandler(this.btnMyBill_Click);

            // btnLogout
            this.btnLogout.BackColor = Color.FromArgb(175, 65, 50);
            this.btnLogout.Cursor = Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogout.ForeColor = Color.White;
            this.btnLogout.Location = new Point(11, 870);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new Size(175, 42);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            // pnlMain
            this.pnlMain.BackColor = Color.FromArgb(248, 243, 235);
            this.pnlMain.Controls.Add(this.pnlWelcome);
            this.pnlMain.Dock = DockStyle.Fill;
            this.pnlMain.Location = new Point(300, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new Size(1544, 1151);
            this.pnlMain.TabIndex = 1;

            // pnlWelcome
            this.pnlWelcome.BackColor = Color.FromArgb(248, 243, 235);
            this.pnlWelcome.Controls.Add(this.lblWelcomeTitle);
            this.pnlWelcome.Controls.Add(this.lblWardCaption);
            this.pnlWelcome.Controls.Add(this.lblWardValue);
            this.pnlWelcome.Controls.Add(this.lblBedCaption);
            this.pnlWelcome.Controls.Add(this.lblBedValue);
            this.pnlWelcome.Controls.Add(this.lblDoctorCaption);
            this.pnlWelcome.Controls.Add(this.lblDoctorValue);
            this.pnlWelcome.Controls.Add(this.lblMeetingCaption);
            this.pnlWelcome.Controls.Add(this.lblMeetingValue);
            this.pnlWelcome.Controls.Add(this.lblBillCaption);
            this.pnlWelcome.Controls.Add(this.lblBillValue);
            this.pnlWelcome.Controls.Add(this.namelabl);
            this.pnlWelcome.Dock = DockStyle.Fill;
            this.pnlWelcome.Location = new Point(0, 0);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new Size(1544, 1151);
            this.pnlWelcome.TabIndex = 0;

            // lblWelcomeTitle
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblWelcomeTitle.ForeColor = Color.FromArgb(44, 31, 22);
            this.lblWelcomeTitle.Location = new Point(40, 40);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new Size(160, 48);
            this.lblWelcomeTitle.TabIndex = 0;
            this.lblWelcomeTitle.Text = "Welcome,";

            // namelabl
            this.namelabl.AutoSize = true;
            this.namelabl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.namelabl.ForeColor = Color.FromArgb(185, 120, 55);
            this.namelabl.Location = new Point(210, 44);
            this.namelabl.Name = "namelabl";
            this.namelabl.Size = new Size(0, 45);
            this.namelabl.TabIndex = 1;

            // Ward
            this.lblWardCaption.AutoSize = true;
            this.lblWardCaption.Font = new Font("Segoe UI", 12F);
            this.lblWardCaption.Location = new Point(40, 130);
            this.lblWardCaption.Name = "lblWardCaption";
            this.lblWardCaption.Size = new Size(70, 32);
            this.lblWardCaption.TabIndex = 2;
            this.lblWardCaption.Text = "Ward:";

            this.lblWardValue.AutoSize = true;
            this.lblWardValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblWardValue.Location = new Point(130, 130);
            this.lblWardValue.Name = "lblWardValue";
            this.lblWardValue.Size = new Size(0, 32);
            this.lblWardValue.TabIndex = 3;

            // Bed
            this.lblBedCaption.AutoSize = true;
            this.lblBedCaption.Font = new Font("Segoe UI", 12F);
            this.lblBedCaption.Location = new Point(40, 180);
            this.lblBedCaption.Name = "lblBedCaption";
            this.lblBedCaption.Size = new Size(109, 32);
            this.lblBedCaption.TabIndex = 4;
            this.lblBedCaption.Text = "Bed No.:";

            this.lblBedValue.AutoSize = true;
            this.lblBedValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblBedValue.Location = new Point(160, 180);
            this.lblBedValue.Name = "lblBedValue";
            this.lblBedValue.Size = new Size(0, 32);
            this.lblBedValue.TabIndex = 5;

            // Doctor
            this.lblDoctorCaption.AutoSize = true;
            this.lblDoctorCaption.Font = new Font("Segoe UI", 12F);
            this.lblDoctorCaption.Location = new Point(40, 230);
            this.lblDoctorCaption.Name = "lblDoctorCaption";
            this.lblDoctorCaption.Size = new Size(86, 32);
            this.lblDoctorCaption.TabIndex = 6;
            this.lblDoctorCaption.Text = "Doctor:";

            this.lblDoctorValue.AutoSize = true;
            this.lblDoctorValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblDoctorValue.Location = new Point(140, 230);
            this.lblDoctorValue.Name = "lblDoctorValue";
            this.lblDoctorValue.Size = new Size(0, 32);
            this.lblDoctorValue.TabIndex = 7;

            // Meeting Time
            this.lblMeetingCaption.AutoSize = true;
            this.lblMeetingCaption.Font = new Font("Segoe UI", 12F);
            this.lblMeetingCaption.Location = new Point(40, 280);
            this.lblMeetingCaption.Name = "lblMeetingCaption";
            this.lblMeetingCaption.Size = new Size(150, 32);
            this.lblMeetingCaption.TabIndex = 8;
            this.lblMeetingCaption.Text = "Meeting Time:";

            this.lblMeetingValue.AutoSize = true;
            this.lblMeetingValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblMeetingValue.Location = new Point(200, 280);
            this.lblMeetingValue.Name = "lblMeetingValue";
            this.lblMeetingValue.Size = new Size(0, 32);
            this.lblMeetingValue.TabIndex = 9;

            // Bill Total
            this.lblBillCaption.AutoSize = true;
            this.lblBillCaption.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblBillCaption.Location = new Point(40, 350);
            this.lblBillCaption.Name = "lblBillCaption";
            this.lblBillCaption.Size = new Size(191, 38);
            this.lblBillCaption.TabIndex = 10;
            this.lblBillCaption.Text = "Current Bill:";

            this.lblBillValue.AutoSize = true;
            this.lblBillValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblBillValue.ForeColor = Color.FromArgb(188, 100, 120);
            this.lblBillValue.Location = new Point(40, 400);
            this.lblBillValue.Name = "lblBillValue";
            this.lblBillValue.Size = new Size(0, 54);
            this.lblBillValue.TabIndex = 11;

            // PatientDashboard
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1844, 1151);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.Name = "PatientDashboard";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "The City Hospital - Patient Portal";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.ResumeLayout(false);
        }

        // Controls declarations
        private Panel pnlSidebar;
        private Label lblPatientPortal;
        private Button btnMyInfo;
        private Button btnMyBill;
        private Button btnLogout;
        private Panel pnlMain;
        private Panel pnlWelcome;
        private Label lblWelcomeTitle;
        private Label namelabl;
        private Label lblWardCaption;
        private Label lblWardValue;
        private Label lblBedCaption;
        private Label lblBedValue;
        private Label lblDoctorCaption;
        private Label lblDoctorValue;
        private Label lblMeetingCaption;
        private Label lblMeetingValue;
        private Label lblBillCaption;
        private Label lblBillValue;
    }
}