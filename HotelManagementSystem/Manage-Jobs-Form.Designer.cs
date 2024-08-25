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
            this.lblJobID = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblJobRate = new System.Windows.Forms.Label();
            this.btnDeleteJob = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAcceptNewJob = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddJobRate = new System.Windows.Forms.TextBox();
            this.txtAddJobTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditJob = new System.Windows.Forms.Button();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEditJobTitle = new System.Windows.Forms.TextBox();
            this.txtEditJobRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSelectedID = new System.Windows.Forms.Label();
            this.txtJobRate = new System.Windows.Forms.TextBox();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.dgvJobList.ReadOnly = true;
            this.dgvJobList.RowHeadersWidth = 51;
            this.dgvJobList.RowTemplate.Height = 24;
            this.dgvJobList.Size = new System.Drawing.Size(532, 294);
            this.dgvJobList.TabIndex = 1;
            this.dgvJobList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobList_CellContentClick);
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(142, 423);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(100, 22);
            this.txtJobID.TabIndex = 2;
            this.txtJobID.TextChanged += new System.EventHandler(this.txtJobID_TextChanged);
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
            // btnDeleteJob
            // 
            this.btnDeleteJob.Location = new System.Drawing.Point(142, 485);
            this.btnDeleteJob.Name = "btnDeleteJob";
            this.btnDeleteJob.Size = new System.Drawing.Size(154, 23);
            this.btnDeleteJob.TabIndex = 10;
            this.btnDeleteJob.Text = "Delete Selected Job";
            this.btnDeleteJob.UseVisualStyleBackColor = true;
            this.btnDeleteJob.Click += new System.EventHandler(this.btnDeleteJob_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(135, 181);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancel.TabIndex = 15;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click_1);
            // 
            // btnAcceptNewJob
            // 
            this.btnAcceptNewJob.Location = new System.Drawing.Point(23, 181);
            this.btnAcceptNewJob.Name = "btnAcceptNewJob";
            this.btnAcceptNewJob.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptNewJob.TabIndex = 14;
            this.btnAcceptNewJob.Text = "Accept";
            this.btnAcceptNewJob.UseVisualStyleBackColor = true;
            this.btnAcceptNewJob.Click += new System.EventHandler(this.btnAcceptNewJob_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Job Rate:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Job Title:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAddJobRate
            // 
            this.txtAddJobRate.Location = new System.Drawing.Point(88, 94);
            this.txtAddJobRate.Name = "txtAddJobRate";
            this.txtAddJobRate.Size = new System.Drawing.Size(100, 22);
            this.txtAddJobRate.TabIndex = 10;
            this.txtAddJobRate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtAddJobRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddJobRate_Validating);
            // 
            // txtAddJobTitle
            // 
            this.txtAddJobTitle.Location = new System.Drawing.Point(88, 53);
            this.txtAddJobTitle.Name = "txtAddJobTitle";
            this.txtAddJobTitle.Size = new System.Drawing.Size(100, 22);
            this.txtAddJobTitle.TabIndex = 9;
            this.txtAddJobTitle.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // btnEditJob
            // 
            this.btnEditJob.Location = new System.Drawing.Point(351, 485);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(157, 23);
            this.btnEditJob.TabIndex = 15;
            this.btnEditJob.Text = "Edit Selected Job";
            this.btnEditJob.UseVisualStyleBackColor = true;
            this.btnEditJob.Click += new System.EventHandler(this.btnEditJob_Click);
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(741, 485);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(75, 23);
            this.btnAddJob.TabIndex = 14;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddCancel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAcceptNewJob);
            this.groupBox1.Controls.Add(this.txtAddJobTitle);
            this.groupBox1.Controls.Add(this.txtAddJobRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(653, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 250);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Job Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtEditJobTitle);
            this.groupBox2.Controls.Add(this.txtEditJobRate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(653, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 250);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Job Info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Job Title:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Accept";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtEditJobTitle
            // 
            this.txtEditJobTitle.Location = new System.Drawing.Point(90, 53);
            this.txtEditJobTitle.Name = "txtEditJobTitle";
            this.txtEditJobTitle.Size = new System.Drawing.Size(100, 22);
            this.txtEditJobTitle.TabIndex = 9;
            this.txtEditJobTitle.TextChanged += new System.EventHandler(this.txtEditJobTitle_TextChanged);
            // 
            // txtEditJobRate
            // 
            this.txtEditJobRate.Location = new System.Drawing.Point(90, 94);
            this.txtEditJobRate.Name = "txtEditJobRate";
            this.txtEditJobRate.Size = new System.Drawing.Size(100, 22);
            this.txtEditJobRate.TabIndex = 10;
            this.txtEditJobRate.TextChanged += new System.EventHandler(this.txtEditJobRate_TextChanged);
            this.txtEditJobRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditJobRate_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Job Rate:";
            // 
            // lblSelectedID
            // 
            this.lblSelectedID.AutoSize = true;
            this.lblSelectedID.Location = new System.Drawing.Point(658, 339);
            this.lblSelectedID.Name = "lblSelectedID";
            this.lblSelectedID.Size = new System.Drawing.Size(93, 16);
            this.lblSelectedID.TabIndex = 18;
            this.lblSelectedID.Text = "Selected Job: ";
            // 
            // txtJobRate
            // 
            this.txtJobRate.Location = new System.Drawing.Point(408, 423);
            this.txtJobRate.Name = "txtJobRate";
            this.txtJobRate.Size = new System.Drawing.Size(100, 22);
            this.txtJobRate.TabIndex = 4;
            this.txtJobRate.TextChanged += new System.EventHandler(this.txtJobRate_TextChanged);
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(273, 423);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(100, 22);
            this.txtJobTitle.TabIndex = 3;
            this.txtJobTitle.TextChanged += new System.EventHandler(this.txtJobTitle_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(845, 485);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ManageJobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 544);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSelectedID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEditJob);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteJob);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel PanelMain;
        private System.Windows.Forms.DataGridView dgvJobList;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblJobRate;
        private System.Windows.Forms.Button btnDeleteJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddJobRate;
        private System.Windows.Forms.TextBox txtAddJobTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAcceptNewJob;
        private System.Windows.Forms.Button btnEditJob;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEditJobTitle;
        private System.Windows.Forms.TextBox txtEditJobRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSelectedID;
        private System.Windows.Forms.TextBox txtJobRate;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Button btnReset;
    }
}