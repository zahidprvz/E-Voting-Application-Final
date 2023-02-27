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
    public partial class Voter_LoginFormView : Form
    {
        public Voter_LoginFormView()
        {
            InitializeComponent();
        }

        private void registervoterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //It will redirect to Voter_Registration Form/Panel
            Voter_RegistrationFormView v_registration_form = new Voter_RegistrationFormView();
            v_registration_form.ShowDialog();
        }
    }
}
