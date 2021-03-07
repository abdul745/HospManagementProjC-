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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        // CODE by AADI

        private void setAppointmentBTN_Click(object sender, EventArgs e)
        {
            // create an Appointments table if not created earlier
            HospitalContextDataContext DC = new HospitalContextDataContext();
            AppointmentsTBL NewRecord = new AppointmentsTBL();

            NewRecord.Name = this.TBPatientName.Text;
            NewRecord.Contact = this.TBPatientContact.Text;
            NewRecord.Age = Convert.ToInt32(TBPatientAge.Text);
            NewRecord.Disease = this.CBDisease.Text;

            DC.AppointmentsTBLs.InsertOnSubmit(NewRecord);
            DC.SubmitChanges();

            MessageBox.Show("Appointment Succedded!");
            this.Hide();
            PatientWelcomeForm newForm = new PatientWelcomeForm();
            newForm.Show();
        }
    }
}
