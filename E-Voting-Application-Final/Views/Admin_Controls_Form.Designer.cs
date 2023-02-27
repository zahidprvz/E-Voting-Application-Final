namespace E_Voting_Application_Final.Views
{
    partial class Admin_Controls_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnElectionResult = new System.Windows.Forms.Button();
            this.btnAddNewElection = new System.Windows.Forms.Button();
            this.btnAddCandidate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxNoOfCandidates = new System.Windows.Forms.TextBox();
            this.tbxElectionType = new System.Windows.Forms.TextBox();
            this.tbxElectionId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clbxCandidate = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.adminPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 25);
            this.label1.TabIndex = 66;
            this.label1.Text = "Welcome to Voter CRUD Application";
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.adminPanel.Controls.Add(this.button1);
            this.adminPanel.Controls.Add(this.btnLogout);
            this.adminPanel.Controls.Add(this.btnElectionResult);
            this.adminPanel.Controls.Add(this.btnAddNewElection);
            this.adminPanel.Controls.Add(this.btnAddCandidate);
            this.adminPanel.Location = new System.Drawing.Point(50, 308);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(300, 400);
            this.adminPanel.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(30, 305);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(240, 50);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnElectionResult
            // 
            this.btnElectionResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnElectionResult.Location = new System.Drawing.Point(30, 240);
            this.btnElectionResult.Name = "btnElectionResult";
            this.btnElectionResult.Size = new System.Drawing.Size(240, 50);
            this.btnElectionResult.TabIndex = 0;
            this.btnElectionResult.Text = "View Election Results";
            this.btnElectionResult.UseVisualStyleBackColor = false;
            this.btnElectionResult.Click += new System.EventHandler(this.btnElectionResult_Click);
            // 
            // btnAddNewElection
            // 
            this.btnAddNewElection.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewElection.Location = new System.Drawing.Point(30, 110);
            this.btnAddNewElection.Name = "btnAddNewElection";
            this.btnAddNewElection.Size = new System.Drawing.Size(240, 50);
            this.btnAddNewElection.TabIndex = 0;
            this.btnAddNewElection.Text = "Add New Election";
            this.btnAddNewElection.UseVisualStyleBackColor = false;
            this.btnAddNewElection.Click += new System.EventHandler(this.btnAddNewElection_Click);
            // 
            // btnAddCandidate
            // 
            this.btnAddCandidate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCandidate.Location = new System.Drawing.Point(30, 45);
            this.btnAddCandidate.Name = "btnAddCandidate";
            this.btnAddCandidate.Size = new System.Drawing.Size(240, 50);
            this.btnAddCandidate.TabIndex = 0;
            this.btnAddCandidate.Text = "Add Candidate";
            this.btnAddCandidate.UseVisualStyleBackColor = false;
            this.btnAddCandidate.Click += new System.EventHandler(this.btnAddCandidate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.clbxCandidate);
            this.panel1.Controls.Add(this.tbxNoOfCandidates);
            this.panel1.Controls.Add(this.tbxElectionType);
            this.panel1.Controls.Add(this.tbxElectionId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(370, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 400);
            this.panel1.TabIndex = 2;
            // 
            // tbxNoOfCandidates
            // 
            this.tbxNoOfCandidates.Location = new System.Drawing.Point(225, 150);
            this.tbxNoOfCandidates.Name = "tbxNoOfCandidates";
            this.tbxNoOfCandidates.Size = new System.Drawing.Size(240, 26);
            this.tbxNoOfCandidates.TabIndex = 2;
            // 
            // tbxElectionType
            // 
            this.tbxElectionType.Location = new System.Drawing.Point(225, 110);
            this.tbxElectionType.Name = "tbxElectionType";
            this.tbxElectionType.Size = new System.Drawing.Size(240, 26);
            this.tbxElectionType.TabIndex = 1;
            // 
            // tbxElectionId
            // 
            this.tbxElectionId.Location = new System.Drawing.Point(225, 68);
            this.tbxElectionId.Name = "tbxElectionId";
            this.tbxElectionId.Size = new System.Drawing.Size(240, 26);
            this.tbxElectionId.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(85, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Participants : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(45, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "No of Candidates : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(73, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Election Type : ";
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
            this.label2.Location = new System.Drawing.Point(265, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add a new Election";
            // 
            // clbxCandidate
            // 
            this.clbxCandidate.FormattingEnabled = true;
            this.clbxCandidate.Location = new System.Drawing.Point(225, 190);
            this.clbxCandidate.Name = "clbxCandidate";
            this.clbxCandidate.Size = new System.Drawing.Size(240, 119);
            this.clbxCandidate.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(225, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(49, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Last Day to Vote : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Voting_Application_Final.Properties.Resources.Pakistan_Election_Commission_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(487, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(30, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show List of All Voters";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_Controls_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin_Controls_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Controls_Form";
            this.Load += new System.EventHandler(this.Admin_Controls_Form_Load);
            this.adminPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnElectionResult;
        private System.Windows.Forms.Button btnAddNewElection;
        private System.Windows.Forms.Button btnAddCandidate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNoOfCandidates;
        private System.Windows.Forms.TextBox tbxElectionType;
        private System.Windows.Forms.TextBox tbxElectionId;
        private System.Windows.Forms.CheckedListBox clbxCandidate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}