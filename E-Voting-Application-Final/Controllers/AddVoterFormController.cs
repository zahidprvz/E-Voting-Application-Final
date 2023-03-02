using E_Voting_Application_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Voting_Application_Final.Controllers
{
    internal class AddVoterFormController
    {
        public void addVoterController(int Id, string Name, string Age, string Address, string City, string DOB, string Religion, string Gender, string MaritalStatus, string Nationality, string Country, string phoneNumber, string Email, string jobStatus, string CNIC)
        {
            AddVoterFormModel addVoterFormModel = new AddVoterFormModel();
            addVoterFormModel.addVoterModel(Id, Name, Age, Address, City, DOB, Religion, Gender, MaritalStatus, Nationality, Country, phoneNumber, Email, jobStatus, CNIC);

        }

        
    }
}
