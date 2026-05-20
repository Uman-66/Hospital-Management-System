namespace Hospital_Management.Forms
{
    partial class AddAssignmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAssignmentForm));
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            lblSectionAssign = new Label();
            label1 = new Label();
            cmbPatient = new ComboBox();
            label3 = new Label();
            cmbDoctor = new ComboBox();
            label2 = new Label();
            txtMeetingTime = new TextBox();
            pnlFooter = new Panel();
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
            lblSubtitle.Size = new Size(226, 38);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "New Assignment";
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
            // lblSectionAssign
            // 
            lblSectionAssign.Font = new Font("Segoe UI", 8F);
            lblSectionAssign.ForeColor = Color.FromArgb(24, 95, 165);
            lblSectionAssign.Location = new Point(34, 140);
            lblSectionAssign.Margin = new Padding(4, 0, 4, 0);
            lblSectionAssign.Name = "lblSectionAssign";
            lblSectionAssign.Size = new Size(187, 33);
            lblSectionAssign.TabIndex = 1;
            lblSectionAssign.Text = "ASSIGNMENT DETAILS";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.FromArgb(24, 95, 165);
            label1.Location = new Point(34, 180);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 2;
            label1.Text = "Patient";
            // 
            // cmbPatient
            // 
            cmbPatient.BackColor = Color.White;
            cmbPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatient.FlatStyle = FlatStyle.Flat;
            cmbPatient.Font = new Font("Segoe UI", 10F);
            cmbPatient.ForeColor = Color.FromArgb(20, 35, 60);
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new Point(34, 213);
            cmbPatient.Margin = new Padding(4, 5, 4, 5);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(730, 36);
            cmbPatient.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.FromArgb(24, 95, 165);
            label3.Location = new Point(34, 287);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 30);
            label3.TabIndex = 4;
            label3.Text = "Doctor";
            // 
            // cmbDoctor
            // 
            cmbDoctor.BackColor = Color.White;
            cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctor.FlatStyle = FlatStyle.Flat;
            cmbDoctor.Font = new Font("Segoe UI", 10F);
            cmbDoctor.ForeColor = Color.FromArgb(20, 35, 60);
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(34, 320);
            cmbDoctor.Margin = new Padding(4, 5, 4, 5);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(730, 36);
            cmbDoctor.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.FromArgb(24, 95, 165);
            label2.Location = new Point(34, 393);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 6;
            label2.Text = "Meeting Time";
            // 
            // txtMeetingTime
            // 
            txtMeetingTime.BackColor = Color.White;
            txtMeetingTime.BorderStyle = BorderStyle.FixedSingle;
            txtMeetingTime.Font = new Font("Segoe UI", 10F);
            txtMeetingTime.ForeColor = Color.FromArgb(20, 35, 60);
            txtMeetingTime.Location = new Point(34, 427);
            txtMeetingTime.Margin = new Padding(4, 5, 4, 5);
            txtMeetingTime.Name = "txtMeetingTime";
            txtMeetingTime.Size = new Size(731, 34);
            txtMeetingTime.TabIndex = 7;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(235, 243, 251);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 550);
            pnlFooter.Margin = new Padding(4, 5, 4, 5);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(800, 93);
            pnlFooter.TabIndex = 10;
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
            btnSave.Location = new Point(609, 18);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(171, 57);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save Assignment";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddAssignmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 243, 251);
            ClientSize = new Size(800, 643);
            Controls.Add(txtMeetingTime);
            Controls.Add(label2);
            Controls.Add(cmbDoctor);
            Controls.Add(label3);
            Controls.Add(cmbPatient);
            Controls.Add(label1);
            Controls.Add(lblSectionAssign);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddAssignmentForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Assignment";
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
        private Label lblSectionAssign;
        private Label label1;
        private ComboBox cmbPatient;
        private Label label3;
        private ComboBox cmbDoctor;
        private Label label2;
        private TextBox txtMeetingTime;
        private Panel pnlFooter;
        private Button btnSave;
    }
}