using E_Voting_Application_Final.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace E_Voting_Application_Final.Models
{
    internal class AdminControlsFormModel
    {
        SqlConnection con = new SqlConnection("Data Source=ZAHIDPARVIZ;Initial Catalog=ZahidDB;User ID=sa;Password=abc123");

        public void OnLoginButtonClicked(string elId, string elType, string ElCand, string candidates, string lastdate)
        {
            try
            {
                string electionId  = elId;
                string electionType = elType;
                string electionCandidate = ElCand;
                string candidateList = candidates;
                string lastDate = lastdate;

                
            
                if (electionId == "" || electionType == "" || electionCandidate == "" || candidates == "" || lastDate == "")
                {
                    MessageBox.Show("Please fill all fields...");
                }
                else
                {
                    try
                    {
                        con.Open();
                        String command = "insert into ElectionList values ('" +electionId+ "' , '" +electionType+ "' , '" +electionCandidate+ "' , '" +candidateList+ "' , '" +lastDate+ "') " ;
                        SqlCommand sqlCommand = new SqlCommand(command, con);
                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("New Election Inserted in Database...");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
