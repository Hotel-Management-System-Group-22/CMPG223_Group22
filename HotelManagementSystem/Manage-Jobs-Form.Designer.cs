namespace HotelManagementSystem
{
    partial class ManageJobsForm
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
            this.PanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvJobList = new System.Windows.Forms.DataGridView();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.txtJobRate = new System.Windows.Forms.TextBox();
            this.lblJobID = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblJobRate = new System.Windows.Forms.Label();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.btnEditJob = new System.Windows.Forms.Button();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelMain);
            this.panel1.Location = new System.Drawing.Point(26, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // PanelMain
            // 
            this.PanelMain.Location = new System.Drawing.Point(-24, -40);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(939, 531);
            this.PanelMain.TabIndex = 0;
            // 
            // dgvJobList
            // 
            this.dgvJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobList.Location = new System.Drawing.Point(73, 84);
            this.dgvJobList.Name = "dgvJobList";
            this.dgvJobList.RowHeadersWidth = 51;
            this.dgvJobList.RowTemplate.Height = 24;
            this.dgvJobList.Size = new System.Drawing.Size(532, 294);
            this.dgvJobList.TabIndex = 1;
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(142, 423);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(100, 22);
            this.txtJobID.TabIndex = 2;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(273, 423);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(100, 22);
            this.txtJobTitle.TabIndex = 3;
            // 
            // txtJobRate
            // 
            this.txtJobRate.Location = new System.Drawing.Point(408, 423);
            this.txtJobRate.Name = "txtJobRate";
            this.txtJobRate.Size = new System.Drawing.Size(100, 22);
            this.txtJobRate.TabIndex = 4;
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(171, 404);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(49, 16);
            this.lblJobID.TabIndex = 5;
            this.lblJobID.Text = "Job ID:";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(293, 404);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(62, 16);
            this.lblJobTitle.TabIndex = 6;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // lblJobRate
            // 
            this.lblJobRate.AutoSize = true;
            this.lblJobRate.Location = new System.Drawing.Point(421, 404);
            this.lblJobRate.Name = "lblJobRate";
            this.lblJobRate.Size = new System.Drawing.Size(65, 16);
            this.lblJobRate.TabIndex = 7;
            this.lblJobRate.Text = "Job Rate:";
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(654, 131);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(75, 23);
            this.btnAddJob.TabIndex = 8;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            // 
            // btnEditJob
            // 
            this.btnEditJob.Location = new System.Drawing.Point(654, 222);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(75, 23);
            this.btnEditJob.TabIndex = 9;
            this.btnEditJob.Text = "Edit Job";
            this.btnEditJob.UseVisualStyleBackColor = true;
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.Location = new System.Drawing.Point(654, 312);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteJob.TabIndex = 10;
            this.btnDeleteJob.Text = "Delete Job";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            // 
            // ManageJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 544);
            this.Controls.Add(this.btnDeleteJob);
            this.Controls.Add(this.btnEditJob);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.lblJobRate);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.txtJobRate);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.dgvJobList);
            this.Controls.Add(this.panel1);
            this.Name = "ManageJobsForm";
            this.Text = "Manage Jobs";
            this.Load += new System.EventHandler(this.ManageJobsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel PanelMain;
        private System.Windows.Forms.DataGridView dgvJobList;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.TextBox txtJobRate;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblJobRate;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Button btnEditJob;
        private System.Windows.Forms.Button btnDeleteJob;
    }
}