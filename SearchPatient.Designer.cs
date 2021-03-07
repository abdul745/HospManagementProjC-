namespace Abdullah_Aadrish_VP_Poject_HospitalMS
{
    partial class SearchPatient
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
            this.TBPatientCNIC = new System.Windows.Forms.TextBox();
            this.lblPatientCNIC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblDisease = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBPatientCNIC
            // 
            this.TBPatientCNIC.Location = new System.Drawing.Point(269, 156);
            this.TBPatientCNIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPatientCNIC.Name = "TBPatientCNIC";
            this.TBPatientCNIC.Size = new System.Drawing.Size(161, 22);
            this.TBPatientCNIC.TabIndex = 9;
            // 
            // lblPatientCNIC
            // 
            this.lblPatientCNIC.AutoSize = true;
            this.lblPatientCNIC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPatientCNIC.Location = new System.Drawing.Point(52, 158);
            this.lblPatientCNIC.Name = "lblPatientCNIC";
            this.lblPatientCNIC.Size = new System.Drawing.Size(162, 22);
            this.lblPatientCNIC.TabIndex = 8;
            this.lblPatientCNIC.Text = "Enter Patient CNIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.label1.Location = new System.Drawing.Point(85, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search Patient Details";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(196, 214);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 43);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 319);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(12, 17);
            this.lblName.TabIndex = 12;
            this.lblName.Text = ".";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(147, 319);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(12, 17);
            this.lblAge.TabIndex = 13;
            this.lblAge.Text = ".";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(265, 319);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(12, 17);
            this.lblContact.TabIndex = 14;
            this.lblContact.Text = ".";
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.Location = new System.Drawing.Point(400, 319);
            this.lblDisease.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(12, 17);
            this.lblDisease.TabIndex = 15;
            this.lblDisease.Text = ".";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(196, 359);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(104, 43);
            this.BtnOK.TabIndex = 16;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // SearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 462);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.lblDisease);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBPatientCNIC);
            this.Controls.Add(this.lblPatientCNIC);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchPatient";
            this.Text = "SearchPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBPatientCNIC;
        private System.Windows.Forms.Label lblPatientCNIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.Button BtnOK;
    }
}