namespace E_Voting_Application_Final.Views
{
    partial class AllCandidateListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zahidDBDataSet4 = new E_Voting_Application_Final.ZahidDBDataSet4();
            this.candidateList1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidateList1TableAdapter = new E_Voting_Application_Final.ZahidDBDataSet4TableAdapters.CandidateList1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahidDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateList1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1274, 740);
            this.dataGridView1.TabIndex = 0;
            // 
            // zahidDBDataSet4
            // 
            this.zahidDBDataSet4.DataSetName = "ZahidDBDataSet4";
            this.zahidDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidateList1BindingSource
            // 
            this.candidateList1BindingSource.DataMember = "CandidateList1";
            this.candidateList1BindingSource.DataSource = this.zahidDBDataSet4;
            // 
            // candidateList1TableAdapter
            // 
            this.candidateList1TableAdapter.ClearBeforeFill = true;
            // 
            // AllCandidateListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 740);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllCandidateListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllCandidateListForm";
            this.Load += new System.EventHandler(this.AllCandidateListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahidDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateList1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ZahidDBDataSet4 zahidDBDataSet4;
        private System.Windows.Forms.BindingSource candidateList1BindingSource;
        private ZahidDBDataSet4TableAdapters.CandidateList1TableAdapter candidateList1TableAdapter;
    }
}