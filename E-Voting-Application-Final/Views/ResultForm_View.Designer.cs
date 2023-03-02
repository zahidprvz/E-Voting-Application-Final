namespace E_Voting_Application_Final.Views
{
    partial class ResultForm_View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.electionListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zahidDBDataSet5 = new E_Voting_Application_Final.ZahidDBDataSet5();
            this.label1 = new System.Windows.Forms.Label();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnElectionResult = new System.Windows.Forms.Button();
            this.btnAddNewElection = new System.Windows.Forms.Button();
            this.btnAddCandidate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.electionListTableAdapter = new E_Voting_Application_Final.ZahidDBDataSet5TableAdapters.ElectionListTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electionListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahidDBDataSet5)).BeginInit();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(369, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 430);
            this.panel1.TabIndex = 69;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(225, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 84);
            this.listBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(71, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Votes Casted : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 26);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(225, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(90, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Election ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Calculation of Votes";
            // 
            // electionListBindingSource
            // 
            this.electionListBindingSource.DataMember = "ElectionList";
            this.electionListBindingSource.DataSource = this.zahidDBDataSet5;
            // 
            // zahidDBDataSet5
            // 
            this.zahidDBDataSet5.DataSetName = "ZahidDBDataSet5";
            this.zahidDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "Welcome to PEC Application";
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.adminPanel.Controls.Add(this.button5);
            this.adminPanel.Controls.Add(this.button3);
            this.adminPanel.Controls.Add(this.button4);
            this.adminPanel.Controls.Add(this.btnLogout);
            this.adminPanel.Controls.Add(this.btnElectionResult);
            this.adminPanel.Controls.Add(this.btnAddNewElection);
            this.adminPanel.Controls.Add(this.btnAddCandidate);
            this.adminPanel.Location = new System.Drawing.Point(45, 280);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(300, 430);
            this.adminPanel.TabIndex = 73;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(30, 248);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = "Show All Candidate List";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(30, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "Manage Voters";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(30, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 50);
            this.button4.TabIndex = 2;
            this.button4.Text = "Show List of All Voters";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(30, 360);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(240, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnElectionResult
            // 
            this.btnElectionResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnElectionResult.Location = new System.Drawing.Point(30, 192);
            this.btnElectionResult.Name = "btnElectionResult";
            this.btnElectionResult.Size = new System.Drawing.Size(240, 50);
            this.btnElectionResult.TabIndex = 3;
            this.btnElectionResult.Text = "View Election Results";
            this.btnElectionResult.UseVisualStyleBackColor = false;
            this.btnElectionResult.Click += new System.EventHandler(this.btnElectionResult_Click);
            // 
            // btnAddNewElection
            // 
            this.btnAddNewElection.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewElection.Location = new System.Drawing.Point(30, 78);
            this.btnAddNewElection.Name = "btnAddNewElection";
            this.btnAddNewElection.Size = new System.Drawing.Size(240, 50);
            this.btnAddNewElection.TabIndex = 1;
            this.btnAddNewElection.Text = "Add New Election";
            this.btnAddNewElection.UseVisualStyleBackColor = false;
            this.btnAddNewElection.Click += new System.EventHandler(this.btnAddNewElection_Click);
            // 
            // btnAddCandidate
            // 
            this.btnAddCandidate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCandidate.Location = new System.Drawing.Point(30, 21);
            this.btnAddCandidate.Name = "btnAddCandidate";
            this.btnAddCandidate.Size = new System.Drawing.Size(240, 50);
            this.btnAddCandidate.TabIndex = 0;
            this.btnAddCandidate.Text = "Add Candidate";
            this.btnAddCandidate.UseVisualStyleBackColor = false;
            this.btnAddCandidate.Click += new System.EventHandler(this.btnAddCandidate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Voting_Application_Final.Properties.Resources.Pakistan_Election_Commission_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(487, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // electionListTableAdapter
            // 
            this.electionListTableAdapter.ClearBeforeFill = true;
            // 
            // ResultForm_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 740);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultForm_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultForm_View";
            this.Load += new System.EventHandler(this.ResultForm_View_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electionListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahidDBDataSet5)).EndInit();
            this.adminPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnElectionResult;
        private System.Windows.Forms.Button btnAddNewElection;
        private System.Windows.Forms.Button btnAddCandidate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private ZahidDBDataSet5 zahidDBDataSet5;
        private System.Windows.Forms.BindingSource electionListBindingSource;
        private ZahidDBDataSet5TableAdapters.ElectionListTableAdapter electionListTableAdapter;
    }
}