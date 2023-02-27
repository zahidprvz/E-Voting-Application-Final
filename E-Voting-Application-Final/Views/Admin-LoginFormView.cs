using E_Voting_Application_Final.Controllers;
using E_Voting_Application_Final.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Voting_Application_Final.Views
{
    public partial class Admin_LoginFormView : Form
    {
        
        public Admin_LoginFormView()
        {
            InitializeComponent();
        }

        //Getting the email & password in the textboxes

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Admin_LoginFormController a_loginformcontroller = new Admin_LoginFormController();

            string email = tbxEmail.Text;
            string password = tbxPassword.Text;
            
            //Login method in Controller
            a_loginformcontroller.loginMethodController(email, password);
        }
    }
}
