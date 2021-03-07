namespace Abdullah_Aadrish_VP_Poject_HospitalMS
{
    partial class PatientsRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPatientName = new System.Windows.Forms.TextBox();
            this.TBPatientAge = new System.Windows.Forms.TextBox();
            this.TBPatientContact = new System.Windows.Forms.TextBox();
            this.TBPatientCNIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterPatientBTN = new System.Windows.Forms.Button();
            this.CBDisease = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(89, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Patient Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(85, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Patient Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(85, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Patient Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(85, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Patient CNIC";
            // 
            // TBPatientName
            // 
            this.TBPatientName.Location = new System.Drawing.Point(356, 112);
            this.TBPatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPatientName.Name = "TBPatientName";
            this.TBPatientName.Size = new System.Drawing.Size(145, 22);
            this.TBPatientName.TabIndex = 4;
            // 
            // TBPatientAge
            // 
            this.TBPatientAge.Location = new System.Drawing.Point(356, 159);
            this.TBPatientAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPatientAge.Name = "TBPatientAge";
            this.TBPatientAge.Size = new System.Drawing.Size(145, 22);
            this.TBPatientAge.TabIndex = 5;
            // 
            // TBPatientContact
            // 
            this.TBPatientContact.Location = new System.Drawing.Point(356, 204);
            this.TBPatientContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPatientContact.Name = "TBPatientContact";
            this.TBPatientContact.Size = new System.Drawing.Size(145, 22);
            this.TBPatientContact.TabIndex = 6;
            // 
            // TBPatientCNIC
            // 
            this.TBPatientCNIC.Location = new System.Drawing.Point(356, 256);
            this.TBPatientCNIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPatientCNIC.Name = "TBPatientCNIC";
            this.TBPatientCNIC.Size = new System.Drawing.Size(145, 22);
            this.TBPatientCNIC.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.label5.Location = new System.Drawing.Point(109, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = "Patient Registration";
            // 
            // RegisterPatientBTN
            // 
            this.RegisterPatientBTN.Location = new System.Drawing.Point(213, 358);
            this.RegisterPatientBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterPatientBTN.Name = "RegisterPatientBTN";
            this.RegisterPatientBTN.Size = new System.Drawing.Size(132, 49);
            this.RegisterPatientBTN.TabIndex = 9;
            this.RegisterPatientBTN.Text = "Register Patient";
            this.RegisterPatientBTN.UseVisualStyleBackColor = true;
            this.RegisterPatientBTN.Click += new System.EventHandler(this.RegisterPatientBTN_Click);
            // 
            // CBDisease
            // 
            this.CBDisease.FormattingEnabled = true;
            this.CBDisease.Items.AddRange(new object[] {
            "Cardio",
            "Sugar/Blood Pressure",
            "Kidney",
            "Gynecology",
            "Stomachache",
            "Allergy"});
            this.CBDisease.Location = new System.Drawing.Point(355, 304);
            this.CBDisease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBDisease.Name = "CBDisease";
            this.CBDisease.Size = new System.Drawing.Size(147, 24);
            this.CBDisease.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(85, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Select Disease";
            // 
            // PatientsRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 443);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBDisease);
            this.Controls.Add(this.RegisterPatientBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBPatientCNIC);
            this.Controls.Add(this.TBPatientContact);
            this.Controls.Add(this.TBPatientAge);
            this.Controls.Add(this.TBPatientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PatientsRegistration";
            this.Text = "PatientsRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBPatientName;
        private System.Windows.Forms.TextBox TBPatientAge;
        private System.Windows.Forms.TextBox TBPatientContact;
        private System.Windows.Forms.TextBox TBPatientCNIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterPatientBTN;
        private System.Windows.Forms.ComboBox CBDisease;
        private System.Windows.Forms.Label label6;
    }
}