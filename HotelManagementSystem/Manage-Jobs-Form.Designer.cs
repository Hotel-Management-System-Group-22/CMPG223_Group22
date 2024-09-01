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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageJobsForm));
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
            this.btnEditJob = new System.Windows.Forms.Button();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.btnEditAccept = new System.Windows.Forms.Button();
            this.txtEditJobTitle = new System.Windows.Forms.TextBox();
            this.txtEditJobRate = new System.Windows.Forms.TextBox();
            this.lblEditRate = new System.Windows.Forms.Label();
            this.txtJobRate = new System.Windows.Forms.TextBox();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabEditJob = new System.Windows.Forms.TabPage();
            this.tabAddJob = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSelectedID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLanguage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobList)).BeginInit();
            this.tabcontrol.SuspendLayout();
            this.tabEditJob.SuspendLayout();
            this.tabAddJob.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJobList
            // 
            this.dgvJobList.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgvJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobList.Location = new System.Drawing.Point(56, 395);
            this.dgvJobList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvJobList.Name = "dgvJobList";
            this.dgvJobList.ReadOnly = true;
            this.dgvJobList.RowHeadersWidth = 51;
            this.dgvJobList.RowTemplate.Height = 24;
            this.dgvJobList.Size = new System.Drawing.Size(1065, 294);
            this.dgvJobList.TabIndex = 1;
            this.dgvJobList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobList_CellClick);
            this.dgvJobList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobList_CellContentClick);
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(159, 42);
            this.txtJobID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(168, 30);
            this.txtJobID.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtJobID, "Enter Job ID");
            this.txtJobID.TextChanged += new System.EventHandler(this.txtJobID_TextChanged);
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(5, 44);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(75, 25);
            this.lblJobID.TabIndex = 5;
            this.lblJobID.Text = "Job ID:";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(5, 81);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(93, 25);
            this.lblJobTitle.TabIndex = 6;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // lblJobRate
            // 
            this.lblJobRate.AutoSize = true;
            this.lblJobRate.Location = new System.Drawing.Point(5, 119);
            this.lblJobRate.Name = "lblJobRate";
            this.lblJobRate.Size = new System.Drawing.Size(96, 25);
            this.lblJobRate.TabIndex = 7;
            this.lblJobRate.Text = "Job Rate:";
            // 
            // btnDeleteJob
            // 
            this.btnDeleteJob.Location = new System.Drawing.Point(19, 132);
            this.btnDeleteJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(215, 41);
            this.btnDeleteJob.TabIndex = 10;
            this.btnDeleteJob.Text = "Delete Job";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            this.btnDeleteJob.Click += new System.EventHandler(this.btnDeleteJob_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(173, 162);
            this.btnAddCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(109, 41);
            this.btnAddCancel.TabIndex = 15;
            this.btnAddCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnAddCancel, "Click to Cancel");
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click_1);
            // 
            // btnAcceptNewJob
            // 
            this.btnAcceptNewJob.Location = new System.Drawing.Point(25, 164);
            this.btnAcceptNewJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAcceptNewJob.Name = "btnAcceptNewJob";
            this.btnAcceptNewJob.Size = new System.Drawing.Size(109, 41);
            this.btnAcceptNewJob.TabIndex = 14;
            this.btnAcceptNewJob.Text = "Add";
            this.toolTip1.SetToolTip(this.btnAcceptNewJob, "Click to add job");
            this.btnAcceptNewJob.UseVisualStyleBackColor = true;
            this.btnAcceptNewJob.Click += new System.EventHandler(this.btnAcceptNewJob_Click);
            // 
            // lblAddRate
            // 
            this.lblAddRate.AutoSize = true;
            this.lblAddRate.Location = new System.Drawing.Point(5, 71);
            this.lblAddRate.Name = "lblAddRate";
            this.lblAddRate.Size = new System.Drawing.Size(96, 25);
            this.lblAddRate.TabIndex = 13;
            this.lblAddRate.Text = "Job Rate:";
            this.lblAddRate.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Location = new System.Drawing.Point(5, 25);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(93, 25);
            this.lblAddTitle.TabIndex = 12;
            this.lblAddTitle.Text = "Job Title:";
            this.lblAddTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAddJobRate
            // 
            this.txtAddJobRate.Location = new System.Drawing.Point(173, 68);
            this.txtAddJobRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddJobRate.Name = "txtAddJobRate";
            this.txtAddJobRate.Size = new System.Drawing.Size(148, 30);
            this.txtAddJobRate.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtAddJobRate, "Enter Job Rate");
            this.txtAddJobRate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtAddJobRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddJobRate_Validating);
            // 
            // txtAddJobTitle
            // 
            this.txtAddJobTitle.Location = new System.Drawing.Point(173, 25);
            this.txtAddJobTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddJobTitle.Name = "txtAddJobTitle";
            this.txtAddJobTitle.Size = new System.Drawing.Size(148, 30);
            this.txtAddJobTitle.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtAddJobTitle, "Enter Job Title");
            this.txtAddJobTitle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnEditJob
            // 
            this.btnEditJob.Location = new System.Drawing.Point(19, 81);
            this.btnEditJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(215, 41);
            this.btnEditJob.TabIndex = 15;
            this.btnEditJob.Text = "Update Job";
            this.btnEditJob.UseVisualStyleBackColor = true;
            this.btnEditJob.Click += new System.EventHandler(this.btnEditJob_Click);
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(19, 30);
            this.btnAddJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(215, 41);
            this.btnAddJob.TabIndex = 14;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click_1);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Location = new System.Drawing.Point(171, 156);
            this.btnEditCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(101, 41);
            this.btnEditCancel.TabIndex = 15;
            this.btnEditCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnEditCancel, "Click to Cancel");
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Location = new System.Drawing.Point(3, 35);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(93, 25);
            this.lblEditTitle.TabIndex = 12;
            this.lblEditTitle.Text = "Job Title:";
            // 
            // btnEditAccept
            // 
            this.btnEditAccept.Location = new System.Drawing.Point(27, 156);
            this.btnEditAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditAccept.Name = "btnEditAccept";
            this.btnEditAccept.Size = new System.Drawing.Size(101, 41);
            this.btnEditAccept.TabIndex = 14;
            this.btnEditAccept.Text = "Update";
            this.toolTip1.SetToolTip(this.btnEditAccept, "Click to Update Job Details");
            this.btnEditAccept.UseVisualStyleBackColor = true;
            this.btnEditAccept.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtEditJobTitle
            // 
            this.txtEditJobTitle.Location = new System.Drawing.Point(171, 21);
            this.txtEditJobTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditJobTitle.Name = "txtEditJobTitle";
            this.txtEditJobTitle.Size = new System.Drawing.Size(160, 30);
            this.txtEditJobTitle.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtEditJobTitle, "Enter Job Title");
            this.txtEditJobTitle.TextChanged += new System.EventHandler(this.txtEditJobTitle_TextChanged);
            // 
            // txtEditJobRate
            // 
            this.txtEditJobRate.Location = new System.Drawing.Point(171, 64);
            this.txtEditJobRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditJobRate.Name = "txtEditJobRate";
            this.txtEditJobRate.Size = new System.Drawing.Size(160, 30);
            this.txtEditJobRate.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtEditJobRate, "Enter Job Rate");
            this.txtEditJobRate.TextChanged += new System.EventHandler(this.txtEditJobRate_TextChanged);
            this.txtEditJobRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditJobRate_Validating);
            // 
            // lblEditRate
            // 
            this.lblEditRate.AutoSize = true;
            this.lblEditRate.Location = new System.Drawing.Point(3, 71);
            this.lblEditRate.Name = "lblEditRate";
            this.lblEditRate.Size = new System.Drawing.Size(96, 25);
            this.lblEditRate.TabIndex = 13;
            this.lblEditRate.Text = "Job Rate:";
            // 
            // txtJobRate
            // 
            this.txtJobRate.Location = new System.Drawing.Point(159, 114);
            this.txtJobRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJobRate.Name = "txtJobRate";
            this.txtJobRate.Size = new System.Drawing.Size(168, 30);
            this.txtJobRate.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtJobRate, "Enter Job rate");
            this.txtJobRate.TextChanged += new System.EventHandler(this.txtJobRate_TextChanged);
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(159, 78);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(168, 30);
            this.txtJobTitle.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtJobTitle, "Enter Job Title");
            this.txtJobTitle.TextChanged += new System.EventHandler(this.txtJobTitle_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(19, 190);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(215, 41);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabEditJob);
            this.tabcontrol.Controls.Add(this.tabAddJob);
            this.tabcontrol.Location = new System.Drawing.Point(344, 134);
            this.tabcontrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(381, 242);
            this.tabcontrol.TabIndex = 20;
            // 
            // tabEditJob
            // 
            this.tabEditJob.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabEditJob.Controls.Add(this.btnEditCancel);
            this.tabEditJob.Controls.Add(this.txtEditJobTitle);
            this.tabEditJob.Controls.Add(this.lblEditTitle);
            this.tabEditJob.Controls.Add(this.lblEditRate);
            this.tabEditJob.Controls.Add(this.btnEditAccept);
            this.tabEditJob.Controls.Add(this.txtEditJobRate);
            this.tabEditJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEditJob.Location = new System.Drawing.Point(4, 25);
            this.tabEditJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEditJob.Name = "tabEditJob";
            this.tabEditJob.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEditJob.Size = new System.Drawing.Size(373, 213);
            this.tabEditJob.TabIndex = 0;
            this.tabEditJob.Text = "Edit Job Info";
            this.tabEditJob.Click += new System.EventHandler(this.tabEditJob_Click);
            // 
            // tabAddJob
            // 
            this.tabAddJob.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabAddJob.Controls.Add(this.btnAddCancel);
            this.tabAddJob.Controls.Add(this.lblAddTitle);
            this.tabAddJob.Controls.Add(this.lblAddRate);
            this.tabAddJob.Controls.Add(this.btnAcceptNewJob);
            this.tabAddJob.Controls.Add(this.txtAddJobRate);
            this.tabAddJob.Controls.Add(this.txtAddJobTitle);
            this.tabAddJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddJob.Location = new System.Drawing.Point(4, 25);
            this.tabAddJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAddJob.Name = "tabAddJob";
            this.tabAddJob.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAddJob.Size = new System.Drawing.Size(373, 213);
            this.tabAddJob.TabIndex = 1;
            this.tabAddJob.Text = "Add Job Info";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.btnAddJob);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnEditJob);
            this.groupBox1.Controls.Add(this.btnDeleteJob);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(265, 242);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1176, 726);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.lblSelectedID);
            this.groupBox2.Controls.Add(this.txtJobID);
            this.groupBox2.Controls.Add(this.lblJobID);
            this.groupBox2.Controls.Add(this.lblJobTitle);
            this.groupBox2.Controls.Add(this.txtJobTitle);
            this.groupBox2.Controls.Add(this.lblJobRate);
            this.groupBox2.Controls.Add(this.txtJobRate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(752, 138);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(369, 239);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Job";
            // 
            // lblSelectedID
            // 
            this.lblSelectedID.AutoSize = true;
            this.lblSelectedID.Location = new System.Drawing.Point(5, 166);
            this.lblSelectedID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedID.Name = "lblSelectedID";
            this.lblSelectedID.Size = new System.Drawing.Size(124, 25);
            this.lblSelectedID.TabIndex = 8;
            this.lblSelectedID.Text = "Selected ID: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Location = new System.Drawing.Point(348, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 30);
            this.panel1.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(75, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(940, 57);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(181, 57);
            this.btnLanguage.TabIndex = 27;
            this.btnLanguage.Text = "Afrikaans";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // ManageJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 722);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabcontrol);
            this.Controls.Add(this.dgvJobList);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtJobRate;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabEditJob;
        private System.Windows.Forms.TabPage tabAddJob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelectedID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLanguage;
    }
}