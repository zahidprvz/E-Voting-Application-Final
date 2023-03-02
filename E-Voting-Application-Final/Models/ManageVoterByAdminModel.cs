using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using E_Voting_Application_Final.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.Xml.Linq;

namespace E_Voting_Application_Final.Models
{
    public class ManageVoterByAdminModel
    {
        SqlConnection con = new SqlConnection("Data Source=ZAHIDPARVIZ;Initial Catalog=ZahidDB;User ID=sa;Password=abc123");

        

        public List<string> voters = null;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string DOB { get; set; }
        public string Religion { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public string Country { get; set; }
        public string phoneNumber { get; set; }
        public string Email { get; set; }
        public string jobStatus { get; set; }
        public string CNIC { get; set; }
        public string errorString { get; set; }


        public static string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }



        public void addVoterByAdminModel(int Id, string Name, string Age, string Address, string City, string DOB, string Religion, string Gender, string MaritalStatus, string Nationality, string Country, string phoneNumber, string Email, string jobStatus, string CNIC)
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
                    MessageBox.Show("Please wait, while we send you a confirmation email...");
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
                    MessageBox.Show("\nYour Mail is sended");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                MessageBox.Show("\n\nNew Voter Added in Database successfully...");
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



        public void deleteVoterByAdminModel(int Id)
        {
            // Code to delete voter from the database

            try
            {
                con.Open();

                MessageBox.Show("Successfully connected to Database!");

                string selectStatement = "SELECT COUNT(*) from VoterTableFinal WHERE Id =" + Id;
              

                SqlCommand selectCommand = new SqlCommand(selectStatement, con);
              

                //int rowsAffected = command.ExecuteNonQuery();
                selectCommand.Parameters.AddWithValue("@Id", Id);

                int count = (int)selectCommand.ExecuteScalar();

                if (count > 0)
                {
                    // Voter exists, delete the voter
                    string deleteQuery = "DELETE FROM VoterTableFinal WHERE Id = @Id";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, con);
                    deleteCommand.Parameters.AddWithValue("@Id", Id);

                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Voter deleted successfully.");
                }
                else
                {
                    // User does not exist, show an error message
                    MessageBox.Show("User does not exist in the database.");
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


        public void searchVoterAdminModel(int Id)
        {
            try
            {
                con.Open();

                string selectStatement = "SELECT Id, Name, Age, Address, City, DOB, Religion, Gender, MaritalStatus, Nationality, Country, Email, phoneNumber, jobStatus, CNIC FROM VoterTableFinal where Id = " + Id;

                SqlCommand command = new SqlCommand(selectStatement, con);


                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Id = Convert.ToInt32(reader["Id"]);
                        Name = reader["Name"].ToString();
                        Age = reader["Age"].ToString();
                        Address = reader["Address"].ToString();
                        City = reader["City"].ToString();
                        DOB = reader["DOB"].ToString();
                        Religion = reader["Religion"].ToString();
                        Gender = reader["Gender"].ToString();
                        MaritalStatus = reader["MaritalStatus"].ToString();
                        Nationality = reader["Nationality"].ToString();
                        Country = reader["Country"].ToString();
                        Email = reader["Email"].ToString();
                        phoneNumber = reader["phoneNumber"].ToString();
                        jobStatus = reader["jobStatus"].ToString();
                        CNIC = reader["CNIC"].ToString();
                    }
                    reader.Close();
                }
                else
                {
                    errorString = "User does not exist..!";
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


    


