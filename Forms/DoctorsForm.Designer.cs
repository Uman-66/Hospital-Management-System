namespace Hospital_Management.Forms
{
    partial class DoctorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsForm));
            lblTitle = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAddDoctor = new Button();
            dgvDoctors = new DataGridView();
            pnlLeft = new Panel();
            pnlTopBar = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            pnlLeft.SuspendLayout();
            pnlTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(12, 28, 55);
            lblTitle.Location = new Point(24, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(210, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Doctors";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.ForeColor = Color.FromArgb(22, 32, 52);
            txtSearch.Location = new Point(24, 40);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name...";
            txtSearch.Size = new Size(210, 34);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 145, 130);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(0, 145, 130);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 95, 85);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 120, 108);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(24, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(210, 42);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddDoctor
            // 
            btnAddDoctor.BackColor = Color.FromArgb(12, 28, 55);
            btnAddDoctor.Cursor = Cursors.Hand;
            btnAddDoctor.FlatAppearance.BorderColor = Color.FromArgb(12, 28, 55);
            btnAddDoctor.FlatAppearance.BorderSize = 0;
            btnAddDoctor.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 18, 40);
            btnAddDoctor.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 55, 100);
            btnAddDoctor.FlatStyle = FlatStyle.Flat;
            btnAddDoctor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddDoctor.ForeColor = Color.White;
            btnAddDoctor.Location = new Point(24, 164);
            btnAddDoctor.Name = "btnAddDoctor";
            btnAddDoctor.Size = new Size(210, 42);
            btnAddDoctor.TabIndex = 3;
            btnAddDoctor.Text = "Add New Doctor";
            btnAddDoctor.UseVisualStyleBackColor = false;
            btnAddDoctor.Click += btnAddDoctor_Click;
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(22, 32, 52);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 145, 130);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDoctors.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDoctors.EnableHeadersVisualStyles = false;
            dgvDoctors.GridColor = Color.FromArgb(205, 220, 238);
            dgvDoctors.Location = new Point(254, 80);
            dgvDoctors.MultiSelect = false;
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.RowHeadersVisible = false;
            dgvDoctors.RowHeadersWidth = 62;
            dgvDoctors.RowTemplate.Height = 40;
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.Size = new Size(1276, 1070);
            dgvDoctors.TabIndex = 4;
            dgvDoctors.CellDoubleClick += dgvDoctors_CellDoubleClick;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(20, 40, 72);
            pnlLeft.Controls.Add(txtSearch);
            pnlLeft.Controls.Add(btnSearch);
            pnlLeft.Controls.Add(btnAddDoctor);
            pnlLeft.Location = new Point(0, 80);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(260, 1089);
            pnlLeft.TabIndex = 9;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(lblTitle);
            pnlTopBar.Location = new Point(0, -1);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1522, 90);
            pnlTopBar.TabIndex = 10;
            // 
            // DoctorsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 240, 250);
            ClientSize = new Size(1549, 1169);
            Controls.Add(dgvDoctors);
            Controls.Add(pnlLeft);
            Controls.Add(pnlTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoctorsForm";
            Text = "Doctors";
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAddDoctor;
        private DataGridView dgvDoctors;
        private Panel pnlLeft;
        private Panel pnlTopBar;
    }
}