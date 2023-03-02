using E_Voting_Application_Final.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using E_Voting_Application_Final.Models;

namespace E_Voting_Application_Final.Views
{
    
    public partial class AddVoterFormForAdminView : Form
    {
        

        public AddVoterFormForAdminView()
        {
            InitializeComponent();
            
        }

        private void btnGetAllVoters_Click(object sender, EventArgs e)
        {
            AllVotersListFormView allVotersListFormView = new AllVotersListFormView();
            allVotersListFormView.ShowDialog(this);
        }

        private void btnAddVoter_Click(object sender, EventArgs e)
        {

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                if (checkBox1.Checked && txtId.Text != "" && txtName.Text != "" && txtAge.Text != "" && txtAddress.Text != "" && txtCity.Text != "" && txtDob.Text != "" && txtReligion.Text != "" && txtGender.Text != "" && txtMaritalStatus.Text != "" && txtNationality.Text != "" && txtCountry.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && txtJobStatus.Text != "" && tbxCNIC.Text != "")
                {
                    int Id = int.Parse(txtId.Text);
                    string Name = txtName.Text;
                    string Age = txtAge.Text;
                    string Address = txtAddress.Text;
                    string City = txtCity.Text;
                    string DOB = txtDob.Text;
                    string Religion = txtReligion.Text;
                    string Gender = txtGender.Text;
                    string MaritalStatus = txtMaritalStatus.Text;
                    string Nationality = txtNationality.Text;
                    string Country = txtCountry.Text;
                    string phoneNumber = txtPhone.Text;
                    string Email = txtEmail.Text;
                    string jobStatus = txtJobStatus.Text;
                    string CNIC = tbxCNIC.Text;



                    //Method to insert Voter into database in Model through Controller
                    ManageVoterByAdminController manageVoterByAdminController = new ManageVoterByAdminController();
                    manageVoterByAdminController.addVoterByAdminController(Id, Name, Age, Address, City, DOB, Religion, Gender, MaritalStatus, Nationality, Country, phoneNumber, Email, jobStatus, CNIC);

                    

                    txtId.Clear();
                    txtId.Focus();
                    txtName.Clear();
                    txtAge.Clear();
                    txtAddress.Clear();
                    txtCity.Clear();
                    txtDob.Clear();
                    txtReligion.Clear();
                    txtGender.Clear();
                    txtMaritalStatus.Clear();
                    txtNationality.Clear();
                    txtCountry.Clear();
                    txtPhone.Clear();
                    txtEmail.Clear();
                    txtJobStatus.Clear();
                    tbxCNIC.Clear();


                }
                else
                {
                    MessageBox.Show("Fill all the fields/checkBox!");
                }
            }
            else
            {
                MessageBox.Show("Invalid email address");
            }


            
            progressBar1.Value = 0;
        }

        private void btnDeleteVoter_Click(object sender, EventArgs e)
        {
            
            if (txtId.Text != "")
            {
                int Id = int.Parse(txtId.Text);
                //Method to delete voter from database
                ManageVoterByAdminController manageVoterByAdminController = new ManageVoterByAdminController();
                manageVoterByAdminController.deleteVoterByAdminController(Id);
                progressBar1.Value = 0;
            }
            else
            {
                MessageBox.Show("Please, enter a valid ID to delete!");
            }
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtEmail.Clear();
        }

        private void btnGetVoterById_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                int Id = int.Parse(txtId.Text);
                //Method to search a specific voter from database
                ManageVoterByAdminController manageVoterByAdminController = new ManageVoterByAdminController();
                manageVoterByAdminController.searchVoterByAdminController(Id);


                ManageVoterByAdminModel manageVoterByAdminModel = new ManageVoterByAdminModel();
                manageVoterByAdminModel.searchVoterAdminModel(Id);


