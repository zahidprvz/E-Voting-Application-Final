using E_Voting_Application_Final.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace E_Voting_Application_Final.Models
{

    internal class Admin_LoginFormModel
    {
        SqlConnection con = new SqlConnection("Data Source=ZAHIDPARVIZ;Initial Catalog=ZahidDB;User ID=sa;Password=abc123");
        
        public string Email { get; set; }
        public string Password { get; set; }
        
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
                    String cmd2 = "select * from Admin where AdminEmail = '" + email + "' and AdminPassword = '" + password + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(cmd2, con);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        Email = email;
                        Password = password;

                        Admin_Controls_Form admin_Controls_Form= new Admin_Controls_Form();
                        admin_Controls_Form.ShowDialog();



                    }
                    else
                    {
                        MessageBox.Show("Oops, Check Your Email/Password again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
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
