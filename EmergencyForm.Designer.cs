namespace Abdullah_Aadrish_VP_Poject_HospitalMS
{
    partial class EmergencyForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.CBDisease = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBLevel = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.label1.Location = new System.Drawing.Point(117, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emergency Situation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(120, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Select Disease";
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
            this.CBDisease.Location = new System.Drawing.Point(339, 159);
            this.CBDisease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBDisease.Name = "CBDisease";
            this.CBDisease.Size = new System.Drawing.Size(147, 24);
            this.CBDisease.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(79, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Severity Level";
            // 
            // CBLevel
            // 
            this.CBLevel.FormattingEnabled = true;
            this.CBLevel.Items.AddRange(new object[] {
            "Stage 1",
            "Stage 2",
            "Stage 3"});
            this.CBLevel.Location = new System.Drawing.Point(339, 207);
            this.CBLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBLevel.Name = "CBLevel";
            this.CBLevel.Size = new System.Drawing.Size(147, 24);
            this.CBLevel.TabIndex = 14;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(223, 262);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(157, 52);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Register Patient";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblName.Location = new System.Drawing.Point(120, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 22);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Patient Name";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(339, 106);
            this.TBName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(147, 22);
            this.TBName.TabIndex = 18;
            // 
            // EmergencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 372);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBDisease);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmergencyForm";
            this.Text = "EmergencyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBDisease;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBLevel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox TBName;
    }
}