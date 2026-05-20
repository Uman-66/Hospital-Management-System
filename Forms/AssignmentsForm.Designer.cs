namespace Hospital_Management.Forms
{
    partial class AssignmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentsForm));
            lblTitle = new Label();
            btnAdd = new Button();
            dgvAssignments = new DataGridView();
            pnlTopBar = new Panel();
            pnlLeft = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).BeginInit();
            pnlTopBar.SuspendLayout();
            pnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(12, 28, 55);
            lblTitle.Location = new Point(24, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 59);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Assignments";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 145, 130);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(0, 145, 130);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 95, 85);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 120, 108);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(24, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(210, 42);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "New Assignment";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvAssignments
            // 
            dgvAssignments.AllowUserToAddRows = false;
            dgvAssignments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 240, 252);
            dgvAssignments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAssignments.BackgroundColor = Color.White;
            dgvAssignments.BorderStyle = BorderStyle.None;
            dgvAssignments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAssignments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(12, 28, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAssignments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(22, 32, 52);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 145, 130);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAssignments.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAssignments.EnableHeadersVisualStyles = false;
            dgvAssignments.GridColor = Color.FromArgb(205, 220, 238);
            dgvAssignments.Location = new Point(275, 95);
            dgvAssignments.MultiSelect = false;
            dgvAssignments.Name = "dgvAssignments";
            dgvAssignments.ReadOnly = true;
            dgvAssignments.RowHeadersVisible = false;
            dgvAssignments.RowHeadersWidth = 62;
            dgvAssignments.RowTemplate.Height = 40;
            dgvAssignments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignments.Size = new Size(1255, 1055);
            dgvAssignments.TabIndex = 2;
            dgvAssignments.CellDoubleClick += dgvAssignments_CellDoubleClick;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(lblTitle);
            pnlTopBar.Location = new Point(0, 1);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1549, 79);
            pnlTopBar.TabIndex = 10;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(20, 40, 72);
            pnlLeft.Controls.Add(btnAdd);
            pnlLeft.Location = new Point(0, 80);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(260, 1089);
            pnlLeft.TabIndex = 9;
            // 
            // AssignmentsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 240, 250);
            ClientSize = new Size(1549, 1169);
            Controls.Add(dgvAssignments);
            Controls.Add(pnlLeft);
            Controls.Add(pnlTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AssignmentsForm";
            Text = "Assignments";
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).EndInit();
            pnlTopBar.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnAdd;
        private DataGridView dgvAssignments;
        private Panel pnlTopBar;
        private Panel pnlLeft;
    }
}