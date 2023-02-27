using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //Code to Load list of partyId/names in the CheckedListBox

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("[PartyName]", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sq = new SqlDataAdapter(cmd);
            sq.Fill(dt);

            foreach(DataRow dr in dt.Rows) 
            {
                clbxCandidate.Items.Add(dr[1].ToString());
            }
        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            //It will redirect to Add_Candidate Form
            AddNewCandidateFormView a_candidate_form = new AddNewCandidateFormView();
            a_candidate_form.ShowDialog();
        }

        private void btnAddNewElection_Click(object sender, EventArgs e)
        {
            //It will redirect to Add_Election Form
            Admin_Controls_Form a_controlsform = new Admin_Controls_Form();
            a_controlsform.ShowDialog();
        }

        private void btnElectionResult_Click(object sender, EventArgs e)
        {
            //It will redirect to ElectionResult Form
            ElectionResultPage electionresultform = new ElectionResultPage();
            electionresultform.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //It will Redirect to Welcome Page
            welcomeForm startform = new welcomeForm();
            startform.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //It will redirect to AllVotersListFormView
            
        }
    }
}
