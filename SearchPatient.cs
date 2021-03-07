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
    public partial class SearchPatient : Form
    {
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HospitalContextDataContext DC = new HospitalContextDataContext();
            var pts = from user in DC.AllRegistrations select user;
            foreach (var pt in pts)
            {
                if (pt.CNIC == this.TBPatientCNIC.Text)
                {
                    this.lblName.Text = pt.Name;
                    this.lblAge.Text = pt.Age;
                    this.lblContact.Text = pt.Contact;
                    this.lblDisease.Text = pt.Disease;
                }
                else
                    this.lblContact.Text = "No Patients Found.";
            }

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientWelcomeForm NewForm = new PatientWelcomeForm();
            NewForm.Show();
        }
    }
}
