using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Voting_Application_Final.Models
{
    internal class AddNewCandidateModel
    {
        SqlConnection con = new SqlConnection("Data Source=ZAHIDPARVIZ;Initial Catalog=ZahidDB;User ID=sa;Password=abc123");

        public void OnLoginButtonClicked(string Id, string name, string slogan, string partyname)
        {
            con.Open();

                if (Id == "" || name == "" || slogan == "" || partyname == "")
                {
                    MessageBox.Show("Please fill all fields...");
                }
                else
                {
                    try
                    {
                        String command = "insert into CandidateList1 values ('" + Id + "' ,'" + name + "'  , '" + slogan + "' , '" + partyname + "' ) ";
                        SqlCommand sqlCommand = new SqlCommand(command, con);

                    sqlCommand.Parameters.AddWithValue("@Id", Id);
                    sqlCommand.Parameters.AddWithValue("@Name", name);
                    sqlCommand.Parameters.AddWithValue("@Slogan", slogan);
                    sqlCommand.Parameters.AddWithValue("@PartyName", partyname);
                    //sqlCommand.Parameters.AddWithValue("@Picture", image);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();



                    MessageBox.Show("New Candidate Inserted in Database...");

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
        }
    }
