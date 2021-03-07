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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            HospitalContextDataContext DC = new HospitalContextDataContext();
            
            StaffTBL NewRecord = new StaffTBL();

            String StaffName = this.NameTB.Text;
            String ContactNo = this.ContactTB.Text;
            String UN = this.UsernameTB.Text;
            String Pass = this.PasswordTB.Text;

            NewRecord.Name = StaffName;
            NewRecord.Contact = ContactNo;
            NewRecord.username = UN;
            NewRecord.password = Pass;

            AuthenticationTBL AuthRecord = new AuthenticationTBL();
            AuthRecord.Username = UN;
            AuthRecord.Password = Pass;
          
            DC.AuthenticationTBLs.InsertOnSubmit(AuthRecord);  
            DC.StaffTBLs.InsertOnSubmit(NewRecord);
            DC.SubmitChanges();

            MessageBox.Show("Admin Registered Successfully!");

            WelcomeForm Welcome = new WelcomeForm();
            this.Hide();
            Welcome.Show();
        }
    }
}
