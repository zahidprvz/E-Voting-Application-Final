namespace E_Voting_Application_Final.Views
{
    partial class AddVoterFormForAdminView
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
            this.tbxCNIC = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGetAllVoters = new System.Windows.Forms.Button();
            this.btnGetVoterById = new System.Windows.Forms.Button();
            this.btnDeleteVoter = new System.Windows.Forms.Button();
            this.btnAddVoter = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            this.txtJobStatus = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxCNIC
            // 
            this.tbxCNIC.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxCNIC.Location = new System.Drawing.Point(731, 592);
            this.tbxCNIC.Name = "tbxCNIC";
            this.tbxCNIC.Size = new System.Drawing.Size(173, 26);
            this.tbxCNIC.TabIndex = 110;
            this.tbxCNIC.Leave += new System.EventHandler(this.tbxCNIC_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(614, 596);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 20);
            this.label18.TabIndex = 109;
            this.label18.Text = "CNIC";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(461, 264);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 24);
            this.checkBox1.TabIndex = 106;
            this.checkBox1.Text = "Yes, 18+";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(171, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(270, 20);
            this.label16.TabIndex = 105;
            this.label16.Text = "To cast vote, Voter must be 18+!";
            // 
            // btnGetAllVoters
            // 
            this.btnGetAllVoters.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetAllVoters.Location = new System.Drawing.Point(961, 663);
            this.btnGetAllVoters.Name = "btnGetAllVoters";
            this.btnGetAllVoters.Size = new System.Drawing.Size(200, 40);
            this.btnGetAllVoters.TabIndex = 103;
            this.btnGetAllVoters.Text = "Get All Voters List";
            this.btnGetAllVoters.UseVisualStyleBackColor = false;
            this.btnGetAllVoters.Click += new System.EventHandler(this.btnGetAllVoters_Click);
            // 
            // btnGetVoterById
            // 
            this.btnGetVoterById.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetVoterById.Location = new System.Drawing.Point(682, 663);
            this.btnGetVoterById.Name = "btnGetVoterById";
            this.btnGetVoterById.Size = new System.Drawing.Size(200, 40);
            this.btnGetVoterById.TabIndex = 102;
            this.btnGetVoterById.Text = "Search by ID";
            this.btnGetVoterById.UseVisualStyleBackColor = false;
            this.btnGetVoterById.Click += new System.EventHandler(this.btnGetVoterById_Click);
            // 
            // btnDeleteVoter
            // 
            this.btnDeleteVoter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteVoter.Location = new System.Drawing.Point(403, 663);
            this.btnDeleteVoter.Name = "btnDeleteVoter";
            this.btnDeleteVoter.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteVoter.TabIndex = 101;
            this.btnDeleteVoter.Text = "Delete Voter by ID";
            this.btnDeleteVoter.UseVisualStyleBackColor = false;
            this.btnDeleteVoter.Click += new System.EventHandler(this.btnDeleteVoter_Click);
            // 
            // btnAddVoter
            // 
            this.btnAddVoter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddVoter.Location = new System.Drawing.Point(124, 663);
            this.btnAddVoter.Name = "btnAddVoter";
            this.btnAddVoter.Size = new System.Drawing.Size(200, 40);
            this.btnAddVoter.TabIndex = 100;
            this.btnAddVoter.Text = "Add Voter";
            this.btnAddVoter.UseVisualStyleBackColor = false;
            this.btnAddVoter.Click += new System.EventHandler(this.btnAddVoter_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtName.Location = new System.Drawing.Point(153, 419);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 26);
            this.txtName.TabIndex = 75;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.SystemColors.Menu;
            this.txtGender.Location = new System.Drawing.Point(410, 593);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(173, 26);
            this.txtGender.TabIndex = 86;
            this.txtGender.Leave += new System.EventHandler(this.txtGender_Leave);
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCity.Location = new System.Drawing.Point(410, 333);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(173, 26);
            this.txtCity.TabIndex = 81;
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMaritalStatus.Location = new System.Drawing.Point(1036, 514);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.Size = new System.Drawing.Size(173, 26);
            this.txtMaritalStatus.TabIndex = 99;
            this.txtMaritalStatus.Text = "Single/Married";
            this.txtMaritalStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMaritalStatus_MouseClick);
            this.txtMaritalStatus.Leave += new System.EventHandler(this.txtMaritalStatus_Leave);
            // 
            // txtJobStatus
            // 
            this.txtJobStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.txtJobStatus.Location = new System.Drawing.Point(1036, 423);
            this.txtJobStatus.Name = "txtJobStatus";
            this.txtJobStatus.Size = new System.Drawing.Size(173, 26);
            this.txtJobStatus.TabIndex = 97;
            this.txtJobStatus.Text = "Student/Employed";
            this.txtJobStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtJobStatus_MouseClick);
            this.txtJobStatus.Leave += new System.EventHandler(this.txtJobStatus_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.Location = new System.Drawing.Point(1036, 333);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 26);
            this.txtEmail.TabIndex = 94;
            this.txtEmail.Text = "abc@gmail.com";
            this.txtEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEmail_MouseClick);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPhone.Location = new System.Drawing.Point(731, 514);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(173, 26);
            this.txtPhone.TabIndex = 92;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCountry.Location = new System.Drawing.Point(731, 423);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(173, 26);
            this.txtCountry.TabIndex = 90;
            this.txtCountry.Leave += new System.EventHandler(this.txtCountry_Leave);
            // 
            // txtNationality
            // 
            this.txtNationality.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNationality.Location = new System.Drawing.Point(731, 333);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(173, 26);
            this.txtNationality.TabIndex = 88;
            this.txtNationality.Leave += new System.EventHandler(this.txtNationality_Leave);
            // 
            // txtReligion
            // 
            this.txtReligion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtReligion.Location = new System.Drawing.Point(410, 511);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(173, 26);
            this.txtReligion.TabIndex = 84;
            this.txtReligion.Leave += new System.EventHandler(this.txtReligion_Leave);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAge.Location = new System.Drawing.Point(153, 510);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(173, 26);
            this.txtAge.TabIndex = 77;
            this.txtAge.Leave += new System.EventHandler(this.txtAge_Leave);
            // 
            // txtDob
            // 
            this.txtDob.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDob.Location = new System.Drawing.Point(410, 418);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(173, 26);
            this.txtDob.TabIndex = 82;
            this.txtDob.Text = "DD/MM/YYYY";
            this.txtDob.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDob_MouseClick);
            this.txtDob.Leave += new System.EventHandler(this.txtDob_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAddress.Location = new System.Drawing.Point(153, 592);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(173, 26);
            this.txtAddress.TabIndex = 79;
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtId.Location = new System.Drawing.Point(153, 332);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(173, 26);
            this.txtId.TabIndex = 73;
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(927, 516);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 98;
            this.label15.Text = "MaritalStatus";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(340, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 20);
            this.label14.TabIndex = 96;
            this.label14.Text = "City";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 513);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 95;
            this.label13.Text = "Age";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(927, 425);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 93;
            this.label12.Text = "jobStatus";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(927, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 91;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(614, 519);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 89;
            this.label10.Text = "phoneNumber";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(614, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 87;
            this.label9.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 85;
            this.label8.Text = "Nationality";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 597);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 83;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "Religion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 595);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "Welcome to PEC Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 111;
            this.label2.Text = "Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Voting_Application_Final.Properties.Resources.Pakistan_Election_Commission_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(487, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Maximum = 15;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 40);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 112;
            // 
            // AddVoterFormForAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 740);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxCNIC);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGetAllVoters);
            this.Controls.Add(this.btnGetVoterById);
            this.Controls.Add(this.btnDeleteVoter);
            this.Controls.Add(this.btnAddVoter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtMaritalStatus);
            this.Controls.Add(this.txtJobStatus);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtReligion);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVoterFormForAdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddVoterFormForAdminView";
            this.Load += new System.EventHandler(this.AddVoterFormForAdminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCNIC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGetAllVoters;
        private System.Windows.Forms.Button btnGetVoterById;
        private System.Windows.Forms.Button btnDeleteVoter;
        private System.Windows.Forms.Button btnAddVoter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtMaritalStatus;
        private System.Windows.Forms.TextBox txtJobStatus;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}