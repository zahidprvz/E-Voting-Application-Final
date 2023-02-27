using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Voting_Application_Final.Views
{
    public partial class Voter_RegistrationFormView : Form
    {
        public Voter_RegistrationFormView()
        {
            InitializeComponent();
        }

        private void loginformLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //It will redirect to Voter_Login Form/Panel
            Voter_LoginFormView v_login_form = new Voter_LoginFormView();
            v_login_form.ShowDialog();

        }
    }
}
