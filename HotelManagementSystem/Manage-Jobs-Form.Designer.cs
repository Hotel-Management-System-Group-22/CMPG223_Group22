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
            this.dgvJobList = new System.Windows.Forms.DataGridView();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.lblJobID = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblJobRate = new System.Windows.Forms.Label();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAcceptNewJob = new System.Windows.Forms.Button();
            this.lblAddRate = new System.Windows.Forms.Label();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.txtAddJobRate = new System.Windows.Forms.TextBox();
            this.txtAddJobTitle = new System.Windows.Forms.TextBox();
            this.lblSearchJob = new System.Windows.Forms.Label();
            this.btnEditJob = new System.Windows.Forms.Button();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.btnEditAccept = new System.Windows.Forms.Button();
            this.txtEditJobTitle = new System.Windows.Forms.TextBox();
            this.txtEditJobRate = new System.Windows.Forms.TextBox();
            this.lblEditRate = new System.Windows.Forms.Label();
            this.lblSelectedID = new System.Windows.Forms.Label();
            this.txtJobRate = new System.Windows.Forms.TextBox();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabEditJob = new System.Windows.Forms.TabPage();
            this.tabAddJob = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelectRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobList)).BeginInit();
            this.tabcontrol.SuspendLayout();
            this.tabEditJob.SuspendLayout();
            this.tabAddJob.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJobList
            // 
            this.dgvJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobList.Location = new System.Drawing.Point(57, 84);
            this.dgvJobList.Name = "dgvJobList";
            this.dgvJobList.ReadOnly = true;
            this.dgvJobList.RowHeadersWidth = 51;
            this.dgvJobList.RowTemplate.Height = 24;
            this.dgvJobList.Size = new System.Drawing.Size(532, 294);
            this.dgvJobList.TabIndex = 1;
            this.dgvJobList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobList_CellClick);
            this.dgvJobList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobList_CellContentClick);
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(161, 462);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(100, 22);
            this.txtJobID.TabIndex = 2;
            this.txtJobID.TextChanged += new System.EventHandler(this.txtJobID_TextChanged);
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(190, 443);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(49, 16);
            this.lblJobID.TabIndex = 5;
            this.lblJobID.Text = "Job ID:";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(312, 443);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(62, 16);
            this.lblJobTitle.TabIndex = 6;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // lblJobRate
            // 
            this.lblJobRate.AutoSize = true;
            this.lblJobRate.Location = new System.Drawing.Point(440, 443);
            this.lblJobRate.Name = "lblJobRate";
            this.lblJobRate.Size = new System.Drawing.Size(65, 16);
            this.lblJobRate.TabIndex = 7;
            this.lblJobRate.Text = "Job Rate:";
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.Location = new System.Drawing.Point(164, 35);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(174, 36);
            this.btnDeleteJob.TabIndex = 10;
            this.btnDeleteJob.Text = "Delete Selected Job";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            this.btnDeleteJob.Click += new System.EventHandler(this.btnDeleteJob_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(153, 173);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancel.TabIndex = 15;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click_1);
            // 
            // btnAcceptNewJob
            // 
            this.btnAcceptNewJob.Location = new System.Drawing.Point(24, 173);
            this.btnAcceptNewJob.Name = "btnAcceptNewJob";
            this.btnAcceptNewJob.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptNewJob.TabIndex = 14;
            this.btnAcceptNewJob.Text = "Accept";
            this.btnAcceptNewJob.UseVisualStyleBackColor = true;
            this.btnAcceptNewJob.Click += new System.EventHandler(this.btnAcceptNewJob_Click);
            // 
            // lblAddRate
            // 
            this.lblAddRate.AutoSize = true;
            this.lblAddRate.Location = new System.Drawing.Point(21, 87);
            this.lblAddRate.Name = "lblAddRate";
            this.lblAddRate.Size = new System.Drawing.Size(65, 16);
            this.lblAddRate.TabIndex = 13;
            this.lblAddRate.Text = "Job Rate:";
            this.lblAddRate.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Location = new System.Drawing.Point(21, 46);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(62, 16);
            this.lblAddTitle.TabIndex = 12;
            this.lblAddTitle.Text = "Job Title:";
            this.lblAddTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAddJobRate
            // 
            this.txtAddJobRate.Location = new System.Drawing.Point(112, 84);
            this.txtAddJobRate.Name = "txtAddJobRate";
            this.txtAddJobRate.Size = new System.Drawing.Size(100, 22);
            this.txtAddJobRate.TabIndex = 10;
            this.txtAddJobRate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtAddJobRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddJobRate_Validating);
            // 
            // txtAddJobTitle
            // 
            this.txtAddJobTitle.Location = new System.Drawing.Point(112, 43);
            this.txtAddJobTitle.Name = "txtAddJobTitle";
            this.txtAddJobTitle.Size = new System.Drawing.Size(100, 22);
            this.txtAddJobTitle.TabIndex = 9;
            this.txtAddJobTitle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblSearchJob
            // 
            this.lblSearchJob.AutoSize = true;
            this.lblSearchJob.Location = new System.Drawing.Point(45, 467);
            this.lblSearchJob.Name = "lblSearchJob";
            this.lblSearchJob.Size = new System.Drawing.Size(79, 16);
            this.lblSearchJob.TabIndex = 12;
            this.lblSearchJob.Text = "Search Job:";
            // 
            // btnEditJob
            // 
            this.btnEditJob.Location = new System.Drawing.Point(18, 77);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(124, 41);
            this.btnEditJob.TabIndex = 15;
            this.btnEditJob.Text = "Edit Job";
            this.btnEditJob.UseVisualStyleBackColor = true;
            this.btnEditJob.Click += new System.EventHandler(this.btnEditJob_Click);
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(18, 35);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(124, 36);
            this.btnAddJob.TabIndex = 14;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click_1);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Location = new System.Drawing.Point(153, 173);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditCancel.TabIndex = 15;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Location = new System.Drawing.Point(21, 46);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(62, 16);
            this.lblEditTitle.TabIndex = 12;
            this.lblEditTitle.Text = "Job Title:";
            // 
            // btnEditAccept
            // 
            this.btnEditAccept.Location = new System.Drawing.Point(24, 173);
            this.btnEditAccept.Name = "btnEditAccept";
            this.btnEditAccept.Size = new System.Drawing.Size(75, 23);
            this.btnEditAccept.TabIndex = 14;
            this.btnEditAccept.Text = "Accept";
            this.btnEditAccept.UseVisualStyleBackColor = true;
            this.btnEditAccept.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtEditJobTitle
            // 
            this.txtEditJobTitle.Location = new System.Drawing.Point(112, 43);
            this.txtEditJobTitle.Name = "txtEditJobTitle";
            this.txtEditJobTitle.Size = new System.Drawing.Size(100, 22);
            this.txtEditJobTitle.TabIndex = 9;
            this.txtEditJobTitle.TextChanged += new System.EventHandler(this.txtEditJobTitle_TextChanged);
            // 
            // txtEditJobRate
            // 
            this.txtEditJobRate.Location = new System.Drawing.Point(112, 84);
            this.txtEditJobRate.Name = "txtEditJobRate";
            this.txtEditJobRate.Size = new System.Drawing.Size(100, 22);
            this.txtEditJobRate.TabIndex = 10;
            this.txtEditJobRate.TextChanged += new System.EventHandler(this.txtEditJobRate_TextChanged);
            this.txtEditJobRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditJobRate_Validating);
            // 
            // lblEditRate
            // 
            this.lblEditRate.AutoSize = true;
            this.lblEditRate.Location = new System.Drawing.Point(21, 87);
            this.lblEditRate.Name = "lblEditRate";
            this.lblEditRate.Size = new System.Drawing.Size(65, 16);
            this.lblEditRate.TabIndex = 13;
            this.lblEditRate.Text = "Job Rate:";
            // 
            // lblSelectedID
            // 
            this.lblSelectedID.AutoSize = true;
            this.lblSelectedID.Location = new System.Drawing.Point(641, 380);
            this.lblSelectedID.Name = "lblSelectedID";
            this.lblSelectedID.Size = new System.Drawing.Size(93, 16);
            this.lblSelectedID.TabIndex = 18;
            this.lblSelectedID.Text = "Selected Job: ";
            this.lblSelectedID.Click += new System.EventHandler(this.lblSelectedID_Click);
            // 
            // txtJobRate
            // 
            this.txtJobRate.Location = new System.Drawing.Point(427, 462);
            this.txtJobRate.Name = "txtJobRate";
            this.txtJobRate.Size = new System.Drawing.Size(100, 22);
            this.txtJobRate.TabIndex = 4;
            this.txtJobRate.TextChanged += new System.EventHandler(this.txtJobRate_TextChanged);
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(292, 462);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(100, 22);
            this.txtJobTitle.TabIndex = 3;
            this.txtJobTitle.TextChanged += new System.EventHandler(this.txtJobTitle_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(164, 77);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(174, 41);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabEditJob);
            this.tabcontrol.Controls.Add(this.tabAddJob);
            this.tabcontrol.Location = new System.Drawing.Point(637, 84);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(269, 282);
            this.tabcontrol.TabIndex = 20;
            // 
            // tabEditJob
            // 
            this.tabEditJob.Controls.Add(this.btnEditCancel);
            this.tabEditJob.Controls.Add(this.txtEditJobTitle);
            this.tabEditJob.Controls.Add(this.lblEditTitle);
            this.tabEditJob.Controls.Add(this.lblEditRate);
            this.tabEditJob.Controls.Add(this.btnEditAccept);
            this.tabEditJob.Controls.Add(this.txtEditJobRate);
            this.tabEditJob.Location = new System.Drawing.Point(4, 25);
            this.tabEditJob.Name = "tabEditJob";
            this.tabEditJob.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditJob.Size = new System.Drawing.Size(261, 253);
            this.tabEditJob.TabIndex = 0;
            this.tabEditJob.Text = "Edit Job Info";
            this.tabEditJob.UseVisualStyleBackColor = true;
            this.tabEditJob.Click += new System.EventHandler(this.tabEditJob_Click);
            // 
            // tabAddJob
            // 
            this.tabAddJob.Controls.Add(this.btnAddCancel);
            this.tabAddJob.Controls.Add(this.lblAddTitle);
            this.tabAddJob.Controls.Add(this.lblAddRate);
            this.tabAddJob.Controls.Add(this.btnAcceptNewJob);
            this.tabAddJob.Controls.Add(this.txtAddJobRate);
            this.tabAddJob.Controls.Add(this.txtAddJobTitle);
            this.tabAddJob.Location = new System.Drawing.Point(4, 25);
            this.tabAddJob.Name = "tabAddJob";
            this.tabAddJob.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddJob.Size = new System.Drawing.Size(261, 253);
            this.tabAddJob.TabIndex = 1;
            this.tabAddJob.Text = "Add Job Info";
            this.tabAddJob.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddJob);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnEditJob);
            this.groupBox1.Controls.Add(this.btnDeleteJob);
            this.groupBox1.Location = new System.Drawing.Point(568, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 124);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
            // 
            // lblSelectRecords
            // 
            this.lblSelectRecords.AutoSize = true;
            this.lblSelectRecords.Location = new System.Drawing.Point(75, 62);
            this.lblSelectRecords.Name = "lblSelectRecords";
            this.lblSelectRecords.Size = new System.Drawing.Size(142, 16);
            this.lblSelectRecords.TabIndex = 22;
            this.lblSelectRecords.Text = "Select Records below:";
            // 
            // ManageJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 544);
            this.Controls.Add(this.lblSelectRecords);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabcontrol);
            this.Controls.Add(this.lblSelectedID);
            this.Controls.Add(this.lblSearchJob);
            this.Controls.Add(this.lblJobRate);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.txtJobRate);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.dgvJobList);
            this.Name = "ManageJobsForm";
            this.Text = "Manage Jobs";
            this.Load += new System.EventHandler(this.ManageJobsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobList)).EndInit();
            this.tabcontrol.ResumeLayout(false);
            this.tabEditJob.ResumeLayout(false);
            this.tabEditJob.PerformLayout();
            this.tabAddJob.ResumeLayout(false);
            this.tabAddJob.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvJobList;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblJobRate;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Label lblAddRate;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.TextBox txtAddJobRate;
        private System.Windows.Forms.TextBox txtAddJobTitle;
        private System.Windows.Forms.Label lblSearchJob;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAcceptNewJob;
        private System.Windows.Forms.Button btnEditJob;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.Button btnEditAccept;
        private System.Windows.Forms.TextBox txtEditJobTitle;
        private System.Windows.Forms.TextBox txtEditJobRate;
        private System.Windows.Forms.Label lblEditRate;
        private System.Windows.Forms.Label lblSelectedID;
        private System.Windows.Forms.TextBox txtJobRate;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabEditJob;
        private System.Windows.Forms.TabPage tabAddJob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSelectRecords;
    }
}