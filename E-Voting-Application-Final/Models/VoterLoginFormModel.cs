using E_Voting_Application_Final.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Voting_Application_Final.Models
{
    internal class VoterLoginFormModel
    {
        SqlConnection con = new SqlConnection("Data Source=ZAHIDPARVIZ;Initial Catalog=ZahidDB;User ID=sa;Password=abc123");

        

        public void OnLoginButtonClicked(string Email, string Password)
        {
            string email = Email;
            string password = Password;


            if (email == "" || password == "")
            {
                MessageBox.Show("Please fill both fields...");
            }
            else
            {
                try
                {
                    String cmd2 = "select * from VoterTableFinal where Email = '" + email + "' and Password = '" + password + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(cmd2, con);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        Email = email;
                        Password = password;

                        VoterAfterLoginView voterAfterLoginView = new VoterAfterLoginView();
                        voterAfterLoginView.ShowDialog();



                    }
                    else
                    {
                        MessageBox.Show("Oops, Check Your Email/Password again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

