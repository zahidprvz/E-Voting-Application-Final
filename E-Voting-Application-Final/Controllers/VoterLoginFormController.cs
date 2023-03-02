using E_Voting_Application_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Voting_Application_Final.Controllers
{
    internal class VoterLoginFormController
    {
        public void loginMethodController(string email, string password)
        {
            VoterLoginFormModel voterLoginFormModel = new VoterLoginFormModel();

            string Email = email;
            string Password = password;

            voterLoginFormModel.OnLoginButtonClicked(Email, Password);
        }
    }
}
