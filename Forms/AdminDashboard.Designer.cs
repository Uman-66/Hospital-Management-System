namespace Hospital_Management.Forms
{
    partial class AdminDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            btnPatients = new Button();
            btnDoctors = new Button();
            btnAssignments = new Button();
            btnBilling = new Button();
            btnLogout = new Button();
            pnlSidebar = new Panel();
            btnHome = new Button();
            pnlMain = new Panel();
            pnlHome = new Panel();
            label2 = new Label();
            label1 = new Label();
            dgvDoctors = new DataGridView();
            dgvWards = new DataGridView();
            lblTotalMedicines = new Label();
            lblTotalPatients = new Label();
            lblTotalWards = new Label();
            lblTotalDoctors = new Label();
            lblHospitalName = new Label();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWards).BeginInit();
            SuspendLayout();
            // 
            // btnPatients
            // 
            btnPatients.BackColor = Color.FromArgb(12, 28, 55);
            btnPatients.Cursor = Cursors.Hand;
            btnPatients.FlatAppearance.BorderColor = Color.FromArgb(12, 28, 55);
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 38, 72);
            btnPatients.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 55, 100);
            btnPatients.FlatStyle = FlatStyle.Flat;
            btnPatients.Font = new Font("Segoe UI", 10F);
            btnPatients.ForeColor = Color.FromArgb(180, 210, 245);
            btnPatients.Location = new Point(68, 293);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(175, 42);
            btnPatients.TabIndex = 0;
            btnPatients.Text = "  Patients";
            btnPatients.TextAlign = ContentAlignment.MiddleLeft;
            btnPatients.UseVisualStyleBackColor = false;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = Color.FromArgb(12, 28, 55);
            btnDoctors.Cursor = Cursors.Hand;
            btnDoctors.FlatAppearance.BorderColor = Color.FromArgb(12, 28, 55);
            btnDoctors.FlatAppearance.BorderSize = 0;
            btnDoctors.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 38, 72);
            btnDoctors.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 55, 100);
            btnDoctors.FlatStyle = FlatStyle.Flat;
            btnDoctors.Font = new Font("Segoe UI", 10F);
            btnDoctors.ForeColor = Color.FromArgb(180, 210, 245);
            btnDoctors.Location = new Point(68, 219);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(175, 42);
            btnDoctors.TabIndex = 1;
            btnDoctors.Text = "  Doctors";
            btnDoctors.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // btnAssignments
            // 
            btnAssignments.BackColor = Color.FromArgb(12, 28, 55);
            btnAssignments.Cursor = Cursors.Hand;
            btnAssignments.FlatAppearance.BorderColor = Color.FromArgb(12, 28, 55);
            btnAssignments.FlatAppearance.BorderSize = 0;
            btnAssignments.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 38, 72);
            btnAssignments.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 55, 100);
            btnAssignments.FlatStyle = FlatStyle.Flat;
            btnAssignments.Font = new Font("Segoe UI", 10F);
            btnAssignments.ForeColor = Color.FromArgb(180, 210, 245);
            btnAssignments.Location = new Point(68, 362);
            btnAssignments.Name = "btnAssignments";
            btnAssignments.Size = new Size(175, 42);
            btnAssignments.TabIndex = 2;
            btnAssignments.Text = "  Assignments";
            btnAssignments.TextAlign = ContentAlignment.MiddleLeft;
            btnAssignments.UseVisualStyleBackColor = false;
            btnAssignments.Click += btnAssignments_Click_1;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.FromArgb(12, 28, 55);
            btnBilling.Cursor = Cursors.Hand;
            btnBilling.FlatAppearance.BorderColor = Color.FromArgb(12, 28, 55);
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatAppearance.MouseDownBackColor = Color.FromArgb(10, 38, 72);
            btnBilling.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 55, 100);
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Segoe UI", 10F);
            btnBilling.ForeColor = Color.FromArgb(180, 210, 245);
            btnBilling.Location = new Point(68, 446);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(175, 42);
            btnBilling.TabIndex = 3;
            btnBilling.Text = "  Billing";
            btnBilling.TextAlign = ContentAlignment.MiddleLeft;
            btnBilling.UseVisualStyleBackColor = false;
            btnBilling.Click += btnBilling_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(185, 45, 45);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(185, 45, 45);
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 18, 18);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(155, 35, 35);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(11, 870);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(175, 42);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(12, 28, 55);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnBilling);
            pnlSidebar.Controls.Add(btnAssignments);
            pnlSidebar.Controls.Add(btnDoctors);
            pnlSidebar.Controls.Add(btnPatients);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(310, 1169);
            pnlSidebar.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(0, 168, 145);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0, 168, 145);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 110, 95);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 150, 130);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(68, 135);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(175, 42);
            btnHome.TabIndex = 5;
            btnHome.Text = "  Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(232, 240, 250);
            pnlMain.Controls.Add(pnlHome);
            pnlMain.Location = new Point(309, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1549, 1169);
            pnlMain.TabIndex = 2;
            // 
            // pnlHome
            // 
            pnlHome.BackColor = Color.FromArgb(232, 240, 250);
            pnlHome.Controls.Add(label2);
            pnlHome.Controls.Add(label1);
            pnlHome.Controls.Add(dgvDoctors);
            pnlHome.Controls.Add(dgvWards);
            pnlHome.Controls.Add(lblTotalMedicines);
            pnlHome.Controls.Add(lblTotalPatients);
            pnlHome.Controls.Add(lblTotalWards);
            pnlHome.Controls.Add(lblTotalDoctors);
            pnlHome.Controls.Add(lblHospitalName);
            pnlHome.Location = new Point(3, 0);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(1546, 1166);
            pnlHome.TabIndex = 0;
            pnlHome.Paint += pnlHome_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(12, 28, 55);
            label2.Location = new Point(814, 703);
            label2.Name = "label2";
            label2.Size = new Size(149, 48);
            label2.TabIndex = 8;
            label2.Text = "Doctors";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 28, 55);
            label1.Location = new Point(-3, 706);
            label1.Name = "label1";
            label1.Size = new Size(176, 48);
            label1.TabIndex = 7;
            label1.Text = "All Wards";
            // 
            // dgvDoctors
            // 
            dgvDoctors.AllowUserToAddRows = false;
            dgvDoctors.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 240, 252);
            dgvDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctors.BackgroundColor = Color.White;
            dgvDoctors.BorderStyle = BorderStyle.None;
            dgvDoctors.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDoctors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(12, 28, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(22, 32, 52);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 145, 130);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDoctors.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDoctors.EnableHeadersVisualStyles = false;
            dgvDoctors.GridColor = Color.FromArgb(205, 220, 238);
            dgvDoctors.Location = new Point(814, 776);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.RowHeadersVisible = false;
            dgvDoctors.RowHeadersWidth = 62;
            dgvDoctors.Size = new Size(732, 387);
            dgvDoctors.TabIndex = 6;
            // 
            // dgvWards
            // 
            dgvWards.AllowUserToAddRows = false;
            dgvWards.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(230, 240, 252);
            dgvWards.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvWards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWards.BackgroundColor = Color.White;
            dgvWards.BorderStyle = BorderStyle.None;
            dgvWards.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvWards.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(12, 28, 55);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvWards.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvWards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(22, 32, 52);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 145, 130);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvWards.DefaultCellStyle = dataGridViewCellStyle6;
            dgvWards.EnableHeadersVisualStyles = false;
            dgvWards.GridColor = Color.FromArgb(205, 220, 238);
            dgvWards.Location = new Point(0, 779);
            dgvWards.Name = "dgvWards";
            dgvWards.ReadOnly = true;
            dgvWards.RowHeadersVisible = false;
            dgvWards.RowHeadersWidth = 62;
            dgvWards.Size = new Size(732, 387);
            dgvWards.TabIndex = 5;
            // 
            // lblTotalMedicines
            // 
            lblTotalMedicines.AutoSize = true;
            lblTotalMedicines.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalMedicines.ForeColor = Color.FromArgb(190, 100, 10);
            lblTotalMedicines.Location = new Point(814, 447);
            lblTotalMedicines.Name = "lblTotalMedicines";
            lblTotalMedicines.Size = new Size(70, 81);
            lblTotalMedicines.TabIndex = 4;
            lblTotalMedicines.Text = "0";
            // 
            // lblTotalPatients
            // 
            lblTotalPatients.AutoSize = true;
            lblTotalPatients.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPatients.ForeColor = Color.FromArgb(0, 100, 175);
            lblTotalPatients.Location = new Point(97, 269);
            lblTotalPatients.Name = "lblTotalPatients";
            lblTotalPatients.Size = new Size(70, 81);
            lblTotalPatients.TabIndex = 3;
            lblTotalPatients.Text = "0";
            // 
            // lblTotalWards
            // 
            lblTotalWards.AutoSize = true;
            lblTotalWards.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalWards.ForeColor = Color.FromArgb(130, 60, 165);
            lblTotalWards.Location = new Point(97, 452);
            lblTotalWards.Name = "lblTotalWards";
            lblTotalWards.Size = new Size(70, 81);
            lblTotalWards.TabIndex = 2;
            lblTotalWards.Text = "0";
            // 
            // lblTotalDoctors
            // 
            lblTotalDoctors.AutoSize = true;
            lblTotalDoctors.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDoctors.ForeColor = Color.FromArgb(0, 145, 130);
            lblTotalDoctors.Location = new Point(814, 247);
            lblTotalDoctors.Name = "lblTotalDoctors";
            lblTotalDoctors.Size = new Size(70, 81);
            lblTotalDoctors.TabIndex = 1;
            lblTotalDoctors.Text = "0";
            lblTotalDoctors.Click += lblTotalDoctors_Click;
            // 
            // lblHospitalName
            // 
            lblHospitalName.AutoSize = true;
            lblHospitalName.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblHospitalName.ForeColor = Color.FromArgb(12, 28, 55);
            lblHospitalName.Location = new Point(513, 39);
            lblHospitalName.Name = "lblHospitalName";
            lblHospitalName.Size = new Size(516, 81);
            lblHospitalName.TabIndex = 0;
            lblHospitalName.Text = "The City Hospital";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 240, 250);
            ClientSize = new Size(1857, 1169);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The City Hospital  -  Admin Panel";
            pnlSidebar.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlHome.ResumeLayout(false);
            pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWards).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPatients;
        private Button btnDoctors;
        private Button btnAssignments;
        private Button btnBilling;
        private Button btnLogout;
        private Panel pnlSidebar;
        private Button btnHome;
        private Panel pnlMain;
        private Panel pnlHome;
        private DataGridView dgvWards;
        private Label lblTotalMedicines;
        private Label lblTotalPatients;
        private Label lblTotalWards;
        private Label lblTotalDoctors;
        private Label lblHospitalName;
        private DataGridView dgvDoctors;
        private Label label2;
        private Label label1;
    }
}