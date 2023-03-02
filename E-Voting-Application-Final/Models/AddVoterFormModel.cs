using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Voting_Application_Final.Views;

namespace E_Voting_Application_Final.Models
{
    public class AddVoterFormModel
    {
        SqlConnection con = new SqlConnection("Data Source=ZAHIDPARVIZ;Initial Catalog=ZahidDB;User ID=sa;Password=abc123");
        //To show progressing bar during execution
        int i = 0;

        public static string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void addVoterModel(int Id, string Name, string Age, string Address, string City, string DOB, string Religion, string Gender, string MaritalStatus, string Nationality, string Country, string phoneNumber, string Email, string jobStatus, string CNIC)
        {
            int size = 8;
            var password = GenerateRandomPassword(size);

            try
            {
                con.Open();

                MessageBox.Show("Connected to Database..!");


                string insertStatement = "INSERT INTO VoterTableFinal (Id, Name, Age, Address, City, DOB, Religion, Gender, MaritalStatus, Nationality, Country, Email, PhoneNumber, JobStatus, CNIC, Password) VALUES (@Id, @Name, @Age, @Address, @City, @DOB, @Religion, @Gender, @MaritalStatus, @Nationality, @Country, @Email, @PhoneNumber, @JobStatus, @CNIC, @Password)";

                SqlCommand command = new SqlCommand(insertStatement, con);

                command.Parameters.AddWithValue("Id", Id);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Age", Age);
                command.Parameters.AddWithValue("@Address", Address);
                command.Parameters.AddWithValue("@City", City);
                command.Parameters.AddWithValue("@DOB", DOB);
                command.Parameters.AddWithValue("@Religion", Religion);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@MaritalStatus", MaritalStatus);
                command.Parameters.AddWithValue("@Nationality", Nationality);
                command.Parameters.AddWithValue("@Country", Country);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@JobStatus", jobStatus);
                command.Parameters.AddWithValue("@CNIC", CNIC);
                command.Parameters.AddWithValue("@Password", password);
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                try
                {
                    i = 0;
                    while (i == 0)
                    {
                        MailMessage msg = new MailMessage();
                        msg.From = new MailAddress("pervaizzahid55@gmail.com");
                        msg.To.Add(Email);
                        msg.Subject = "Pakistan Election Commission";
                        msg.Body = "Hello " + Name + "\n\nWelcome to PEC.\nYou have been registered as a Verified Voter!\nNow you can give your vote to any of the Political Party\n\nYou can login by using following Login credentials\n\n" + "Email: " + Email + "\nPassword: " + password;

                        SmtpClient smt = new SmtpClient();
                        smt.Host = "smtp.gmail.com";
                        System.Net.NetworkCredential ntcd = new NetworkCredential();
                        ntcd.UserName = "pervaizzahid55@gmail.com";
                        ntcd.Password = "qdnjjecciqgnscfa";
                        smt.Credentials = ntcd;
                        smt.EnableSsl = true;
                        smt.Port = 587;
                        smt.Send(msg);
                        i = 1;
                    }
                    
                    
                    MessageBox.Show("\nYour Mail is sended");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                MessageBox.Show("\n\nNew Voter Added in Database successfully...");
                MessageBox.Show("Check Inbox of your Provided Email for your Login Credentials...");

                Voter_LoginFormView voter_LoginFormView = new Voter_LoginFormView();
                voter_LoginFormView.ShowDialog();
            }
            catch (Exception exx)
            {

                MessageBox.Show(exx.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        }
    }

