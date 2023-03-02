using E_Voting_Application_Final.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Voting_Application_Final.Views
{
    public partial class AddNewCandidateFormView : Form
    {
        public AddNewCandidateFormView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbxCandidate.Image = new Bitmap(openFileDialog.FileName);
            }
            */
        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            AddNewCandidateFormView addNewCandidateFormView = new AddNewCandidateFormView();
            addNewCandidateFormView.ShowDialog();
        }

        private void btnAddNewElection_Click(object sender, EventArgs e)
        {
            Admin_Controls_Form admin_Controls_Form = new Admin_Controls_Form();
            admin_Controls_Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AllVotersListFormView allVotersListFormView = new AllVotersListFormView();
            allVotersListFormView.ShowDialog();
        }

        private void btnElectionResult_Click(object sender, EventArgs e)
        {
            ElectionResultPage electionResultPage = new ElectionResultPage();
            electionResultPage.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddVoterFormForAdminView addVoterFormFor = new AddVoterFormForAdminView();
            addVoterFormFor.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            welcomeForm welcomeForm = new welcomeForm();
            welcomeForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // User clicked Yes button

                string Id = tbxCandidateId.Text;
                string Name = tbxCandidateName.Text;
                string Slogan = tbxCandidateSlogan.Text;
                string PartyName = tbxPartyName.Text;
                //Image image = pbxCandidate.Image;


                //Method to upload Data to Database using Model through Controller
                AddNewCandidateController addNewCandidateController = new AddNewCandidateController();
                addNewCandidateController.uploadDataToDataBaseController(Id, Name, Slogan, PartyName);
            }
            else if (result == DialogResult.No)
            {
                // User clicked No button
                MessageBox.Show("No Operation performed..!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
