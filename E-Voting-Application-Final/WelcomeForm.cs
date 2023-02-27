using E_Voting_Application_Final.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Voting_Application_Final
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void entitiesCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(entitiesCbx.Text == "Admin")
            {
                //It will redirect to Admin Panel/Form
                Admin_LoginFormView a_login_form = new Admin_LoginFormView();
                a_login_form.ShowDialog();
            }
            else if(entitiesCbx.Text == "Voter")
            {
                //It will redirect to Voter Panel/Form
                Voter_RegistrationFormView v_registration_form = new Voter_RegistrationFormView();
                v_registration_form.ShowDialog();
            }
        }
    }
}
