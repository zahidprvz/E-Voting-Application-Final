using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(ofd.FileName);
                pictureBox2.Image = bit;
            }
        }
    }
}
