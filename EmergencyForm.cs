using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdullah_Aadrish_VP_Poject_HospitalMS
{
    public partial class EmergencyForm : Form
    {
        public EmergencyForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            HospitalContextDataContext DC = new HospitalContextDataContext();
            EmergencyTBL NewRecord = new EmergencyTBL();

            NewRecord.Name = this.TBName.Text;
            NewRecord.Disease = this.CBDisease.Text;
            NewRecord.Severity = this.CBLevel.Text;
            
            DC.EmergencyTBLs.InsertOnSubmit(NewRecord);
            DC.SubmitChanges();

            MessageBox.Show("Patient Registered as Emergency!");
            this.Hide();
            PatientWelcomeForm newForm = new PatientWelcomeForm();
            newForm.Show();
        }
    }
}
