using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using E_Voting_Application_Final.Models;

namespace E_Voting_Application_Final.Controllers
{
    public class ManageVoterByAdminController
    {
        public void addVoterByAdminController(int Id,string Name,string Age,string Address,string City,string DOB,string Religion,string Gender,string MaritalStatus,string Nationality,string Country,string phoneNumber,string Email,string jobStatus,string CNIC)
        {
            ManageVoterByAdminModel manageVoterByAdminModel = new ManageVoterByAdminModel();
            manageVoterByAdminModel.addVoterByAdminModel(Id, Name, Age, Address, City, DOB, Religion, Gender, MaritalStatus, Nationality, Country, phoneNumber, Email, jobStatus, CNIC);
        }

        public void deleteVoterByAdminController(int id)
        {
            ManageVoterByAdminModel manageVoterByAdminModel =new ManageVoterByAdminModel();
            manageVoterByAdminModel.deleteVoterByAdminModel(id);
        }

        public void searchVoterByAdminController(int id)
        {
            ManageVoterByAdminModel manageVoterByAdminModel = new ManageVoterByAdminModel();
            manageVoterByAdminModel.searchVoterAdminModel(id);
        }
    }
}
