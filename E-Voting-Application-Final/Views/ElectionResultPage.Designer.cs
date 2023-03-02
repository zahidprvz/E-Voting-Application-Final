namespace E_Voting_Application_Final.Views
{
    partial class ElectionResultPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxElectionId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnElectionResult = new System.Windows.Forms.Button();
            this.btnAddNewElection = new System.Windows.Forms.Button();
            this.btnAddCandidate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxElectionId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(383, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 716);
            this.panel1.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(33, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 95);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(217, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "PartyName";
            // 
            // tbxElectionId
            // 
            this.tbxElectionId.Location = new System.Drawing.Point(322, 108);
            this.tbxElectionId.Name = "tbxElectionId";
            this.tbxElectionId.Size = new System.Drawing.Size(240, 26);
            this.tbxElectionId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(241, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Winner";
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
            this.adminPanel.Location = new System.Drawing.Point(42, 173);
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
            // 
            // ElectionResultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 740);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ElectionResultPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElectionResultPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.adminPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxElectionId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnElectionResult;
        private System.Windows.Forms.Button btnAddNewElection;
        private System.Windows.Forms.Button btnAddCandidate;
    }
}