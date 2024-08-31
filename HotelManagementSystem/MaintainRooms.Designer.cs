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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainRooms));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tbpSearch.SuspendLayout();
            this.tbpAdd_Update.SuspendLayout();
            this.tbpDelete.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpSearch);
            this.tabControl1.Controls.Add(this.tbpAdd_Update);
            this.tabControl1.Controls.Add(this.tbpDelete);
            this.tabControl1.Location = new System.Drawing.Point(454, 163);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 309);
            this.tabControl1.TabIndex = 1;
            // 
            // tbpSearch
            // 
            this.tbpSearch.BackColor = System.Drawing.Color.PapayaWhip;
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
            this.tbpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpSearch.Location = new System.Drawing.Point(4, 25);
            this.tbpSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbpSearch.Name = "tbpSearch";
            this.tbpSearch.Padding = new System.Windows.Forms.Padding(4);
            this.tbpSearch.Size = new System.Drawing.Size(791, 280);
            this.tbpSearch.TabIndex = 0;
            this.tbpSearch.Text = "Search";
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new System.Drawing.Point(242, 80);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(223, 30);
            this.txtSearchEmployee.TabIndex = 2;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // lblSearchEmployeeID
            // 
            this.lblSearchEmployeeID.AutoSize = true;
            this.lblSearchEmployeeID.Location = new System.Drawing.Point(17, 83);
            this.lblSearchEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchEmployeeID.Name = "lblSearchEmployeeID";
            this.lblSearchEmployeeID.Size = new System.Drawing.Size(197, 25);
            this.lblSearchEmployeeID.TabIndex = 11;
            this.lblSearchEmployeeID.Text = "Search Employee ID:";
            this.lblSearchEmployeeID.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbxSearchStatus
            // 
            this.cbxSearchStatus.FormattingEnabled = true;
            this.cbxSearchStatus.Items.AddRange(new object[] {
            "Unoccupied",
            "Occupied"});
            this.cbxSearchStatus.Location = new System.Drawing.Point(242, 139);
            this.cbxSearchStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSearchStatus.Name = "cbxSearchStatus";
            this.cbxSearchStatus.Size = new System.Drawing.Size(223, 33);
            this.cbxSearchStatus.TabIndex = 3;
            this.cbxSearchStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSearchRoomStatus
            // 
            this.lblSearchRoomStatus.AutoSize = true;
            this.lblSearchRoomStatus.Location = new System.Drawing.Point(17, 142);
            this.lblSearchRoomStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchRoomStatus.Name = "lblSearchRoomStatus";
            this.lblSearchRoomStatus.Size = new System.Drawing.Size(126, 25);
            this.lblSearchRoomStatus.TabIndex = 9;
            this.lblSearchRoomStatus.Text = "Room status:";
            this.lblSearchRoomStatus.Click += new System.EventHandler(this.label4_Click);
            // 
            // rdbDescending
            // 
            this.rdbDescending.AutoSize = true;
            this.rdbDescending.Location = new System.Drawing.Point(242, 222);
            this.rdbDescending.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDescending.Name = "rdbDescending";
            this.rdbDescending.Size = new System.Drawing.Size(137, 29);
            this.rdbDescending.TabIndex = 5;
            this.rdbDescending.Text = "Descending";
            this.rdbDescending.UseVisualStyleBackColor = true;
            this.rdbDescending.CheckedChanged += new System.EventHandler(this.rdbDescending_CheckedChanged);
            // 
            // rdbAscending
            // 
            this.rdbAscending.AutoSize = true;
            this.rdbAscending.Checked = true;
            this.rdbAscending.Location = new System.Drawing.Point(242, 185);
            this.rdbAscending.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAscending.Name = "rdbAscending";
            this.rdbAscending.Size = new System.Drawing.Size(126, 29);
            this.rdbAscending.TabIndex = 4;
            this.rdbAscending.TabStop = true;
            this.rdbAscending.Text = "Ascending";
            this.rdbAscending.UseVisualStyleBackColor = true;
            this.rdbAscending.CheckedChanged += new System.EventHandler(this.rdbAscending_CheckedChanged);
            // 
            // lblSearchSortRoomID
            // 
            this.lblSearchSortRoomID.AutoSize = true;
            this.lblSearchSortRoomID.Location = new System.Drawing.Point(17, 198);
            this.lblSearchSortRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchSortRoomID.Name = "lblSearchSortRoomID";
            this.lblSearchSortRoomID.Size = new System.Drawing.Size(160, 25);
            this.lblSearchSortRoomID.TabIndex = 3;
            this.lblSearchSortRoomID.Text = "Sort by Room ID:";
            // 
            // lblSearchRoomID
            // 
            this.lblSearchRoomID.AutoSize = true;
            this.lblSearchRoomID.Location = new System.Drawing.Point(17, 27);
            this.lblSearchRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchRoomID.Name = "lblSearchRoomID";
            this.lblSearchRoomID.Size = new System.Drawing.Size(161, 25);
            this.lblSearchRoomID.TabIndex = 2;
            this.lblSearchRoomID.Text = "Search Room ID:";
            // 
            // btnSearchReset
            // 
            this.btnSearchReset.Location = new System.Drawing.Point(541, 212);
            this.btnSearchReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchReset.Name = "btnSearchReset";
            this.btnSearchReset.Size = new System.Drawing.Size(242, 50);
            this.btnSearchReset.TabIndex = 6;
            this.btnSearchReset.Text = "Reset";
            this.btnSearchReset.UseVisualStyleBackColor = true;
            this.btnSearchReset.Click += new System.EventHandler(this.btnSearchReset_Click);
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.Location = new System.Drawing.Point(242, 22);
            this.txtSearchRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(223, 30);
            this.txtSearchRoom.TabIndex = 1;
            this.txtSearchRoom.TextChanged += new System.EventHandler(this.txtSearchRoom_TextChanged);
            // 
            // tbpAdd_Update
            // 
            this.tbpAdd_Update.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbpAdd_Update.Controls.Add(this.btnUpdateRoom);
            this.tbpAdd_Update.Controls.Add(this.txtRoomID);
            this.tbpAdd_Update.Controls.Add(this.lblRoomID);
            this.tbpAdd_Update.Controls.Add(this.btnAddRoom);
            this.tbpAdd_Update.Controls.Add(this.btnAddReset);
            this.tbpAdd_Update.Controls.Add(this.cbxRoomStatus);
            this.tbpAdd_Update.Controls.Add(this.txtEmployeeID);
            this.tbpAdd_Update.Controls.Add(this.lblRoomStatus);
            this.tbpAdd_Update.Controls.Add(this.lblEmployeeID);
            this.tbpAdd_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpAdd_Update.Location = new System.Drawing.Point(4, 25);
            this.tbpAdd_Update.Margin = new System.Windows.Forms.Padding(4);
            this.tbpAdd_Update.Name = "tbpAdd_Update";
            this.tbpAdd_Update.Padding = new System.Windows.Forms.Padding(4);
            this.tbpAdd_Update.Size = new System.Drawing.Size(791, 280);
            this.tbpAdd_Update.TabIndex = 1;
            this.tbpAdd_Update.Text = "Add and Update";
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Location = new System.Drawing.Point(532, 168);
            this.btnUpdateRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(242, 48);
            this.btnUpdateRoom.TabIndex = 5;
            this.btnUpdateRoom.Text = "Update Room";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(201, 22);
            this.txtRoomID.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(212, 30);
            this.txtRoomID.TabIndex = 1;
            this.txtRoomID.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(22, 25);
            this.lblRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(93, 25);
            this.lblRoomID.TabIndex = 27;
            this.lblRoomID.Text = "Room ID:";
            this.lblRoomID.Click += new System.EventHandler(this.label13_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(532, 112);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(242, 48);
            this.btnAddRoom.TabIndex = 4;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnAddReset
            // 
            this.btnAddReset.Location = new System.Drawing.Point(532, 224);
            this.btnAddReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddReset.Name = "btnAddReset";
            this.btnAddReset.Size = new System.Drawing.Size(242, 48);
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
            this.cbxRoomStatus.Location = new System.Drawing.Point(201, 139);
            this.cbxRoomStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRoomStatus.Name = "cbxRoomStatus";
            this.cbxRoomStatus.Size = new System.Drawing.Size(212, 33);
            this.cbxRoomStatus.TabIndex = 3;
            this.cbxRoomStatus.SelectedIndexChanged += new System.EventHandler(this.cbxRoomStatus_SelectedIndexChanged);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(201, 80);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(212, 30);
            this.txtEmployeeID.TabIndex = 2;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Location = new System.Drawing.Point(25, 147);
            this.lblRoomStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(126, 25);
            this.lblRoomStatus.TabIndex = 3;
            this.lblRoomStatus.Text = "Room status:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(22, 85);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(129, 25);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // tbpDelete
            // 
            this.tbpDelete.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbpDelete.Controls.Add(this.btnDeleteReset);
            this.tbpDelete.Controls.Add(this.btnDeleteRoom);
            this.tbpDelete.Controls.Add(this.txtDeleteRoomID);
            this.tbpDelete.Controls.Add(this.lblDeleteRoomID);
            this.tbpDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDelete.Location = new System.Drawing.Point(4, 25);
            this.tbpDelete.Margin = new System.Windows.Forms.Padding(4);
            this.tbpDelete.Name = "tbpDelete";
            this.tbpDelete.Size = new System.Drawing.Size(791, 280);
            this.tbpDelete.TabIndex = 3;
            this.tbpDelete.Text = "Delete";
            // 
            // btnDeleteReset
            // 
            this.btnDeleteReset.Location = new System.Drawing.Point(531, 208);
            this.btnDeleteReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteReset.Name = "btnDeleteReset";
            this.btnDeleteReset.Size = new System.Drawing.Size(242, 52);
            this.btnDeleteReset.TabIndex = 18;
            this.btnDeleteReset.Text = "Reset";
            this.btnDeleteReset.UseVisualStyleBackColor = true;
            this.btnDeleteReset.Click += new System.EventHandler(this.btnDeleteReset_Click);
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Location = new System.Drawing.Point(531, 148);
            this.btnDeleteRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(242, 52);
            this.btnDeleteRoom.TabIndex = 17;
            this.btnDeleteRoom.Text = "Delete room";
            this.btnDeleteRoom.UseVisualStyleBackColor = true;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // txtDeleteRoomID
            // 
            this.txtDeleteRoomID.Location = new System.Drawing.Point(230, 40);
            this.txtDeleteRoomID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeleteRoomID.Name = "txtDeleteRoomID";
            this.txtDeleteRoomID.Size = new System.Drawing.Size(199, 30);
            this.txtDeleteRoomID.TabIndex = 16;
            this.txtDeleteRoomID.TextChanged += new System.EventHandler(this.txtDeleteRoomID_TextChanged);
            // 
            // lblDeleteRoomID
            // 
            this.lblDeleteRoomID.AutoSize = true;
            this.lblDeleteRoomID.Location = new System.Drawing.Point(4, 45);
            this.lblDeleteRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteRoomID.Name = "lblDeleteRoomID";
            this.lblDeleteRoomID.Size = new System.Drawing.Size(180, 25);
            this.lblDeleteRoomID.TabIndex = 0;
            this.lblDeleteRoomID.Text = "Search by room ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.btnMenuDelete);
            this.groupBox1.Controls.Add(this.btnMenuAdd);
            this.groupBox1.Controls.Add(this.btnMenuSearch);
            this.groupBox1.Controls.Add(this.btnMenuUpdate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 163);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(307, 309);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnMenuDelete
            // 
            this.btnMenuDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMenuDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuDelete.Location = new System.Drawing.Point(19, 235);
            this.btnMenuDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuDelete.Name = "btnMenuDelete";
            this.btnMenuDelete.Size = new System.Drawing.Size(263, 52);
            this.btnMenuDelete.TabIndex = 15;
            this.btnMenuDelete.Text = "Delete";
            this.btnMenuDelete.UseVisualStyleBackColor = true;
            this.btnMenuDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMenuAdd
            // 
            this.btnMenuAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAdd.Location = new System.Drawing.Point(19, 94);
            this.btnMenuAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuAdd.Name = "btnMenuAdd";
            this.btnMenuAdd.Size = new System.Drawing.Size(263, 52);
            this.btnMenuAdd.TabIndex = 7;
            this.btnMenuAdd.Text = "Add";
            this.btnMenuAdd.UseVisualStyleBackColor = true;
            this.btnMenuAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMenuSearch
            // 
            this.btnMenuSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSearch.Location = new System.Drawing.Point(19, 25);
            this.btnMenuSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuSearch.Name = "btnMenuSearch";
            this.btnMenuSearch.Size = new System.Drawing.Size(263, 52);
            this.btnMenuSearch.TabIndex = 0;
            this.btnMenuSearch.Text = "Search";
            this.btnMenuSearch.UseVisualStyleBackColor = true;
            this.btnMenuSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMenuUpdate
            // 
            this.btnMenuUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuUpdate.Location = new System.Drawing.Point(19, 164);
            this.btnMenuUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuUpdate.Name = "btnMenuUpdate";
            this.btnMenuUpdate.Size = new System.Drawing.Size(263, 52);
            this.btnMenuUpdate.TabIndex = 12;
            this.btnMenuUpdate.Text = "Update";
            this.btnMenuUpdate.UseVisualStyleBackColor = true;
            this.btnMenuUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 493);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1217, 248);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-27, -11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 26);
            this.panel1.TabIndex = 4;
            // 
            // btnLanguage
            // 
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(1039, 57);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(242, 51);
            this.btnLanguage.TabIndex = 5;
            this.btnLanguage.Text = "Afrikaans";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1320, 774);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Location = new System.Drawing.Point(480, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 35);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(50, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MaintainRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 774);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MaintainRooms";
            this.Text = "MaintainRooms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}