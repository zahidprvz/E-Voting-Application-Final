using E_Voting_Application_Final.Controllers;
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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            VoterLoginFormController voterLoginFormController = new VoterLoginFormController();

            string email = tbxEmail.Text;
            string password = tbxPassword.Text;

            //Login method in Controller
            voterLoginFormController.loginMethodController(email, password);

            tbxPassword.Text = "";
        }

        private void cbxShowP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowP.Checked == true)
            {
                tbxPassword.UseSystemPasswordChar = false;
            }
            if (cbxShowP.Checked == false)
            {
                tbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void Voter_LoginFormView_Load(object sender, EventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = true;
        }
    }
}
