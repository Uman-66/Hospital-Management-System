namespace Hospital_Management.Forms
{
    partial class PatientDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDashboard));
            pnlSidebar = new Panel();
            lblPatientPortal = new Label();
            btnMyInfo = new Button();
            btnMyBill = new Button();
            btnLogout = new Button();
            pnlMain = new Panel();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(44, 31, 22);
            pnlSidebar.Controls.Add(lblPatientPortal);
            pnlSidebar.Controls.Add(btnMyInfo);
            pnlSidebar.Controls.Add(btnMyBill);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(300, 1151);
            pnlSidebar.TabIndex = 0;
            // 
            // lblPatientPortal
            // 
            lblPatientPortal.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientPortal.ForeColor = Color.FromArgb(230, 195, 160);
            lblPatientPortal.Location = new Point(0, 55);
            lblPatientPortal.Name = "lblPatientPortal";
            lblPatientPortal.Size = new Size(300, 40);
            lblPatientPortal.TabIndex = 10;
            lblPatientPortal.Text = "Patient Portal";
            lblPatientPortal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMyInfo
            // 
            btnMyInfo.BackColor = Color.FromArgb(185, 120, 55);
            btnMyInfo.Cursor = Cursors.Hand;
            btnMyInfo.FlatAppearance.BorderColor = Color.FromArgb(185, 120, 55);
            btnMyInfo.FlatAppearance.BorderSize = 0;
            btnMyInfo.FlatAppearance.MouseDownBackColor = Color.FromArgb(135, 82, 30);
            btnMyInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(165, 105, 45);
            btnMyInfo.FlatStyle = FlatStyle.Flat;
            btnMyInfo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnMyInfo.ForeColor = Color.White;
            btnMyInfo.Location = new Point(62, 150);
            btnMyInfo.Name = "btnMyInfo";
            btnMyInfo.Size = new Size(175, 42);
            btnMyInfo.TabIndex = 0;
            btnMyInfo.Text = "  My Info";
            btnMyInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnMyInfo.UseVisualStyleBackColor = false;
            btnMyInfo.Click += btnMyInfo_Click;
            // 
            // btnMyBill
            // 
            btnMyBill.BackColor = Color.FromArgb(44, 31, 22);
            btnMyBill.Cursor = Cursors.Hand;
            btnMyBill.FlatAppearance.BorderColor = Color.FromArgb(44, 31, 22);
            btnMyBill.FlatAppearance.BorderSize = 0;
            btnMyBill.FlatAppearance.MouseDownBackColor = Color.FromArgb(55, 38, 25);
            btnMyBill.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 50, 35);
            btnMyBill.FlatStyle = FlatStyle.Flat;
            btnMyBill.Font = new Font("Segoe UI", 10F);
            btnMyBill.ForeColor = Color.FromArgb(210, 180, 150);
            btnMyBill.Location = new Point(62, 224);
            btnMyBill.Name = "btnMyBill";
            btnMyBill.Size = new Size(175, 42);
            btnMyBill.TabIndex = 3;
            btnMyBill.Text = "  My Bill";
            btnMyBill.TextAlign = ContentAlignment.MiddleLeft;
            btnMyBill.UseVisualStyleBackColor = false;
            btnMyBill.Click += btnMyBill_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(175, 65, 50);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(175, 65, 50);
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 35, 25);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(148, 50, 38);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(11, 870);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(175, 42);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(248, 243, 235);
            pnlMain.Dock = DockStyle.Right;
            pnlMain.Location = new Point(300, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1544, 1151);
            pnlMain.TabIndex = 1;
            // 
            // PatientDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 243, 235);
            ClientSize = new Size(1844, 1151);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PatientDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The City Hospital  -  Patient Portal";
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnMyBill;
        private Button btnMyPrescriptions;
        private Button btnLogout;
        private Button btnMyInfo;
        private Panel pnlMain;
        private Label lblPatientPortal;
    }
}