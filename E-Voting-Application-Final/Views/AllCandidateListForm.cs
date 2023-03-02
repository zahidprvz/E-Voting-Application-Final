using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Voting_Application_Final.Views
{
    public partial class AllCandidateListForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ZAHIDPARVIZ;Initial Catalog=ZahidDB;User ID=sa;Password=abc123");

        public AllCandidateListForm()
        {
            InitializeComponent();
        }

        private void AllCandidateListForm_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter sqlDA = new SqlDataAdapter("select * from CandidateList1", con);
            DataTable dataTable = new DataTable();
            sqlDA.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            con.Close();

        }
    }
}
