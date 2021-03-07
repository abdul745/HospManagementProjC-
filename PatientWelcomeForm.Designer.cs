namespace Abdullah_Aadrish_VP_Poject_HospitalMS
{
    partial class PatientWelcomeForm
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
            this.AppointmentsBtn = new System.Windows.Forms.Button();
            this.PatientsRegBtn = new System.Windows.Forms.Button();
            this.EmergencyBTN = new System.Windows.Forms.Button();
            this.GuestBtn = new System.Windows.Forms.Button();
            this.ViewDBBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppointmentsBtn
            // 
            this.AppointmentsBtn.Location = new System.Drawing.Point(146, 178);
            this.AppointmentsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AppointmentsBtn.Name = "AppointmentsBtn";
            this.AppointmentsBtn.Size = new System.Drawing.Size(105, 41);
            this.AppointmentsBtn.TabIndex = 0;
            this.AppointmentsBtn.Text = "Appointments";
            this.AppointmentsBtn.UseVisualStyleBackColor = true;
            this.AppointmentsBtn.Click += new System.EventHandler(this.AppointmentsBtn_Click);
            // 
            // PatientsRegBtn
            // 
            this.PatientsRegBtn.Location = new System.Drawing.Point(146, 115);
            this.PatientsRegBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PatientsRegBtn.Name = "PatientsRegBtn";
            this.PatientsRegBtn.Size = new System.Drawing.Size(105, 41);
            this.PatientsRegBtn.TabIndex = 1;
            this.PatientsRegBtn.Text = "Patients Registration";
            this.PatientsRegBtn.UseVisualStyleBackColor = true;
            this.PatientsRegBtn.Click += new System.EventHandler(this.PatientsRegBtn_Click);
            // 
            // EmergencyBTN
            // 
            this.EmergencyBTN.Location = new System.Drawing.Point(146, 237);
            this.EmergencyBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmergencyBTN.Name = "EmergencyBTN";
            this.EmergencyBTN.Size = new System.Drawing.Size(105, 41);
            this.EmergencyBTN.TabIndex = 2;
            this.EmergencyBTN.Text = "Emergency";
            this.EmergencyBTN.UseVisualStyleBackColor = true;
            this.EmergencyBTN.Click += new System.EventHandler(this.EmergencyBTN_Click);
            // 
            // GuestBtn
            // 
            this.GuestBtn.Location = new System.Drawing.Point(146, 292);
            this.GuestBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GuestBtn.Name = "GuestBtn";
            this.GuestBtn.Size = new System.Drawing.Size(105, 41);
            this.GuestBtn.TabIndex = 3;
            this.GuestBtn.Text = "Guest Meeting";
            this.GuestBtn.UseVisualStyleBackColor = true;
            this.GuestBtn.Click += new System.EventHandler(this.GuestBtn_Click);
            // 
            // ViewDBBtn
            // 
            this.ViewDBBtn.Location = new System.Drawing.Point(146, 351);
            this.ViewDBBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewDBBtn.Name = "ViewDBBtn";
            this.ViewDBBtn.Size = new System.Drawing.Size(105, 41);
            this.ViewDBBtn.TabIndex = 4;
            this.ViewDBBtn.Text = "View Database";
            this.ViewDBBtn.UseVisualStyleBackColor = true;
            this.ViewDBBtn.Click += new System.EventHandler(this.ViewDBBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.label1.Location = new System.Drawing.Point(79, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "City Hospital Portal";
            // 
            // PatientWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewDBBtn);
            this.Controls.Add(this.GuestBtn);
            this.Controls.Add(this.EmergencyBTN);
            this.Controls.Add(this.PatientsRegBtn);
            this.Controls.Add(this.AppointmentsBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PatientWelcomeForm";
            this.Text = "PatientWelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AppointmentsBtn;
        private System.Windows.Forms.Button PatientsRegBtn;
        private System.Windows.Forms.Button EmergencyBTN;
        private System.Windows.Forms.Button GuestBtn;
        private System.Windows.Forms.Button ViewDBBtn;
        private System.Windows.Forms.Label label1;
    }
}