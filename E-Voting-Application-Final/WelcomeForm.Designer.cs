namespace E_Voting_Application_Final
{
    partial class welcomeForm
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
            this.entitiesCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // entitiesCbx
            // 
            this.entitiesCbx.BackColor = System.Drawing.SystemColors.Menu;
            this.entitiesCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entitiesCbx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.entitiesCbx.FormattingEnabled = true;
            this.entitiesCbx.Items.AddRange(new object[] {
            "Admin",
            "Voter"});
            this.entitiesCbx.Location = new System.Drawing.Point(490, 356);
            this.entitiesCbx.MaxDropDownItems = 2;
            this.entitiesCbx.Name = "entitiesCbx";
            this.entitiesCbx.Size = new System.Drawing.Size(300, 28);
            this.entitiesCbx.TabIndex = 6;
            this.entitiesCbx.Text = "--Choose from below options--";
            this.entitiesCbx.SelectedIndexChanged += new System.EventHandler(this.entitiesCbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Are you an Admin or a Voter?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::E_Voting_Application_Final.Properties.Resources.Pakistan_Election_Commission_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(487, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Welcome to Voter CRUD Application";
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 740);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entitiesCbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "welcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox entitiesCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

