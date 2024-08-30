﻿namespace HotelManagementSystem
{
    partial class MaintainRooms
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpSearch = new System.Windows.Forms.TabPage();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.lblSearchEmployeeID = new System.Windows.Forms.Label();
            this.cbxSearchStatus = new System.Windows.Forms.ComboBox();
            this.lblSearchRoomStatus = new System.Windows.Forms.Label();
            this.rdbDescending = new System.Windows.Forms.RadioButton();
            this.rdbAscending = new System.Windows.Forms.RadioButton();
            this.lblSearchSortRoomID = new System.Windows.Forms.Label();
            this.lblSearchRoomID = new System.Windows.Forms.Label();
            this.btnSearchReset = new System.Windows.Forms.Button();
            this.txtSearchRoom = new System.Windows.Forms.TextBox();
            this.tbpAdd_Update = new System.Windows.Forms.TabPage();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnAddReset = new System.Windows.Forms.Button();
            this.cbxRoomStatus = new System.Windows.Forms.ComboBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.tbpDelete = new System.Windows.Forms.TabPage();
            this.btnDeleteReset = new System.Windows.Forms.Button();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.txtDeleteRoomID = new System.Windows.Forms.TextBox();
            this.lblDeleteRoomID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenuDelete = new System.Windows.Forms.Button();
            this.btnMenuAdd = new System.Windows.Forms.Button();
            this.btnMenuSearch = new System.Windows.Forms.Button();
            this.btnMenuUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tbpSearch.SuspendLayout();
            this.tbpAdd_Update.SuspendLayout();
            this.tbpDelete.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpSearch);
            this.tabControl1.Controls.Add(this.tbpAdd_Update);
            this.tabControl1.Controls.Add(this.tbpDelete);
            this.tabControl1.Location = new System.Drawing.Point(280, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 309);
            this.tabControl1.TabIndex = 1;
            // 
            // tbpSearch
            // 
            this.tbpSearch.Controls.Add(this.txtSearchEmployee);
            this.tbpSearch.Controls.Add(this.lblSearchEmployeeID);
            this.tbpSearch.Controls.Add(this.cbxSearchStatus);
            this.tbpSearch.Controls.Add(this.lblSearchRoomStatus);
            this.tbpSearch.Controls.Add(this.rdbDescending);
            this.tbpSearch.Controls.Add(this.rdbAscending);
            this.tbpSearch.Controls.Add(this.lblSearchSortRoomID);
            this.tbpSearch.Controls.Add(this.lblSearchRoomID);
            this.tbpSearch.Controls.Add(this.btnSearchReset);
            this.tbpSearch.Controls.Add(this.txtSearchRoom);
            this.tbpSearch.Location = new System.Drawing.Point(4, 25);
            this.tbpSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpSearch.Name = "tbpSearch";
            this.tbpSearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpSearch.Size = new System.Drawing.Size(711, 280);
            this.tbpSearch.TabIndex = 0;
            this.tbpSearch.Text = "Search";
            this.tbpSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new System.Drawing.Point(181, 69);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(160, 22);
            this.txtSearchEmployee.TabIndex = 2;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // lblSearchEmployeeID
            // 
            this.lblSearchEmployeeID.AutoSize = true;
            this.lblSearchEmployeeID.Location = new System.Drawing.Point(17, 80);
            this.lblSearchEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchEmployeeID.Name = "lblSearchEmployeeID";
            this.lblSearchEmployeeID.Size = new System.Drawing.Size(131, 16);
            this.lblSearchEmployeeID.TabIndex = 11;
            this.lblSearchEmployeeID.Text = "Search Employee ID";
            this.lblSearchEmployeeID.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbxSearchStatus
            // 
            this.cbxSearchStatus.FormattingEnabled = true;
            this.cbxSearchStatus.Items.AddRange(new object[] {
            "Unoccupied",
            "Occupied"});
            this.cbxSearchStatus.Location = new System.Drawing.Point(181, 108);
            this.cbxSearchStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSearchStatus.Name = "cbxSearchStatus";
            this.cbxSearchStatus.Size = new System.Drawing.Size(160, 24);
            this.cbxSearchStatus.TabIndex = 3;
            this.cbxSearchStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSearchRoomStatus
            // 
            this.lblSearchRoomStatus.AutoSize = true;
            this.lblSearchRoomStatus.Location = new System.Drawing.Point(17, 111);
            this.lblSearchRoomStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchRoomStatus.Name = "lblSearchRoomStatus";
            this.lblSearchRoomStatus.Size = new System.Drawing.Size(82, 16);
            this.lblSearchRoomStatus.TabIndex = 9;
            this.lblSearchRoomStatus.Text = "Room status";
            this.lblSearchRoomStatus.Click += new System.EventHandler(this.label4_Click);
            // 
            // rdbDescending
            // 
            this.rdbDescending.AutoSize = true;
            this.rdbDescending.Location = new System.Drawing.Point(181, 167);
            this.rdbDescending.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbDescending.Name = "rdbDescending";
            this.rdbDescending.Size = new System.Drawing.Size(101, 20);
            this.rdbDescending.TabIndex = 5;
            this.rdbDescending.Text = "Descending";
            this.rdbDescending.UseVisualStyleBackColor = true;
            this.rdbDescending.CheckedChanged += new System.EventHandler(this.rdbDescending_CheckedChanged);
            // 
            // rdbAscending
            // 
            this.rdbAscending.AutoSize = true;
            this.rdbAscending.Checked = true;
            this.rdbAscending.Location = new System.Drawing.Point(181, 139);
            this.rdbAscending.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbAscending.Name = "rdbAscending";
            this.rdbAscending.Size = new System.Drawing.Size(92, 20);
            this.rdbAscending.TabIndex = 4;
            this.rdbAscending.TabStop = true;
            this.rdbAscending.Text = "Ascending";
            this.rdbAscending.UseVisualStyleBackColor = true;
            this.rdbAscending.CheckedChanged += new System.EventHandler(this.rdbAscending_CheckedChanged);
            // 
            // lblSearchSortRoomID
            // 
            this.lblSearchSortRoomID.AutoSize = true;
            this.lblSearchSortRoomID.Location = new System.Drawing.Point(16, 144);
            this.lblSearchSortRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchSortRoomID.Name = "lblSearchSortRoomID";
            this.lblSearchSortRoomID.Size = new System.Drawing.Size(105, 16);
            this.lblSearchSortRoomID.TabIndex = 3;
            this.lblSearchSortRoomID.Text = "Sort by Room ID";
            // 
            // lblSearchRoomID
            // 
            this.lblSearchRoomID.AutoSize = true;
            this.lblSearchRoomID.Location = new System.Drawing.Point(17, 46);
            this.lblSearchRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchRoomID.Name = "lblSearchRoomID";
            this.lblSearchRoomID.Size = new System.Drawing.Size(106, 16);
            this.lblSearchRoomID.TabIndex = 2;
            this.lblSearchRoomID.Text = "Search Room ID";
            // 
            // btnSearchReset
            // 
            this.btnSearchReset.Location = new System.Drawing.Point(20, 199);
            this.btnSearchReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchReset.Name = "btnSearchReset";
            this.btnSearchReset.Size = new System.Drawing.Size(100, 28);
            this.btnSearchReset.TabIndex = 6;
            this.btnSearchReset.Text = "Reset";
            this.btnSearchReset.UseVisualStyleBackColor = true;
            this.btnSearchReset.Click += new System.EventHandler(this.btnSearchReset_Click);
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.Location = new System.Drawing.Point(181, 37);
            this.txtSearchRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(160, 22);
            this.txtSearchRoom.TabIndex = 1;
            this.txtSearchRoom.TextChanged += new System.EventHandler(this.txtSearchRoom_TextChanged);
            // 
            // tbpAdd_Update
            // 
            this.tbpAdd_Update.Controls.Add(this.btnUpdateRoom);
            this.tbpAdd_Update.Controls.Add(this.txtRoomID);
            this.tbpAdd_Update.Controls.Add(this.lblRoomID);
            this.tbpAdd_Update.Controls.Add(this.btnAddRoom);
            this.tbpAdd_Update.Controls.Add(this.btnAddReset);
            this.tbpAdd_Update.Controls.Add(this.cbxRoomStatus);
            this.tbpAdd_Update.Controls.Add(this.txtEmployeeID);
            this.tbpAdd_Update.Controls.Add(this.lblRoomStatus);
            this.tbpAdd_Update.Controls.Add(this.lblEmployeeID);
            this.tbpAdd_Update.Location = new System.Drawing.Point(4, 25);
            this.tbpAdd_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpAdd_Update.Name = "tbpAdd_Update";
            this.tbpAdd_Update.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpAdd_Update.Size = new System.Drawing.Size(711, 280);
            this.tbpAdd_Update.TabIndex = 1;
            this.tbpAdd_Update.Text = "Add and Update";
            this.tbpAdd_Update.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Location = new System.Drawing.Point(320, 199);
            this.btnUpdateRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(144, 28);
            this.btnUpdateRoom.TabIndex = 5;
            this.btnUpdateRoom.Text = "Update Room";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(181, 44);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(160, 22);
            this.txtRoomID.TabIndex = 1;
            this.txtRoomID.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(17, 48);
            this.lblRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(60, 16);
            this.lblRoomID.TabIndex = 27;
            this.lblRoomID.Text = "Room ID";
            this.lblRoomID.Click += new System.EventHandler(this.label13_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(181, 199);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(100, 28);
            this.btnAddRoom.TabIndex = 4;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnAddReset
            // 
            this.btnAddReset.Location = new System.Drawing.Point(20, 199);
            this.btnAddReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddReset.Name = "btnAddReset";
            this.btnAddReset.Size = new System.Drawing.Size(100, 28);
            this.btnAddReset.TabIndex = 6;
            this.btnAddReset.Text = "Reset";
            this.btnAddReset.UseVisualStyleBackColor = true;
            this.btnAddReset.Click += new System.EventHandler(this.btnAddReset_Click);
            // 
            // cbxRoomStatus
            // 
            this.cbxRoomStatus.FormattingEnabled = true;
            this.cbxRoomStatus.Items.AddRange(new object[] {
            "Unoccupied",
            "Occupied"});
            this.cbxRoomStatus.Location = new System.Drawing.Point(180, 112);
            this.cbxRoomStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxRoomStatus.Name = "cbxRoomStatus";
            this.cbxRoomStatus.Size = new System.Drawing.Size(160, 24);
            this.cbxRoomStatus.TabIndex = 3;
            this.cbxRoomStatus.SelectedIndexChanged += new System.EventHandler(this.cbxRoomStatus_SelectedIndexChanged);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(180, 71);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(160, 22);
            this.txtEmployeeID.TabIndex = 2;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Location = new System.Drawing.Point(16, 112);
            this.lblRoomStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(82, 16);
            this.lblRoomStatus.TabIndex = 3;
            this.lblRoomStatus.Text = "Room status";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(16, 80);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(85, 16);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // tbpDelete
            // 
            this.tbpDelete.Controls.Add(this.btnDeleteReset);
            this.tbpDelete.Controls.Add(this.btnDeleteRoom);
            this.tbpDelete.Controls.Add(this.txtDeleteRoomID);
            this.tbpDelete.Controls.Add(this.lblDeleteRoomID);
            this.tbpDelete.Location = new System.Drawing.Point(4, 25);
            this.tbpDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpDelete.Name = "tbpDelete";
            this.tbpDelete.Size = new System.Drawing.Size(711, 280);
            this.tbpDelete.TabIndex = 3;
            this.tbpDelete.Text = "Delete";
            this.tbpDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteReset
            // 
            this.btnDeleteReset.Location = new System.Drawing.Point(20, 199);
            this.btnDeleteReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteReset.Name = "btnDeleteReset";
            this.btnDeleteReset.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteReset.TabIndex = 18;
            this.btnDeleteReset.Text = "Reset";
            this.btnDeleteReset.UseVisualStyleBackColor = true;
            this.btnDeleteReset.Click += new System.EventHandler(this.btnDeleteReset_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(181, 199);
            this.btnDeleteRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteRoom.TabIndex = 17;
            this.btnDeleteRoom.Text = "Delete room";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // txtDeleteRoomID
            // 
            this.txtDeleteRoomID.Location = new System.Drawing.Point(181, 44);
            this.txtDeleteRoomID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDeleteRoomID.Name = "txtDeleteRoomID";
            this.txtDeleteRoomID.Size = new System.Drawing.Size(132, 22);
            this.txtDeleteRoomID.TabIndex = 16;
            this.txtDeleteRoomID.TextChanged += new System.EventHandler(this.txtDeleteRoomID_TextChanged);
            // 
            // lblDeleteRoomID
            // 
            this.lblDeleteRoomID.AutoSize = true;
            this.lblDeleteRoomID.Location = new System.Drawing.Point(16, 48);
            this.lblDeleteRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteRoomID.Name = "lblDeleteRoomID";
            this.lblDeleteRoomID.Size = new System.Drawing.Size(118, 16);
            this.lblDeleteRoomID.TabIndex = 0;
            this.lblDeleteRoomID.Text = "Search by room ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenuDelete);
            this.groupBox1.Controls.Add(this.btnMenuAdd);
            this.groupBox1.Controls.Add(this.btnMenuSearch);
            this.groupBox1.Controls.Add(this.btnMenuUpdate);
            this.groupBox1.Location = new System.Drawing.Point(16, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(256, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnMenuDelete
            // 
            this.btnMenuDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMenuDelete.Location = new System.Drawing.Point(8, 199);
            this.btnMenuDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenuDelete.Name = "btnMenuDelete";
            this.btnMenuDelete.Size = new System.Drawing.Size(107, 37);
            this.btnMenuDelete.TabIndex = 15;
            this.btnMenuDelete.Text = "Delete";
            this.btnMenuDelete.UseVisualStyleBackColor = true;
            this.btnMenuDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMenuAdd
            // 
            this.btnMenuAdd.Location = new System.Drawing.Point(8, 84);
            this.btnMenuAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenuAdd.Name = "btnMenuAdd";
            this.btnMenuAdd.Size = new System.Drawing.Size(107, 37);
            this.btnMenuAdd.TabIndex = 7;
            this.btnMenuAdd.Text = "Add";
            this.btnMenuAdd.UseVisualStyleBackColor = true;
            this.btnMenuAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMenuSearch
            // 
            this.btnMenuSearch.Location = new System.Drawing.Point(8, 39);
            this.btnMenuSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenuSearch.Name = "btnMenuSearch";
            this.btnMenuSearch.Size = new System.Drawing.Size(107, 37);
            this.btnMenuSearch.TabIndex = 0;
            this.btnMenuSearch.Text = "Search";
            this.btnMenuSearch.UseVisualStyleBackColor = true;
            this.btnMenuSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMenuUpdate
            // 
            this.btnMenuUpdate.Location = new System.Drawing.Point(8, 156);
            this.btnMenuUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuUpdate.Name = "btnMenuUpdate";
            this.btnMenuUpdate.Size = new System.Drawing.Size(107, 37);
            this.btnMenuUpdate.TabIndex = 12;
            this.btnMenuUpdate.Text = "Update";
            this.btnMenuUpdate.UseVisualStyleBackColor = true;
            this.btnMenuUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 331);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(977, 336);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-27, -11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 26);
            this.panel1.TabIndex = 4;
            // 
            // btnLanguage
            // 
            this.btnLanguage.Location = new System.Drawing.Point(1061, 638);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(100, 28);
            this.btnLanguage.TabIndex = 5;
            this.btnLanguage.Text = "Afrikaans";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // MaintainRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 774);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MaintainRooms";
            this.Text = "MaintainRooms";
            this.Load += new System.EventHandler(this.MaintainRooms_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpSearch.ResumeLayout(false);
            this.tbpSearch.PerformLayout();
            this.tbpAdd_Update.ResumeLayout(false);
            this.tbpAdd_Update.PerformLayout();
            this.tbpDelete.ResumeLayout(false);
            this.tbpDelete.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpSearch;
        private System.Windows.Forms.TabPage tbpAdd_Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMenuDelete;
        private System.Windows.Forms.Button btnMenuAdd;
        private System.Windows.Forms.Button btnMenuSearch;
        private System.Windows.Forms.Button btnMenuUpdate;
        private System.Windows.Forms.TabPage tbpDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbAscending;
        private System.Windows.Forms.Label lblSearchSortRoomID;
        private System.Windows.Forms.Label lblSearchRoomID;
        private System.Windows.Forms.Button btnSearchReset;
        private System.Windows.Forms.TextBox txtSearchRoom;
        private System.Windows.Forms.RadioButton rdbDescending;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblRoomStatus;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnAddReset;
        private System.Windows.Forms.ComboBox cbxRoomStatus;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.TextBox txtDeleteRoomID;
        private System.Windows.Forms.Label lblDeleteRoomID;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnDeleteReset;
        private System.Windows.Forms.ComboBox cbxSearchStatus;
        private System.Windows.Forms.Label lblSearchRoomStatus;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Label lblSearchEmployeeID;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}