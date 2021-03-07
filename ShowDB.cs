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
    public partial class ShowDB : Form
    {
        public ShowDB()
        {
            InitializeComponent();
        }

        private void BTNRegistrations_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationsDBForm newForm = new RegistrationsDBForm();
            newForm.Show();
        }

        private void BtnAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentsDBForm newForm = new AppointmentsDBForm();
            newForm.Show();
        }
    }
}
