namespace Hospital_Management.Forms
{
    partial class EditPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPatientForm));
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            lblSectionPersonal = new Label();
            label1 = new Label();
            txtName = new TextBox();
            label6 = new Label();
            txtAge = new TextBox();
            txtAgea = new Label();
            cmbGender = new ComboBox();
            lblSectionWard = new Label();
            label4 = new Label();
            cmbWard = new ComboBox();
            label3 = new Label();
            txtBed = new TextBox();
            label2 = new Label();
            txtCharge = new TextBox();
            pnlFooter = new Panel();
            btnDischarge = new Button();
            btnSave = new Button();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(24, 95, 165);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 113);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 14F);
            lblSubtitle.ForeColor = Color.FromArgb(230, 241, 251);
            lblSubtitle.Location = new Point(26, 47);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(156, 38);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Edit Patient";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 8F);
            lblTitle.ForeColor = Color.FromArgb(181, 212, 244);
            lblTitle.Location = new Point(29, 17);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(252, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // lblSectionPersonal
            // 
            lblSectionPersonal.Font = new Font("Segoe UI", 8F);
            lblSectionPersonal.ForeColor = Color.FromArgb(24, 95, 165);
            lblSectionPersonal.Location = new Point(34, 140);
            lblSectionPersonal.Margin = new Padding(4, 0, 4, 0);
            lblSectionPersonal.Name = "lblSectionPersonal";
            lblSectionPersonal.Size = new Size(731, 33);
            lblSectionPersonal.TabIndex = 1;
            lblSectionPersonal.Text = "PERSONAL INFORMATION";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.FromArgb(24, 95, 165);
            label1.Location = new Point(34, 180);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(731, 30);
            label1.TabIndex = 2;
            label1.Text = "Full Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.ForeColor = Color.FromArgb(20, 35, 60);
            txtName.Location = new Point(34, 213);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(731, 34);
            txtName.TabIndex = 3;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F);
            label6.ForeColor = Color.FromArgb(24, 95, 165);
            label6.Location = new Point(34, 287);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(350, 30);
            label6.TabIndex = 4;
            label6.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.White;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 10F);
            txtAge.ForeColor = Color.FromArgb(20, 35, 60);
            txtAge.Location = new Point(34, 320);
            txtAge.Margin = new Padding(4, 5, 4, 5);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(349, 34);
            txtAge.TabIndex = 5;
            // 
            // txtAgea
            // 
            txtAgea.Font = new Font("Segoe UI", 9F);
            txtAgea.ForeColor = Color.FromArgb(24, 95, 165);
            txtAgea.Location = new Point(416, 287);
            txtAgea.Margin = new Padding(4, 0, 4, 0);
            txtAgea.Name = "txtAgea";
            txtAgea.Size = new Size(350, 30);
            txtAgea.TabIndex = 6;
            txtAgea.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.White;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.Flat;
            cmbGender.Font = new Font("Segoe UI", 10F);
            cmbGender.ForeColor = Color.FromArgb(20, 35, 60);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(416, 320);
            cmbGender.Margin = new Padding(4, 5, 4, 5);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(348, 36);
            cmbGender.TabIndex = 7;
            // 
            // lblSectionWard
            // 
            lblSectionWard.Font = new Font("Segoe UI", 8F);
            lblSectionWard.ForeColor = Color.FromArgb(24, 95, 165);
            lblSectionWard.Location = new Point(34, 400);
            lblSectionWard.Margin = new Padding(4, 0, 4, 0);
            lblSectionWard.Name = "lblSectionWard";
            lblSectionWard.Size = new Size(731, 33);
            lblSectionWard.TabIndex = 8;
            lblSectionWard.Text = "WARD & BILLING";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(24, 95, 165);
            label4.Location = new Point(34, 440);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(350, 30);
            label4.TabIndex = 9;
            label4.Text = "Ward";
            // 
            // cmbWard
            // 
            cmbWard.BackColor = Color.White;
            cmbWard.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWard.FlatStyle = FlatStyle.Flat;
            cmbWard.Font = new Font("Segoe UI", 10F);
            cmbWard.ForeColor = Color.FromArgb(20, 35, 60);
            cmbWard.FormattingEnabled = true;
            cmbWard.Location = new Point(34, 473);
            cmbWard.Margin = new Padding(4, 5, 4, 5);
            cmbWard.Name = "cmbWard";
            cmbWard.Size = new Size(348, 36);
            cmbWard.TabIndex = 10;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(24, 95, 165);
            label3.Location = new Point(416, 440);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(350, 30);
            label3.TabIndex = 11;
            label3.Text = "Bed Number";
            // 
            // txtBed
            // 
            txtBed.BackColor = Color.White;
            txtBed.BorderStyle = BorderStyle.FixedSingle;
            txtBed.Font = new Font("Segoe UI", 10F);
            txtBed.ForeColor = Color.FromArgb(20, 35, 60);
            txtBed.Location = new Point(416, 473);
            txtBed.Margin = new Padding(4, 5, 4, 5);
            txtBed.Name = "txtBed";
            txtBed.Size = new Size(349, 34);
            txtBed.TabIndex = 12;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(24, 95, 165);
            label2.Location = new Point(34, 547);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(731, 30);
            label2.TabIndex = 13;
            label2.Text = "Per Night Charge";
            // 
            // txtCharge
            // 
            txtCharge.BackColor = Color.White;
            txtCharge.BorderStyle = BorderStyle.FixedSingle;
            txtCharge.Font = new Font("Segoe UI", 10F);
            txtCharge.ForeColor = Color.FromArgb(20, 35, 60);
            txtCharge.Location = new Point(34, 580);
            txtCharge.Margin = new Padding(4, 5, 4, 5);
            txtCharge.Name = "txtCharge";
            txtCharge.Size = new Size(731, 34);
            txtCharge.TabIndex = 14;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(235, 243, 251);
            pnlFooter.Controls.Add(btnDischarge);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 660);
            pnlFooter.Margin = new Padding(4, 5, 4, 5);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(800, 93);
            pnlFooter.TabIndex = 20;
            // 
            // btnDischarge
            // 
            btnDischarge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDischarge.BackColor = Color.FromArgb(163, 45, 45);
            btnDischarge.Cursor = Cursors.Hand;
            btnDischarge.FlatAppearance.BorderSize = 0;
            btnDischarge.FlatStyle = FlatStyle.Flat;
            btnDischarge.Font = new Font("Segoe UI", 9.5F);
            btnDischarge.ForeColor = Color.FromArgb(252, 235, 235);
            btnDischarge.Location = new Point(623, 18);
            btnDischarge.Margin = new Padding(4, 5, 4, 5);
            btnDischarge.Name = "btnDischarge";
            btnDischarge.Size = new Size(157, 57);
            btnDischarge.TabIndex = 1;
            btnDischarge.Text = "Discharge";
            btnDischarge.UseVisualStyleBackColor = false;
            btnDischarge.Click += btnDischarge_Click_1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(24, 95, 165);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.5F);
            btnSave.ForeColor = Color.FromArgb(230, 241, 251);
            btnSave.Location = new Point(466, 18);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(157, 57);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // EditPatientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 251);
            ClientSize = new Size(800, 753);
            Controls.Add(txtCharge);
            Controls.Add(label2);
            Controls.Add(txtBed);
            Controls.Add(label3);
            Controls.Add(cmbWard);
            Controls.Add(label4);
            Controls.Add(lblSectionWard);
            Controls.Add(cmbGender);
            Controls.Add(txtAgea);
            Controls.Add(txtAge);
            Controls.Add(label6);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(lblSectionPersonal);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditPatientForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Patient";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblSectionPersonal;
        private Label label1;
        private TextBox txtName;
        private Label label6;
        private TextBox txtAge;
        private Label txtAgea;
        private ComboBox cmbGender;
        private Label lblSectionWard;
        private Label label4;
        private ComboBox cmbWard;
        private Label label3;
        private TextBox txtBed;
        private Label label2;
        private TextBox txtCharge;
        private Panel pnlFooter;
        private Button btnSave;
        private Button btnDischarge;
    }
}