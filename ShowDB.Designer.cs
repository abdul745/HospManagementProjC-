namespace Abdullah_Aadrish_VP_Poject_HospitalMS
{
    partial class ShowDB
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
            this.BTNRegistrations = new System.Windows.Forms.Button();
            this.BtnAppointments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNRegistrations
            // 
            this.BTNRegistrations.Location = new System.Drawing.Point(44, 139);
            this.BTNRegistrations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNRegistrations.Name = "BTNRegistrations";
            this.BTNRegistrations.Size = new System.Drawing.Size(101, 57);
            this.BTNRegistrations.TabIndex = 0;
            this.BTNRegistrations.Text = "All Registrations";
            this.BTNRegistrations.UseVisualStyleBackColor = true;
            this.BTNRegistrations.Click += new System.EventHandler(this.BTNRegistrations_Click);
            // 
            // BtnAppointments
            // 
            this.BtnAppointments.Location = new System.Drawing.Point(186, 138);
            this.BtnAppointments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAppointments.Name = "BtnAppointments";
            this.BtnAppointments.Size = new System.Drawing.Size(101, 57);
            this.BtnAppointments.TabIndex = 1;
            this.BtnAppointments.Text = "All Appointments";
            this.BtnAppointments.UseVisualStyleBackColor = true;
            this.BtnAppointments.Click += new System.EventHandler(this.BtnAppointments_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.label1.Location = new System.Drawing.Point(67, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check Databases";
            // 
            // ShowDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAppointments);
            this.Controls.Add(this.BTNRegistrations);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShowDB";
            this.Text = "ShowDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNRegistrations;
        private System.Windows.Forms.Button BtnAppointments;
        private System.Windows.Forms.Label label1;
    }
}