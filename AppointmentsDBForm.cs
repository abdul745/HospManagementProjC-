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
    public partial class AppointmentsDBForm : Form
    {
        public AppointmentsDBForm()
        {
            InitializeComponent();
            HospitalContextDataContext DC = new HospitalContextDataContext();
            this.dataGridView1.DataSource = from user in DC.AppointmentsTBLs select user;
        }

       
    }
}
