namespace E_Voting_Application_Final.Views
{
    partial class Voter_LoginFormView
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
            this.label3 = new System.Windows.Forms.Label();
            this.registervoterLabel = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Not a registered Voter? ";
            // 
            // registervoterLabel
            // 
            this.registervoterLabel.AutoSize = true;
            this.registervoterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registervoterLabel.Location = new System.Drawing.Point(603, 515);
            this.registervoterLabel.Name = "registervoterLabel";
            this.registervoterLabel.Size = new System.Drawing.Size(69, 20);
            this.registervoterLabel.TabIndex = 20;
            this.registervoterLabel.TabStop = true;
            this.registervoterLabel.Text = "Register";
            this.registervoterLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registervoterLabel_LinkClicked);
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Location = new System.Drawing.Point(568, 412);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(138, 42);
            this.loginBtn.TabIndex = 19;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(487, 352);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(300, 26);
            this.tbxPassword.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password :  ";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(487, 287);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(300, 26);
            this.tbxEmail.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Welcome to Voter CRUD Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Voting_Application_Final.Properties.Resources.Pakistan_Election_Commission_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(487, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Voter_LoginFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 740);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registervoterLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Voter_LoginFormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voter_LoginFormView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel registervoterLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}