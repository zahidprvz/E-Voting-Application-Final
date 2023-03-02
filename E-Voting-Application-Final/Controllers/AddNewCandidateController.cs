using E_Voting_Application_Final.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Voting_Application_Final.Controllers
{
    internal class AddNewCandidateController
    {
        public void uploadDataToDataBaseController(string id ,string name, string slogan, string partyname)
        {
            //Object of Model Class to perform database operations
            AddNewCandidateModel addNewCandidateModel = new AddNewCandidateModel();
            addNewCandidateModel.OnLoginButtonClicked(id ,name, slogan, partyname);
        }
    }
}
