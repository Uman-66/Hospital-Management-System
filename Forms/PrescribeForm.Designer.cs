namespace Hospital_Management.Forms
{
    partial class PrescribeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescribeForm));
            pnlHeader = new Panel();
            label1 = new Label();
            pnlForm = new Panel();
            lblPatient = new Label();
            cmbPatient = new ComboBox();
            lblMedicine = new Label();
            cmbMedicine = new ComboBox();
            btnSave = new Button();
            label4 = new Label();
            label5 = new Label();
            pnlGrid = new Panel();
            lblGridTitle = new Label();
            dgvPrescriptions = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(18, 32, 100);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1569, 80);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(419, 60);
            label1.TabIndex = 0;
            label1.Text = "Prescribe Medicine";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(lblPatient);
            pnlForm.Controls.Add(cmbPatient);
            pnlForm.Controls.Add(lblMedicine);
            pnlForm.Controls.Add(cmbMedicine);
            pnlForm.Controls.Add(btnSave);
            pnlForm.Controls.Add(label4);
            pnlForm.Controls.Add(label5);
            pnlForm.Location = new Point(40, 120);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(1327, 380);
            pnlForm.TabIndex = 1;
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Font = new Font("Segoe UI", 9F);
            lblPatient.ForeColor = Color.FromArgb(100, 110, 150);
            lblPatient.Location = new Point(40, 60);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(138, 25);
            lblPatient.TabIndex = 1;
            lblPatient.Text = "SELECT PATIENT";
            // 
            // cmbPatient
            // 
            cmbPatient.BackColor = SystemColors.MenuHighlight;
            cmbPatient.FlatStyle = FlatStyle.Flat;
            cmbPatient.Font = new Font("Segoe UI", 11F);
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new Point(40, 88);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(1186, 38);
            cmbPatient.TabIndex = 2;
            cmbPatient.SelectedIndexChanged += cmbPatient_SelectedIndexChanged;
            // 
            // lblMedicine
            // 
            lblMedicine.AutoSize = true;
            lblMedicine.Font = new Font("Segoe UI", 9F);
            lblMedicine.ForeColor = Color.FromArgb(100, 110, 150);
            lblMedicine.Location = new Point(40, 170);
            lblMedicine.Name = "lblMedicine";
            lblMedicine.Size = new Size(154, 25);
            lblMedicine.TabIndex = 3;
            lblMedicine.Text = "SELECT MEDICINE";
            // 
            // cmbMedicine
            // 
            cmbMedicine.BackColor = SystemColors.MenuHighlight;
            cmbMedicine.FlatStyle = FlatStyle.Flat;
            cmbMedicine.Font = new Font("Segoe UI", 11F);
            cmbMedicine.FormattingEnabled = true;
            cmbMedicine.Location = new Point(40, 198);
            cmbMedicine.Name = "cmbMedicine";
            cmbMedicine.Size = new Size(1186, 38);
            cmbMedicine.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(18, 32, 100);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 32, 100);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 32, 100);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(40, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 50);
            btnSave.TabIndex = 5;
            btnSave.Text = "✓  Prescribe";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 20;
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 21;
            label5.Visible = false;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(lblGridTitle);
            pnlGrid.Controls.Add(dgvPrescriptions);
            pnlGrid.Location = new Point(40, 540);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(1489, 590);
            pnlGrid.TabIndex = 2;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(18, 32, 100);
            lblGridTitle.Location = new Point(28, 24);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(256, 36);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Prescription History";
            // 
            // dgvPrescriptions
            // 
            dgvPrescriptions.AllowUserToAddRows = false;
            dgvPrescriptions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 239, 255);
            dgvPrescriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptions.BackgroundColor = Color.White;
            dgvPrescriptions.BorderStyle = BorderStyle.None;
            dgvPrescriptions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPrescriptions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 32, 100);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPrescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(22, 32, 60);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(18, 32, 100);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPrescriptions.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPrescriptions.EnableHeadersVisualStyles = false;
            dgvPrescriptions.GridColor = Color.FromArgb(210, 218, 240);
            dgvPrescriptions.Location = new Point(28, 64);
            dgvPrescriptions.Name = "dgvPrescriptions";
            dgvPrescriptions.ReadOnly = true;
            dgvPrescriptions.RowHeadersVisible = false;
            dgvPrescriptions.RowHeadersWidth = 62;
            dgvPrescriptions.Size = new Size(1433, 502);
            dgvPrescriptions.TabIndex = 1;
            // 
            // PrescribeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 255);
            ClientSize = new Size(1569, 1170);
            Controls.Add(pnlHeader);
            Controls.Add(pnlForm);
            Controls.Add(pnlGrid);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PrescribeForm";
            Text = "Prescribe Medicine";
            Load += PrescribeForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlGrid.ResumeLayout(false);
            pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Panel pnlForm;
        private Label lblPatient;
        private Label label5;
        private ComboBox cmbPatient;
        private Label lblMedicine;
        private Label label4;
        private ComboBox cmbMedicine;
        private Button btnSave;
        private Panel pnlGrid;
        private Label lblGridTitle;
        private DataGridView dgvPrescriptions;
    }
}