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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            HospitalContextDataContext DC = new HospitalContextDataContext();
            var users = from user in DC.AuthenticationTBLs select user;
            bool flag = false;
            foreach (var user in users)
            {
                if (user.Username == this.UsernameTB.Text && user.Password == this.PasswordTB.Text)
                {
                    flag = true;
                    this.Hide();
                    PatientWelcomeForm NewForm = new PatientWelcomeForm();
                    NewForm.Show();
                }
                
                    
            }
            if (flag == false) MessageBox.Show("Invalid Credentials");

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm NewForm = new RegisterForm();
            NewForm.Show();
        }
    }
}
