using E_Voting_Application_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace E_Voting_Application_Final.Controllers
{
    internal class AdminControlsFormController
    {
         public void uploadDataToDataBaseController(string elId, string elType, string elCand, string candidates, string date)
        {
            AdminControlsFormModel adminControlsFormModel = new AdminControlsFormModel();

            string ElectionId = elId;
            string ElectionType = elType;
            string ElectionCand = elCand;
            string candidate = candidates;
            string LastDate = date;

            
            adminControlsFormModel.OnLoginButtonClicked(ElectionId, ElectionType, ElectionCand, candidate, LastDate);
        }
    }
}
