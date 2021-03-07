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
    public partial class PatientWelcomeForm : Form
    {
        public PatientWelcomeForm()
        {
            InitializeComponent();
        }
        //  CODE BY AADI
        private void PatientsRegBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientsRegistration newForm = new PatientsRegistration();
            newForm.Show();
        }

        private void AppointmentsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm newForm = new AppointmentForm();
            newForm.Show();
        }

        private void EmergencyBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmergencyForm newForm = new EmergencyForm();
            newForm.Show();

        }

        private void GuestBtn_Click(object sender, EventArgs e)
        {
            ////////// not sure
            this.Hide();
            SearchPatient newForm = new SearchPatient();
            newForm.Show();
        }

        private void ViewDBBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowDB newForm = new ShowDB();
            newForm.Show();
        }
    }
}
