namespace HotelManagementSystem
{
    partial class Employees
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.txtAddFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAddJob = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAddRole = new System.Windows.Forms.ComboBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.gnDelete = new System.Windows.Forms.GroupBox();
            this.btnDeleteReset = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeleteSerach = new System.Windows.Forms.TextBox();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdateReset = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.cmbUpdateRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUpdateJob = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdateLName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdateFName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdateSearch = new System.Windows.Forms.TextBox();
            this.btnAddReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.gnDelete.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(198, 43);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 43);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(16, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 43);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(198, 43);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btnAddReset);
            this.gbAdd.Controls.Add(this.btnAddEmp);
            this.gbAdd.Controls.Add(this.cmbAddRole);
            this.gbAdd.Controls.Add(this.label4);
            this.gbAdd.Controls.Add(this.cmbAddJob);
            this.gbAdd.Controls.Add(this.label3);
            this.gbAdd.Controls.Add(this.label2);
            this.gbAdd.Controls.Add(this.txtAddLName);
            this.gbAdd.Controls.Add(this.label1);
            this.gbAdd.Controls.Add(this.txtAddFName);
            this.gbAdd.Location = new System.Drawing.Point(280, 386);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(897, 272);
            this.gbAdd.TabIndex = 2;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add Employee";
            // 
            // txtAddFName
            // 
            this.txtAddFName.Location = new System.Drawing.Point(172, 29);
            this.txtAddFName.Name = "txtAddFName";
            this.txtAddFName.Size = new System.Drawing.Size(180, 22);
            this.txtAddFName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last name:";
            // 
            // txtAddLName
            // 
            this.txtAddLName.Location = new System.Drawing.Point(172, 76);
            this.txtAddLName.Name = "txtAddLName";
            this.txtAddLName.Size = new System.Drawing.Size(180, 22);
            this.txtAddLName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Job Title:";
            // 
            // cmbAddJob
            // 
            this.cmbAddJob.FormattingEnabled = true;
            this.cmbAddJob.Location = new System.Drawing.Point(172, 126);
            this.cmbAddJob.Name = "cmbAddJob";
            this.cmbAddJob.Size = new System.Drawing.Size(180, 24);
            this.cmbAddJob.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Role";
            // 
            // cmbAddRole
            // 
            this.cmbAddRole.FormattingEnabled = true;
            this.cmbAddRole.Items.AddRange(new object[] {
            "Administrator",
            "Clerk",
            "Other"});
            this.cmbAddRole.Location = new System.Drawing.Point(172, 168);
            this.cmbAddRole.Name = "cmbAddRole";
            this.cmbAddRole.Size = new System.Drawing.Size(180, 24);
            this.cmbAddRole.TabIndex = 8;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(49, 213);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(303, 43);
            this.btnAddEmp.TabIndex = 6;
            this.btnAddEmp.Text = "ADD";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            // 
            // gnDelete
            // 
            this.gnDelete.Controls.Add(this.btnDeleteReset);
            this.gnDelete.Controls.Add(this.btnDeleteEmp);
            this.gnDelete.Controls.Add(this.label8);
            this.gnDelete.Controls.Add(this.txtDeleteSerach);
            this.gnDelete.Location = new System.Drawing.Point(286, 363);
            this.gnDelete.Name = "gnDelete";
            this.gnDelete.Size = new System.Drawing.Size(914, 310);
            this.gnDelete.TabIndex = 10;
            this.gnDelete.TabStop = false;
            this.gnDelete.Text = "Delete Employee";
            // 
            // btnDeleteReset
            // 
            this.btnDeleteReset.Location = new System.Drawing.Point(415, 101);
            this.btnDeleteReset.Name = "btnDeleteReset";
            this.btnDeleteReset.Size = new System.Drawing.Size(298, 32);
            this.btnDeleteReset.TabIndex = 9;
            this.btnDeleteReset.Text = "RESET";
            this.btnDeleteReset.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Location = new System.Drawing.Point(49, 213);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(303, 43);
            this.btnDeleteEmp.TabIndex = 6;
            this.btnDeleteEmp.Text = "DELETE";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Search Employee ID:";
            // 
            // txtDeleteSerach
            // 
            this.txtDeleteSerach.Location = new System.Drawing.Point(198, 111);
            this.txtDeleteSerach.Name = "txtDeleteSerach";
            this.txtDeleteSerach.Size = new System.Drawing.Size(180, 22);
            this.txtDeleteSerach.TabIndex = 0;
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.txtUpdateSearch);
            this.gbUpdate.Controls.Add(this.label11);
            this.gbUpdate.Controls.Add(this.btnUpdateReset);
            this.gbUpdate.Controls.Add(this.btnUpdateEmp);
            this.gbUpdate.Controls.Add(this.cmbUpdateRole);
            this.gbUpdate.Controls.Add(this.label5);
            this.gbUpdate.Controls.Add(this.cmbUpdateJob);
            this.gbUpdate.Controls.Add(this.label6);
            this.gbUpdate.Controls.Add(this.label9);
            this.gbUpdate.Controls.Add(this.txtUpdateLName);
            this.gbUpdate.Controls.Add(this.label10);
            this.gbUpdate.Controls.Add(this.txtUpdateFName);
            this.gbUpdate.Location = new System.Drawing.Point(286, 352);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(897, 321);
            this.gbUpdate.TabIndex = 10;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update Employee Details";
            // 
            // btnUpdateReset
            // 
            this.btnUpdateReset.Location = new System.Drawing.Point(423, 82);
            this.btnUpdateReset.Name = "btnUpdateReset";
            this.btnUpdateReset.Size = new System.Drawing.Size(303, 43);
            this.btnUpdateReset.TabIndex = 9;
            this.btnUpdateReset.Text = "RESET";
            this.btnUpdateReset.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Location = new System.Drawing.Point(45, 266);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(332, 43);
            this.btnUpdateEmp.TabIndex = 6;
            this.btnUpdateEmp.Text = "UPDATE";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            // 
            // cmbUpdateRole
            // 
            this.cmbUpdateRole.FormattingEnabled = true;
            this.cmbUpdateRole.Items.AddRange(new object[] {
            "Administrator",
            "Clerk",
            "Other"});
            this.cmbUpdateRole.Location = new System.Drawing.Point(197, 221);
            this.cmbUpdateRole.Name = "cmbUpdateRole";
            this.cmbUpdateRole.Size = new System.Drawing.Size(180, 24);
            this.cmbUpdateRole.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Role";
            // 
            // cmbUpdateJob
            // 
            this.cmbUpdateJob.FormattingEnabled = true;
            this.cmbUpdateJob.Location = new System.Drawing.Point(197, 179);
            this.cmbUpdateJob.Name = "cmbUpdateJob";
            this.cmbUpdateJob.Size = new System.Drawing.Size(180, 24);
            this.cmbUpdateJob.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Job Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Last name:";
            // 
            // txtUpdateLName
            // 
            this.txtUpdateLName.Location = new System.Drawing.Point(197, 129);
            this.txtUpdateLName.Name = "txtUpdateLName";
            this.txtUpdateLName.Size = new System.Drawing.Size(180, 22);
            this.txtUpdateLName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "First name:";
            // 
            // txtUpdateFName
            // 
            this.txtUpdateFName.Location = new System.Drawing.Point(197, 82);
            this.txtUpdateFName.Name = "txtUpdateFName";
            this.txtUpdateFName.Size = new System.Drawing.Size(180, 22);
            this.txtUpdateFName.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Search Employee ID";
            // 
            // txtUpdateSearch
            // 
            this.txtUpdateSearch.Location = new System.Drawing.Point(197, 39);
            this.txtUpdateSearch.Name = "txtUpdateSearch";
            this.txtUpdateSearch.Size = new System.Drawing.Size(180, 22);
            this.txtUpdateSearch.TabIndex = 11;
            // 
            // btnAddReset
            // 
            this.btnAddReset.Location = new System.Drawing.Point(398, 23);
            this.btnAddReset.Name = "btnAddReset";
            this.btnAddReset.Size = new System.Drawing.Size(303, 43);
            this.btnAddReset.TabIndex = 9;
            this.btnAddReset.Text = "RESET";
            this.btnAddReset.UseVisualStyleBackColor = true;
            this.btnAddReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 698);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.gnDelete);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.gnDelete.ResumeLayout(false);
            this.gnDelete.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddFName;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.ComboBox cmbAddRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAddJob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gnDelete;
        private System.Windows.Forms.Button btnDeleteReset;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDeleteSerach;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.Button btnUpdateReset;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.ComboBox cmbUpdateRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUpdateJob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUpdateLName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdateFName;
        private System.Windows.Forms.TextBox txtUpdateSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddReset;
    }
}