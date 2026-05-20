namespace Hospital_Management.Forms
{
    partial class BillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            lblTitle = new Label();
            btnRefresh = new Button();
            dgvBilling = new DataGridView();
            pnlHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBilling).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(40, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(159, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Billing";
            lblTitle.Click += label1_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 168, 145);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 110, 95);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 150, 130);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(40, 1100);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(160, 46);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "⟳  Refresh Bills";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvBilling
            // 
            dgvBilling.AllowUserToAddRows = false;
            dgvBilling.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 240, 252);
            dgvBilling.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBilling.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBilling.BackgroundColor = Color.White;
            dgvBilling.BorderStyle = BorderStyle.None;
            dgvBilling.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBilling.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(12, 28, 55);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBilling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBilling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(22, 32, 52);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 145, 130);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBilling.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBilling.EnableHeadersVisualStyles = false;
            dgvBilling.GridColor = Color.FromArgb(205, 220, 238);
            dgvBilling.Location = new Point(40, 110);
            dgvBilling.Name = "dgvBilling";
            dgvBilling.ReadOnly = true;
            dgvBilling.RowHeadersVisible = false;
            dgvBilling.RowHeadersWidth = 62;
            dgvBilling.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBilling.Size = new Size(1469, 970);
            dgvBilling.TabIndex = 1;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(12, 28, 55);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1549, 80);
            pnlHeader.TabIndex = 0;
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 240, 250);
            ClientSize = new Size(1549, 1169);
            Controls.Add(pnlHeader);
            Controls.Add(btnRefresh);
            Controls.Add(dgvBilling);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BillingForm";
            Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)dgvBilling).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnRefresh;
        private DataGridView dgvBilling;
        private Panel pnlHeader;
    }
}