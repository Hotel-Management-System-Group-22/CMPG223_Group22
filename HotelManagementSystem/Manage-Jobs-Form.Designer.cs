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
            this.tcjobs = new System.Windows.Forms.TabControl();
            this.tcAddJob = new System.Windows.Forms.TabPage();
            this.tcEditJob = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddJobRate = new System.Windows.Forms.TextBox();
            this.txtAddJobTitle = new System.Windows.Forms.TextBox();
            this.txtAddJobID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditJobRate = new System.Windows.Forms.TextBox();
            this.txtEditJobTitle = new System.Windows.Forms.TextBox();
            this.txtEditJobID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnAcceptNewJob = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobList)).BeginInit();
            this.tcjobs.SuspendLayout();
            this.tcAddJob.SuspendLayout();
            this.tcEditJob.SuspendLayout();
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
            this.btnAddJob.Location = new System.Drawing.Point(656, 421);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(75, 23);
            this.btnAddJob.TabIndex = 8;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            // 
            // btnEditJob
            // 
            this.btnEditJob.Location = new System.Drawing.Point(818, 421);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(75, 23);
            this.btnEditJob.TabIndex = 9;
            this.btnEditJob.Text = "Edit Job";
            this.btnEditJob.UseVisualStyleBackColor = true;
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.Location = new System.Drawing.Point(273, 489);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteJob.TabIndex = 10;
            this.btnDeleteJob.Text = "Delete Job";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            // 
            // tcjobs
            // 
            this.tcjobs.Controls.Add(this.tcAddJob);
            this.tcjobs.Controls.Add(this.tcEditJob);
            this.tcjobs.Location = new System.Drawing.Point(619, 41);
            this.tcjobs.Name = "tcjobs";
            this.tcjobs.SelectedIndex = 0;
            this.tcjobs.Size = new System.Drawing.Size(318, 337);
            this.tcjobs.TabIndex = 11;
            this.tcjobs.SelectedIndexChanged += new System.EventHandler(this.tcjobs_SelectedIndexChanged);
            // 
            // tcAddJob
            // 
            this.tcAddJob.Controls.Add(this.btnAddCancel);
            this.tcAddJob.Controls.Add(this.btnAcceptNewJob);
            this.tcAddJob.Controls.Add(this.label2);
            this.tcAddJob.Controls.Add(this.label3);
            this.tcAddJob.Controls.Add(this.label4);
            this.tcAddJob.Controls.Add(this.txtAddJobRate);
            this.tcAddJob.Controls.Add(this.txtAddJobTitle);
            this.tcAddJob.Controls.Add(this.txtAddJobID);
            this.tcAddJob.Location = new System.Drawing.Point(4, 25);
            this.tcAddJob.Name = "tcAddJob";
            this.tcAddJob.Padding = new System.Windows.Forms.Padding(3);
            this.tcAddJob.Size = new System.Drawing.Size(310, 308);
            this.tcAddJob.TabIndex = 0;
            this.tcAddJob.Text = "Add Job";
            this.tcAddJob.UseVisualStyleBackColor = true;
            // 
            // tcEditJob
            // 
            this.tcEditJob.Controls.Add(this.btnEditCancel);
            this.tcEditJob.Controls.Add(this.btnUpdate);
            this.tcEditJob.Controls.Add(this.label5);
            this.tcEditJob.Controls.Add(this.label6);
            this.tcEditJob.Controls.Add(this.label7);
            this.tcEditJob.Controls.Add(this.txtEditJobRate);
            this.tcEditJob.Controls.Add(this.txtEditJobTitle);
            this.tcEditJob.Controls.Add(this.txtEditJobID);
            this.tcEditJob.Location = new System.Drawing.Point(4, 25);
            this.tcEditJob.Name = "tcEditJob";
            this.tcEditJob.Padding = new System.Windows.Forms.Padding(3);
            this.tcEditJob.Size = new System.Drawing.Size(310, 308);
            this.tcEditJob.TabIndex = 1;
            this.tcEditJob.Text = "Edit Job";
            this.tcEditJob.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search Job:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Job Rate:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Job Title:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Job ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAddJobRate
            // 
            this.txtAddJobRate.Location = new System.Drawing.Point(137, 211);
            this.txtAddJobRate.Name = "txtAddJobRate";
            this.txtAddJobRate.Size = new System.Drawing.Size(100, 22);
            this.txtAddJobRate.TabIndex = 10;
            this.txtAddJobRate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAddJobTitle
            // 
            this.txtAddJobTitle.Location = new System.Drawing.Point(137, 125);
            this.txtAddJobTitle.Name = "txtAddJobTitle";
            this.txtAddJobTitle.Size = new System.Drawing.Size(100, 22);
            this.txtAddJobTitle.TabIndex = 9;
            this.txtAddJobTitle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAddJobID
            // 
            this.txtAddJobID.Location = new System.Drawing.Point(137, 29);
            this.txtAddJobID.Name = "txtAddJobID";
            this.txtAddJobID.Size = new System.Drawing.Size(100, 22);
            this.txtAddJobID.TabIndex = 8;
            this.txtAddJobID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Job Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Job Title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Job ID:";
            // 
            // txtEditJobRate
            // 
            this.txtEditJobRate.Location = new System.Drawing.Point(146, 218);
            this.txtEditJobRate.Name = "txtEditJobRate";
            this.txtEditJobRate.Size = new System.Drawing.Size(100, 22);
            this.txtEditJobRate.TabIndex = 16;
            // 
            // txtEditJobTitle
            // 
            this.txtEditJobTitle.Location = new System.Drawing.Point(146, 132);
            this.txtEditJobTitle.Name = "txtEditJobTitle";
            this.txtEditJobTitle.Size = new System.Drawing.Size(100, 22);
            this.txtEditJobTitle.TabIndex = 15;
            // 
            // txtEditJobID
            // 
            this.txtEditJobID.Location = new System.Drawing.Point(146, 36);
            this.txtEditJobID.Name = "txtEditJobID";
            this.txtEditJobID.Size = new System.Drawing.Size(100, 22);
            this.txtEditJobID.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 267);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Save Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Location = new System.Drawing.Point(195, 267);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditCancel.TabIndex = 20;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // btnAcceptNewJob
            // 
            this.btnAcceptNewJob.Location = new System.Drawing.Point(33, 255);
            this.btnAcceptNewJob.Name = "btnAcceptNewJob";
            this.btnAcceptNewJob.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptNewJob.TabIndex = 14;
            this.btnAcceptNewJob.Text = "Accept";
            this.btnAcceptNewJob.UseVisualStyleBackColor = true;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(195, 255);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancel.TabIndex = 15;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            // 
            // ManageJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcjobs);
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
            this.tcjobs.ResumeLayout(false);
            this.tcAddJob.ResumeLayout(false);
            this.tcAddJob.PerformLayout();
            this.tcEditJob.ResumeLayout(false);
            this.tcEditJob.PerformLayout();
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
        private System.Windows.Forms.TabControl tcjobs;
        private System.Windows.Forms.TabPage tcAddJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddJobRate;
        private System.Windows.Forms.TextBox txtAddJobTitle;
        private System.Windows.Forms.TextBox txtAddJobID;
        private System.Windows.Forms.TabPage tcEditJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditJobRate;
        private System.Windows.Forms.TextBox txtEditJobTitle;
        private System.Windows.Forms.TextBox txtEditJobID;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAcceptNewJob;
    }
}