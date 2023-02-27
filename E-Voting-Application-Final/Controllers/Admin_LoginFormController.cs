using E_Voting_Application_Final.Models;
using E_Voting_Application_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace E_Voting_Application_Final.Controllers
{
    internal class Admin_LoginFormController
    {
        public void loginMethodController(string email, string password)
        {
            Admin_LoginFormModel a_loginformmodel = new Admin_LoginFormModel();

            string Email = email;
            string Password = password;

            a_loginformmodel.OnLoginButtonClicked(Email, Password);
        }
    }
}