                if (manageVoterByAdminModel.errorString == null)
                {
                    txtId.Text = manageVoterByAdminModel.Id.ToString();
                    txtName.Text = manageVoterByAdminModel.Name.ToString();
                    txtAge.Text = manageVoterByAdminModel.Age.ToString();
                    txtAddress.Text = manageVoterByAdminModel.Address.ToString();
                    txtCity.Text = manageVoterByAdminModel.City.ToString();
                    txtDob.Text = manageVoterByAdminModel.DOB.ToString();
                    txtReligion.Text = manageVoterByAdminModel.Religion.ToString();
                    txtGender.Text = manageVoterByAdminModel.Gender.ToString();
                    txtMaritalStatus.Text = manageVoterByAdminModel.MaritalStatus.ToString();
                    txtNationality.Text = manageVoterByAdminModel.Nationality.ToString();
                    txtCountry.Text = manageVoterByAdminModel.Country.ToString();
                    txtEmail.Text = manageVoterByAdminModel.Email.ToString();
                    txtPhone.Text = manageVoterByAdminModel.phoneNumber.ToString();
                    txtJobStatus.Text = manageVoterByAdminModel.jobStatus.ToString();
                    tbxCNIC.Text = manageVoterByAdminModel.CNIC.ToString();
                }
                else
                {
                    MessageBox.Show(manageVoterByAdminModel.errorString);

                    txtId.Focus();
                    txtName.Clear();
                    txtAge.Clear();
                    txtAddress.Clear();
                    txtCity.Clear();
                    txtDob.Clear();
                    txtReligion.Clear();
                    txtGender.Clear();
                    txtMaritalStatus.Clear();
                    txtNationality.Clear();
                    txtCountry.Clear();
                    txtPhone.Clear();
                    txtEmail.Clear();
                    txtJobStatus.Clear();
                    tbxCNIC.Clear();

                }

                progressBar1.Value = 0;
            }
            else
            {
                MessageBox.Show("Enter a valid ID to search!");
            }
        }

        private void txtJobStatus_MouseClick(object sender, MouseEventArgs e)
        {
            txtJobStatus.Clear();
        }

        private void txtDob_MouseClick(object sender, MouseEventArgs e)
        {
            txtDob.Clear();
        }

        private void txtMaritalStatus_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaritalStatus.Clear();
        }

        private int progressBarValue = 0;

        private void txtId_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled
            if (txtId.Text.Trim() != "")
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (txtName.Text.Trim() != "" && txtName.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                txtName.Tag = "clicked";
            }
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (txtAge.Text.Trim() != "" && txtAge.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                txtAge.Tag = "clicked";
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (txtAddress.Text.Trim() != "" && txtAddress.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                txtAddress.Tag = "clicked";
            }
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (txtCity.Text.Trim() != "" && txtCity.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                txtCity.Tag = "clicked";
            }
        }

        private void txtDob_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (txtDob.Text.Trim() != "" && txtDob.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                txtDob.Tag = "clicked";
            }
        }

        private void txtReligion_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (txtReligion.Text.Trim() != "" && txtReligion.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                txtReligion.Tag = "clicked";
            }
        }

        private void txtGender_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (txtGender.Text.Trim() != "" && txtGender.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                txtGender.Tag = "clicked";
            }
        }

        private void txtNationality_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (txtNationality.Text.Trim() != "" && txtNationality.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                txtNationality.Tag = "clicked";
            }
        }

        private void txtCountry_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (txtCountry.Text.Trim() != "" && txtCountry.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                txtCountry.Tag = "clicked";
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (txtPhone.Text.Trim() != "" && txtPhone.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                txtPhone.Tag = "clicked";
            }
        }

        private void tbxCNIC_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (tbxCNIC.Text.Trim() != "" && tbxCNIC.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                tbxCNIC.Tag = "clicked";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (txtEmail.Text.Trim() != "" && txtEmail.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                txtEmail.Tag = "clicked";
            }
        }

        private void txtJobStatus_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (txtJobStatus.Text.Trim() != "" && txtJobStatus.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                txtJobStatus.Tag = "clicked";
            }
        }

        private void txtMaritalStatus_Leave(object sender, EventArgs e)
        {
            // Check if the textbox is filled and has not been clicked before
            if (txtMaritalStatus.Text.Trim() != "" && txtMaritalStatus.Tag == null)
            {
                // Increment the progress bar's value by the Step amount
                progressBarValue += progressBar1.Step;
                progressBar1.Value = progressBarValue;

                // Set the textbox's Tag property to indicate it has been clicked before
                txtMaritalStatus.Tag = "clicked";
            }
        }

        private void AddVoterFormForAdminView_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }
    }
}
