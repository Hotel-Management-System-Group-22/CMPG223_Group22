namespace HotelManagementSystem
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpSearch = new System.Windows.Forms.TabPage();
            this.rdbDescending = new System.Windows.Forms.RadioButton();
            this.rdbAscending = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchReset = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbpAdd_Update = new System.Windows.Forms.TabPage();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnAddReset = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpDelete = new System.Windows.Forms.TabPage();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenuDelete = new System.Windows.Forms.Button();
            this.btnMenuAdd = new System.Windows.Forms.Button();
            this.btnMenuSearch = new System.Windows.Forms.Button();
            this.btnMenuUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tbpSearch.SuspendLayout();
            this.tbpAdd_Update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(210, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 251);
            this.tabControl1.TabIndex = 1;
            // 
            // tbpSearch
            // 
            this.tbpSearch.Controls.Add(this.rdbDescending);
            this.tbpSearch.Controls.Add(this.rdbAscending);
            this.tbpSearch.Controls.Add(this.label2);
            this.tbpSearch.Controls.Add(this.label1);
            this.tbpSearch.Controls.Add(this.btnSearchReset);
            this.tbpSearch.Controls.Add(this.textBox1);
            this.tbpSearch.Location = new System.Drawing.Point(4, 22);
            this.tbpSearch.Name = "tbpSearch";
            this.tbpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSearch.Size = new System.Drawing.Size(531, 225);
            this.tbpSearch.TabIndex = 0;
            this.tbpSearch.Text = "Search";
            this.tbpSearch.UseVisualStyleBackColor = true;
            // 
            // rdbDescending
            // 
            this.rdbDescending.AutoSize = true;
            this.rdbDescending.Location = new System.Drawing.Point(160, 108);
            this.rdbDescending.Name = "rdbDescending";
            this.rdbDescending.Size = new System.Drawing.Size(82, 17);
            this.rdbDescending.TabIndex = 5;
            this.rdbDescending.TabStop = true;
            this.rdbDescending.Text = "Descending";
            this.rdbDescending.UseVisualStyleBackColor = true;
            // 
            // rdbAscending
            // 
            this.rdbAscending.AutoSize = true;
            this.rdbAscending.Location = new System.Drawing.Point(160, 84);
            this.rdbAscending.Name = "rdbAscending";
            this.rdbAscending.Size = new System.Drawing.Size(75, 17);
            this.rdbAscending.TabIndex = 4;
            this.rdbAscending.TabStop = true;
            this.rdbAscending.Text = "Ascending";
            this.rdbAscending.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sort by Room number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Room Number";
            // 
            // btnSearchReset
            // 
            this.btnSearchReset.Location = new System.Drawing.Point(314, 32);
            this.btnSearchReset.Name = "btnSearchReset";
            this.btnSearchReset.Size = new System.Drawing.Size(75, 23);
            this.btnSearchReset.TabIndex = 1;
            this.btnSearchReset.Text = "Reset";
            this.btnSearchReset.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tbpAdd_Update
            // 
            this.tbpAdd_Update.Controls.Add(this.btnUpdateRoom);
            this.tbpAdd_Update.Controls.Add(this.txtRoomID);
            this.tbpAdd_Update.Controls.Add(this.lblRoomID);
            this.tbpAdd_Update.Controls.Add(this.btnAddRoom);
            this.tbpAdd_Update.Controls.Add(this.btnAddReset);
            this.tbpAdd_Update.Controls.Add(this.numericUpDown1);
            this.tbpAdd_Update.Controls.Add(this.comboBox3);
            this.tbpAdd_Update.Controls.Add(this.comboBox2);
            this.tbpAdd_Update.Controls.Add(this.comboBox1);
            this.tbpAdd_Update.Controls.Add(this.textBox2);
            this.tbpAdd_Update.Controls.Add(this.label7);
            this.tbpAdd_Update.Controls.Add(this.label6);
            this.tbpAdd_Update.Controls.Add(this.label5);
            this.tbpAdd_Update.Controls.Add(this.label4);
            this.tbpAdd_Update.Controls.Add(this.label3);
            this.tbpAdd_Update.Location = new System.Drawing.Point(4, 22);
            this.tbpAdd_Update.Name = "tbpAdd_Update";
            this.tbpAdd_Update.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAdd_Update.Size = new System.Drawing.Size(531, 225);
            this.tbpAdd_Update.TabIndex = 1;
            this.tbpAdd_Update.Text = "Add and Update";
            this.tbpAdd_Update.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Location = new System.Drawing.Point(156, 196);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(108, 23);
            this.btnUpdateRoom.TabIndex = 29;
            this.btnUpdateRoom.Text = "Update room";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(157, 18);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(121, 20);
            this.txtRoomID.TabIndex = 28;
            this.txtRoomID.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(26, 25);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(49, 13);
            this.lblRoomID.TabIndex = 27;
            this.lblRoomID.Text = "Room ID";
            this.lblRoomID.Click += new System.EventHandler(this.label13_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(30, 196);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoom.TabIndex = 12;
            this.btnAddRoom.Text = "Add room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            // 
            // btnAddReset
            // 
            this.btnAddReset.Location = new System.Drawing.Point(358, 27);
            this.btnAddReset.Name = "btnAddReset";
            this.btnAddReset.Size = new System.Drawing.Size(75, 23);
            this.btnAddReset.TabIndex = 11;
            this.btnAddReset.Text = "Reset";
            this.btnAddReset.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(157, 107);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(156, 163);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(156, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Max occupancy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Room status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Room rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Room type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room number";
            // 
            // tbpDelete
            // 
            this.tbpDelete.Controls.Add(this.btnDeleteRoom);
            this.tbpDelete.Controls.Add(this.textBox3);
            this.tbpDelete.Controls.Add(this.label8);
            this.tbpDelete.Location = new System.Drawing.Point(4, 22);
            this.tbpDelete.Name = "tbpDelete";
            this.tbpDelete.Size = new System.Drawing.Size(531, 225);
            this.tbpDelete.TabIndex = 3;
            this.tbpDelete.Text = "Delete";
            this.tbpDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(89, 116);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRoom.TabIndex = 2;
            this.btnDeleteRoom.Text = "Delete room";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Search by room ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenuDelete);
            this.groupBox1.Controls.Add(this.btnMenuAdd);
            this.groupBox1.Controls.Add(this.btnMenuSearch);
            this.groupBox1.Controls.Add(this.btnMenuUpdate);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 229);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnMenuDelete
            // 
            this.btnMenuDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMenuDelete.Location = new System.Drawing.Point(6, 162);
            this.btnMenuDelete.Name = "btnMenuDelete";
            this.btnMenuDelete.Size = new System.Drawing.Size(80, 30);
            this.btnMenuDelete.TabIndex = 5;
            this.btnMenuDelete.Text = "Delete";
            this.btnMenuDelete.UseVisualStyleBackColor = true;
            this.btnMenuDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMenuAdd
            // 
            this.btnMenuAdd.Location = new System.Drawing.Point(6, 68);
            this.btnMenuAdd.Name = "btnMenuAdd";
            this.btnMenuAdd.Size = new System.Drawing.Size(80, 30);
            this.btnMenuAdd.TabIndex = 4;
            this.btnMenuAdd.Text = "Add";
            this.btnMenuAdd.UseVisualStyleBackColor = true;
            this.btnMenuAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMenuSearch
            // 
            this.btnMenuSearch.Location = new System.Drawing.Point(6, 32);
            this.btnMenuSearch.Name = "btnMenuSearch";
            this.btnMenuSearch.Size = new System.Drawing.Size(80, 30);
            this.btnMenuSearch.TabIndex = 3;
            this.btnMenuSearch.Text = "Search";
            this.btnMenuSearch.UseVisualStyleBackColor = true;
            this.btnMenuSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMenuUpdate
            // 
            this.btnMenuUpdate.Location = new System.Drawing.Point(6, 127);
            this.btnMenuUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuUpdate.Name = "btnMenuUpdate";
            this.btnMenuUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnMenuUpdate.TabIndex = 2;
            this.btnMenuUpdate.Text = "Update";
            this.btnMenuUpdate.UseVisualStyleBackColor = true;
            this.btnMenuUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 273);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-20, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 15);
            this.panel1.TabIndex = 4;
            // 
            // MaintainRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaintainRooms";
            this.Text = "MaintainRooms";
            this.tabControl1.ResumeLayout(false);
            this.tbpSearch.ResumeLayout(false);
            this.tbpSearch.PerformLayout();
            this.tbpAdd_Update.ResumeLayout(false);
            this.tbpAdd_Update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchReset;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdbDescending;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnAddReset;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteRoom;
    }
}