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
    public partial class PatientsRegistration : Form
    {
        public PatientsRegistration()
        {
            InitializeComponent();
        }

        private void RegisterPatientBTN_Click(object sender, EventArgs e)
        {
            
            HospitalContextDataContext DC = new HospitalContextDataContext();
            AllRegistration NewRecord = new AllRegistration();

            NewRecord.Name = this.TBPatientName.Text;
            NewRecord.Contact = this.TBPatientContact.Text;
            NewRecord.Age = this.TBPatientCNIC.Text;
            NewRecord.CNIC = this.TBPatientCNIC.Text;

            DC.AllRegistrations.InsertOnSubmit(NewRecord);
            DC.SubmitChanges();

            MessageBox.Show("Patient Registered Successfully!");
            this.Hide();
            PatientWelcomeForm newForm = new PatientWelcomeForm();
            newForm.Show();
        }
    }
}
