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
    public partial class ResultForm_View : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ZAHIDPARVIZ;Initial Catalog=ZahidDB;User ID=sa;Password=abc123");

        public ResultForm_View()
        {
            InitializeComponent();
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

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddVoterFormForAdminView addVoterFormForAdminView = new AddVoterFormForAdminView();
            addVoterFormForAdminView.ShowDialog(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            welcomeForm welcomeForm = new welcomeForm();
            welcomeForm.ShowDialog(this);
        }

        private void ResultForm_View_Load(object sender, EventArgs e)
        {
            con.Open();


            SqlCommand sqlCommand = new SqlCommand("select ElectionId from ElectionList", con);

            try
            {
                    // Create a SqlDataReader object to read the data returned by the SELECT statement
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    // Iterate through the SqlDataReader object and add each data item to the listbox
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader["ElectionId"].ToString());
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
