namespace Hospital_Management.Forms
{
    partial class PatientBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientBillForm));
            label1 = new Label();
            lblGrandTotal = new Label();
            lblMedCharge = new Label();
            lblStayCharge = new Label();
            lblPerNight = new Label();
            lblNights = new Label();
            lblAdmitDate = new Label();
            lblWard = new Label();
            lblPatientName = new Label();
            pnlCard = new Panel();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(55, 90, 65);
            label1.Location = new Point(80, 50);
            label1.Name = "label1";
            label1.Size = new Size(200, 70);
            label1.TabIndex = 0;
            label1.Text = "My Bill";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTotal.ForeColor = Color.FromArgb(188, 100, 120);
            lblGrandTotal.Location = new Point(760, 460);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(252, 54);
            lblGrandTotal.TabIndex = 1;
            lblGrandTotal.Text = "Grand Total:";
            // 
            // lblMedCharge
            // 
            lblMedCharge.AutoSize = true;
            lblMedCharge.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMedCharge.ForeColor = Color.FromArgb(65, 95, 70);
            lblMedCharge.Location = new Point(760, 340);
            lblMedCharge.Name = "lblMedCharge";
            lblMedCharge.Size = new Size(233, 38);
            lblMedCharge.TabIndex = 2;
            lblMedCharge.Text = "Medicine Charge:";
            // 
            // lblStayCharge
            // 
            lblStayCharge.AutoSize = true;
            lblStayCharge.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStayCharge.ForeColor = Color.FromArgb(65, 95, 70);
            lblStayCharge.Location = new Point(760, 250);
            lblStayCharge.Name = "lblStayCharge";
            lblStayCharge.Size = new Size(236, 38);
            lblStayCharge.TabIndex = 3;
            lblStayCharge.Text = "Total Stay Charge:";
            // 
            // lblPerNight
            // 
            lblPerNight.AutoSize = true;
            lblPerNight.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPerNight.ForeColor = Color.FromArgb(65, 95, 70);
            lblPerNight.Location = new Point(760, 160);
            lblPerNight.Name = "lblPerNight";
            lblPerNight.Size = new Size(236, 38);
            lblPerNight.TabIndex = 4;
            lblPerNight.Text = "Per Night Charge:";
            // 
            // lblNights
            // 
            lblNights.AutoSize = true;
            lblNights.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNights.ForeColor = Color.FromArgb(65, 95, 70);
            lblNights.Location = new Point(760, 70);
            lblNights.Name = "lblNights";
            lblNights.Size = new Size(194, 38);
            lblNights.TabIndex = 5;
            lblNights.Text = "Nights Stayed:";
            // 
            // lblAdmitDate
            // 
            lblAdmitDate.AutoSize = true;
            lblAdmitDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmitDate.ForeColor = Color.FromArgb(65, 95, 70);
            lblAdmitDate.Location = new Point(60, 250);
            lblAdmitDate.Name = "lblAdmitDate";
            lblAdmitDate.Size = new Size(163, 38);
            lblAdmitDate.TabIndex = 6;
            lblAdmitDate.Text = "Admit Date:";
            // 
            // lblWard
            // 
            lblWard.AutoSize = true;
            lblWard.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWard.ForeColor = Color.FromArgb(65, 95, 70);
            lblWard.Location = new Point(60, 160);
            lblWard.Name = "lblWard";
            lblWard.Size = new Size(88, 38);
            lblWard.TabIndex = 7;
            lblWard.Text = "Ward:";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientName.ForeColor = Color.FromArgb(65, 95, 70);
            lblPatientName.Location = new Point(60, 70);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(108, 38);
            lblPatientName.TabIndex = 8;
            lblPatientName.Text = "Patient:";
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(254, 251, 248);
            pnlCard.Controls.Add(lblPatientName);
            pnlCard.Controls.Add(lblWard);
            pnlCard.Controls.Add(lblAdmitDate);
            pnlCard.Controls.Add(lblNights);
            pnlCard.Controls.Add(lblPerNight);
            pnlCard.Controls.Add(lblStayCharge);
            pnlCard.Controls.Add(lblMedCharge);
            pnlCard.Controls.Add(lblGrandTotal);
            pnlCard.Location = new Point(80, 130);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(1384, 940);
            pnlCard.TabIndex = 9;
            // 
            // PatientBillForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 240);
            ClientSize = new Size(1544, 1151);
            Controls.Add(pnlCard);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PatientBillForm";
            StartPosition = FormStartPosition.Manual;
            Text = "The City Hospital  -  My Bill";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblGrandTotal;
        private Label lblMedCharge;
        private Label lblStayCharge;
        private Label lblPerNight;
        private Label lblNights;
        private Label lblAdmitDate;
        private Label lblWard;
        private Label lblPatientName;
        private Panel pnlCard;
    }
}