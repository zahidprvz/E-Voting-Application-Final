using E_Voting_Application_Final.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Voting_Application_Final.Views
{
    public partial class Admin_Controls_Form : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ZAHIDPARVIZ;Initial Catalog=ZahidDB;User ID=sa;Password=abc123");

        public Admin_Controls_Form()
        {
            InitializeComponent();
        }



        private void Admin_Controls_Form_Load(object sender, EventArgs e)
        {
            
            con.Open();


            SqlCommand sqlCommand = new SqlCommand("select Name from CandidateList1", con);

            try
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string item = reader.GetString(0);
                        tbxParticipants.Items.Add(item);
                    }
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

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddNewElection_Click(object sender, EventArgs e)
        {

        }

        private void btnElectionResult_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUploadElection_Click(object sender, EventArgs e)
        {
            string electionID = tbxElectionId.Text;
            string electionType = tbxElectionType.Text;
            string noOfCandidates = tbxNoOfCandidates.Text;
            string dateTime = dateTimePicker1.Value.ToString();

            string participnatsList = tbxParticipants.Text;

            


            //Method to upload Data to Database using Model through Controller
            AdminControlsFormController adminControlsFormController = new AdminControlsFormController();
            adminControlsFormController.uploadDataToDataBaseController(electionID, electionType, noOfCandidates, participnatsList, dateTime);
        }

        private void tbxParticipants_MouseClick(object sender, MouseEventArgs e)
        {
            tbxParticipants.Focus();
        }

        private void btnAddCandidate_Click_1(object sender, EventArgs e)
        {
            //It will redirect to Add_Candidate Form
            AddNewCandidateFormView a_candidate_form = new AddNewCandidateFormView();
            a_candidate_form.ShowDialog();
        }

        private void btnAddNewElection_Click_1(object sender, EventArgs e)
        {

            //It will redirect to Add_Election Form
            Admin_Controls_Form a_controlsform = new Admin_Controls_Form();
            a_controlsform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //It will redirect to AllVotersListFormView
            AllVotersListFormView allVotersListFormView = new AllVotersListFormView();
            allVotersListFormView.ShowDialog();
        }

        private void btnElectionResult_Click_1(object sender, EventArgs e)
        {
            //It will redirect to ElectionResult Form
            ResultForm_View resultForm_View = new ResultForm_View();
            resultForm_View.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AllCandidateListForm allCandidateListForm = new AllCandidateListForm();
            allCandidateListForm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddVoterFormForAdminView addVoterFormForAdminView = new AddVoterFormForAdminView();
            addVoterFormForAdminView.ShowDialog(this);
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            //It will Redirect to Welcome Page
            welcomeForm startform = new welcomeForm();
            startform.ShowDialog(this);
        }
    }
}
