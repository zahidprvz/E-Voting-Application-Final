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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxElectionId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnElectionResult = new System.Windows.Forms.Button();
            this.btnAddNewElection = new System.Windows.Forms.Button();
            this.btnAddCandidate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tbxElectionId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(370, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 400);
            this.panel1.TabIndex = 69;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(270, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tbxElectionId
            // 
            this.tbxElectionId.Location = new System.Drawing.Point(225, 68);
            this.tbxElectionId.Name = "tbxElectionId";
            this.tbxElectionId.Size = new System.Drawing.Size(240, 26);
            this.tbxElectionId.TabIndex = 0;
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
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Calculation of Votes";
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.adminPanel.Controls.Add(this.btnLogout);
            this.adminPanel.Controls.Add(this.btnElectionResult);
            this.adminPanel.Controls.Add(this.btnAddNewElection);
            this.adminPanel.Controls.Add(this.btnAddCandidate);
            this.adminPanel.Location = new System.Drawing.Point(50, 308);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(300, 400);
            this.adminPanel.TabIndex = 68;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(30, 282);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(240, 50);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnElectionResult
            // 
            this.btnElectionResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnElectionResult.Location = new System.Drawing.Point(30, 214);
            this.btnElectionResult.Name = "btnElectionResult";
            this.btnElectionResult.Size = new System.Drawing.Size(240, 50);
            this.btnElectionResult.TabIndex = 0;
            this.btnElectionResult.Text = "View Election Results";
            this.btnElectionResult.UseVisualStyleBackColor = false;
            // 
            // btnAddNewElection
            // 
            this.btnAddNewElection.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewElection.Location = new System.Drawing.Point(30, 144);
            this.btnAddNewElection.Name = "btnAddNewElection";
            this.btnAddNewElection.Size = new System.Drawing.Size(240, 50);
            this.btnAddNewElection.TabIndex = 0;
            this.btnAddNewElection.Text = "Add New Election";
            this.btnAddNewElection.UseVisualStyleBackColor = false;
            // 
            // btnAddCandidate
            // 
            this.btnAddCandidate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCandidate.Location = new System.Drawing.Point(30, 68);
            this.btnAddCandidate.Name = "btnAddCandidate";
            this.btnAddCandidate.Size = new System.Drawing.Size(240, 50);
            this.btnAddCandidate.TabIndex = 0;
            this.btnAddCandidate.Text = "Add Candidate";
            this.btnAddCandidate.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "Welcome to Voter CRUD Application";
            // 
            // ResultForm_View
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
            this.Name = "ResultForm_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultForm_View";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbxElectionId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnElectionResult;
        private System.Windows.Forms.Button btnAddNewElection;
        private System.Windows.Forms.Button btnAddCandidate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}