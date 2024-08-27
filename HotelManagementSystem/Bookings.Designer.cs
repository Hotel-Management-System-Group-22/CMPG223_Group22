namespace HotelManagementSystem
{
    partial class Bookings
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
            this.bookingsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtUpdateSearch = new System.Windows.Forms.TextBox();
            this.cmbUpdateJob = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdateFName = new System.Windows.Forms.TextBox();
            this.btnUpdateReset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.txtUpdateLName = new System.Windows.Forms.TextBox();
            this.cmbUpdateRole = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteReset = new System.Windows.Forms.Button();
            this.btnDeleteEmp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBookingID_Delete = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtGuestLName_Delete = new System.Windows.Forms.TextBox();
            this.txtGuestFName_Delete = new System.Windows.Forms.TextBox();
            this.txtRoomNr_Delete = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbConfirm = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtCheckout = new System.Windows.Forms.DateTimePicker();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.txtRoomNrAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddReset = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.txtGuestFNameAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuestLNameAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSearchReset = new System.Windows.Forms.Button();
            this.rdoStaff = new System.Windows.Forms.RadioButton();
            this.rdoDes = new System.Windows.Forms.RadioButton();
            this.rdoAsc = new System.Windows.Forms.RadioButton();
            this.rdoClerk = new System.Windows.Forms.RadioButton();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingsDataGridView
            // 
            this.bookingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsDataGridView.Location = new System.Drawing.Point(47, 22);
            this.bookingsDataGridView.Name = "bookingsDataGridView";
            this.bookingsDataGridView.RowHeadersWidth = 51;
            this.bookingsDataGridView.RowTemplate.Height = 24;
            this.bookingsDataGridView.Size = new System.Drawing.Size(1130, 282);
            this.bookingsDataGridView.TabIndex = 18;
            this.bookingsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingsDataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(47, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 262);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MENU";
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(16, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(198, 43);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(198, 43);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(344, 310);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 335);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtUpdateSearch);
            this.tabPage1.Controls.Add(this.cmbUpdateJob);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtUpdateFName);
            this.tabPage1.Controls.Add(this.btnUpdateReset);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnUpdateEmp);
            this.tabPage1.Controls.Add(this.txtUpdateLName);
            this.tabPage1.Controls.Add(this.cmbUpdateRole);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(835, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtUpdateSearch
            // 
            this.txtUpdateSearch.Location = new System.Drawing.Point(289, 23);
            this.txtUpdateSearch.Name = "txtUpdateSearch";
            this.txtUpdateSearch.Size = new System.Drawing.Size(180, 22);
            this.txtUpdateSearch.TabIndex = 11;
            // 
            // cmbUpdateJob
            // 
            this.cmbUpdateJob.DisplayMember = "Job_Title";
            this.cmbUpdateJob.FormattingEnabled = true;
            this.cmbUpdateJob.Location = new System.Drawing.Point(289, 160);
            this.cmbUpdateJob.Name = "cmbUpdateJob";
            this.cmbUpdateJob.Size = new System.Drawing.Size(180, 24);
            this.cmbUpdateJob.TabIndex = 6;
            this.cmbUpdateJob.ValueMember = "Job_ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(102, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Search Guest:";
            // 
            // txtUpdateFName
            // 
            this.txtUpdateFName.Location = new System.Drawing.Point(289, 63);
            this.txtUpdateFName.Name = "txtUpdateFName";
            this.txtUpdateFName.Size = new System.Drawing.Size(180, 22);
            this.txtUpdateFName.TabIndex = 0;
            // 
            // btnUpdateReset
            // 
            this.btnUpdateReset.Location = new System.Drawing.Point(526, 99);
            this.btnUpdateReset.Name = "btnUpdateReset";
            this.btnUpdateReset.Size = new System.Drawing.Size(303, 43);
            this.btnUpdateReset.TabIndex = 9;
            this.btnUpdateReset.Text = "RESET";
            this.btnUpdateReset.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "First name:";
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Location = new System.Drawing.Point(105, 247);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(332, 43);
            this.btnUpdateEmp.TabIndex = 6;
            this.btnUpdateEmp.Text = "UPDATE";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // txtUpdateLName
            // 
            this.txtUpdateLName.Location = new System.Drawing.Point(289, 110);
            this.txtUpdateLName.Name = "txtUpdateLName";
            this.txtUpdateLName.Size = new System.Drawing.Size(180, 22);
            this.txtUpdateLName.TabIndex = 3;
            // 
            // cmbUpdateRole
            // 
            this.cmbUpdateRole.FormattingEnabled = true;
            this.cmbUpdateRole.Items.AddRange(new object[] {
            "Administrator",
            "Clerk",
            "Other"});
            this.cmbUpdateRole.Location = new System.Drawing.Point(289, 202);
            this.cmbUpdateRole.Name = "cmbUpdateRole";
            this.cmbUpdateRole.Size = new System.Drawing.Size(180, 24);
            this.cmbUpdateRole.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Last name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Job Title:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteReset);
            this.tabPage2.Controls.Add(this.btnDeleteEmp);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(835, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteReset
            // 
            this.btnDeleteReset.Location = new System.Drawing.Point(512, 81);
            this.btnDeleteReset.Name = "btnDeleteReset";
            this.btnDeleteReset.Size = new System.Drawing.Size(298, 32);
            this.btnDeleteReset.TabIndex = 9;
            this.btnDeleteReset.Text = "RESET";
            this.btnDeleteReset.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.Location = new System.Drawing.Point(512, 173);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(303, 43);
            this.btnDeleteEmp.TabIndex = 6;
            this.btnDeleteEmp.Text = "DELETE";
            this.btnDeleteEmp.UseVisualStyleBackColor = true;
            this.btnDeleteEmp.Click += new System.EventHandler(this.btnDeleteEmp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDeparture);
            this.groupBox2.Controls.Add(this.txtArrival);
            this.groupBox2.Controls.Add(this.txtBookingID_Delete);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.txtGuestLName_Delete);
            this.groupBox2.Controls.Add(this.txtGuestFName_Delete);
            this.groupBox2.Controls.Add(this.txtRoomNr_Delete);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cmbConfirm);
            this.groupBox2.Location = new System.Drawing.Point(74, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 264);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verify Booking Details";
            // 
            // txtBookingID_Delete
            // 
            this.txtBookingID_Delete.Location = new System.Drawing.Point(187, 29);
            this.txtBookingID_Delete.Name = "txtBookingID_Delete";
            this.txtBookingID_Delete.ReadOnly = true;
            this.txtBookingID_Delete.Size = new System.Drawing.Size(180, 22);
            this.txtBookingID_Delete.TabIndex = 18;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(24, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 16);
            this.label.TabIndex = 19;
            this.label.Text = "Booking ID:";
            // 
            // txtGuestLName_Delete
            // 
            this.txtGuestLName_Delete.Location = new System.Drawing.Point(187, 92);
            this.txtGuestLName_Delete.Name = "txtGuestLName_Delete";
            this.txtGuestLName_Delete.ReadOnly = true;
            this.txtGuestLName_Delete.Size = new System.Drawing.Size(180, 22);
            this.txtGuestLName_Delete.TabIndex = 10;
            // 
            // txtGuestFName_Delete
            // 
            this.txtGuestFName_Delete.Location = new System.Drawing.Point(187, 61);
            this.txtGuestFName_Delete.Name = "txtGuestFName_Delete";
            this.txtGuestFName_Delete.ReadOnly = true;
            this.txtGuestFName_Delete.Size = new System.Drawing.Size(180, 22);
            this.txtGuestFName_Delete.TabIndex = 0;
            // 
            // txtRoomNr_Delete
            // 
            this.txtRoomNr_Delete.Location = new System.Drawing.Point(187, 138);
            this.txtRoomNr_Delete.Name = "txtRoomNr_Delete";
            this.txtRoomNr_Delete.ReadOnly = true;
            this.txtRoomNr_Delete.Size = new System.Drawing.Size(180, 22);
            this.txtRoomNr_Delete.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 16);
            this.label15.TabIndex = 11;
            this.label15.Text = "Guest Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Guest First Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "Room Number:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 16);
            this.label18.TabIndex = 17;
            this.label18.Text = "Departure Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "Arrival Date:";
            // 
            // cmbConfirm
            // 
            this.cmbConfirm.AutoSize = true;
            this.cmbConfirm.Location = new System.Drawing.Point(27, 238);
            this.cmbConfirm.Name = "cmbConfirm";
            this.cmbConfirm.Size = new System.Drawing.Size(280, 20);
            this.cmbConfirm.TabIndex = 0;
            this.cmbConfirm.Text = "Confirm that details to be deleted is correct";
            this.cmbConfirm.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.dtCheckout);
            this.tabPage3.Controls.Add(this.dtCheckin);
            this.tabPage3.Controls.Add(this.txtRoomNrAdd);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btnAddReset);
            this.tabPage3.Controls.Add(this.btnAddBooking);
            this.tabPage3.Controls.Add(this.txtGuestFNameAdd);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtGuestLNameAdd);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(835, 306);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(465, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Departure Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Arrival Date:";
            // 
            // dtCheckout
            // 
            this.dtCheckout.Location = new System.Drawing.Point(569, 192);
            this.dtCheckout.Name = "dtCheckout";
            this.dtCheckout.Size = new System.Drawing.Size(232, 22);
            this.dtCheckout.TabIndex = 13;
            this.dtCheckout.ValueChanged += new System.EventHandler(this.dtCheckout_ValueChanged);
            // 
            // dtCheckin
            // 
            this.dtCheckin.Location = new System.Drawing.Point(204, 192);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(229, 22);
            this.dtCheckin.TabIndex = 12;
            this.dtCheckin.ValueChanged += new System.EventHandler(this.dtCheckin_ValueChanged);
            // 
            // txtRoomNrAdd
            // 
            this.txtRoomNrAdd.Location = new System.Drawing.Point(224, 143);
            this.txtRoomNrAdd.Name = "txtRoomNrAdd";
            this.txtRoomNrAdd.Size = new System.Drawing.Size(180, 22);
            this.txtRoomNrAdd.TabIndex = 10;
            this.txtRoomNrAdd.TextChanged += new System.EventHandler(this.txtRoomNrAdd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Room number";
            // 
            // btnAddReset
            // 
            this.btnAddReset.Location = new System.Drawing.Point(498, 40);
            this.btnAddReset.Name = "btnAddReset";
            this.btnAddReset.Size = new System.Drawing.Size(303, 43);
            this.btnAddReset.TabIndex = 9;
            this.btnAddReset.Text = "RESET";
            this.btnAddReset.UseVisualStyleBackColor = true;
            this.btnAddReset.Click += new System.EventHandler(this.btnAddReset_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(250, 248);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(303, 43);
            this.btnAddBooking.TabIndex = 6;
            this.btnAddBooking.Text = "ADD";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // txtGuestFNameAdd
            // 
            this.txtGuestFNameAdd.Location = new System.Drawing.Point(224, 46);
            this.txtGuestFNameAdd.Name = "txtGuestFNameAdd";
            this.txtGuestFNameAdd.Size = new System.Drawing.Size(180, 22);
            this.txtGuestFNameAdd.TabIndex = 0;
            this.txtGuestFNameAdd.TextChanged += new System.EventHandler(this.txtGuestFNameAdd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guest First Name:";
            // 
            // txtGuestLNameAdd
            // 
            this.txtGuestLNameAdd.Location = new System.Drawing.Point(224, 93);
            this.txtGuestLNameAdd.Name = "txtGuestLNameAdd";
            this.txtGuestLNameAdd.Size = new System.Drawing.Size(180, 22);
            this.txtGuestLNameAdd.TabIndex = 3;
            this.txtGuestLNameAdd.TextChanged += new System.EventHandler(this.txtGuestLNameAdd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Guest Last name:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnSearchReset);
            this.tabPage4.Controls.Add(this.rdoStaff);
            this.tabPage4.Controls.Add(this.rdoDes);
            this.tabPage4.Controls.Add(this.rdoAsc);
            this.tabPage4.Controls.Add(this.rdoClerk);
            this.tabPage4.Controls.Add(this.rdoAdmin);
            this.tabPage4.Controls.Add(this.txtSearch);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(835, 306);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnSearchReset
            // 
            this.btnSearchReset.Location = new System.Drawing.Point(454, 36);
            this.btnSearchReset.Name = "btnSearchReset";
            this.btnSearchReset.Size = new System.Drawing.Size(303, 43);
            this.btnSearchReset.TabIndex = 10;
            this.btnSearchReset.Text = "RESET";
            this.btnSearchReset.UseVisualStyleBackColor = true;
            // 
            // rdoStaff
            // 
            this.rdoStaff.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rdoStaff.AutoSize = true;
            this.rdoStaff.Location = new System.Drawing.Point(197, 169);
            this.rdoStaff.Name = "rdoStaff";
            this.rdoStaff.Size = new System.Drawing.Size(145, 20);
            this.rdoStaff.TabIndex = 9;
            this.rdoStaff.Text = "Employee staff only";
            this.rdoStaff.UseVisualStyleBackColor = true;
            // 
            // rdoDes
            // 
            this.rdoDes.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rdoDes.AutoSize = true;
            this.rdoDes.Location = new System.Drawing.Point(197, 256);
            this.rdoDes.Name = "rdoDes";
            this.rdoDes.Size = new System.Drawing.Size(101, 20);
            this.rdoDes.TabIndex = 7;
            this.rdoDes.Text = "Descending";
            this.rdoDes.UseVisualStyleBackColor = true;
            // 
            // rdoAsc
            // 
            this.rdoAsc.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rdoAsc.AutoSize = true;
            this.rdoAsc.Location = new System.Drawing.Point(197, 221);
            this.rdoAsc.Name = "rdoAsc";
            this.rdoAsc.Size = new System.Drawing.Size(92, 20);
            this.rdoAsc.TabIndex = 6;
            this.rdoAsc.Text = "Ascending";
            this.rdoAsc.UseVisualStyleBackColor = true;
            // 
            // rdoClerk
            // 
            this.rdoClerk.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rdoClerk.AutoSize = true;
            this.rdoClerk.Location = new System.Drawing.Point(197, 138);
            this.rdoClerk.Name = "rdoClerk";
            this.rdoClerk.Size = new System.Drawing.Size(123, 20);
            this.rdoClerk.TabIndex = 5;
            this.rdoClerk.Text = "Clerk users only";
            this.rdoClerk.UseVisualStyleBackColor = true;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Location = new System.Drawing.Point(197, 104);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(130, 20);
            this.rdoAdmin.TabIndex = 4;
            this.rdoAdmin.Text = "Admin users only";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(197, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sort by Username:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Filter Admin Users:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search by ID number:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(187, 177);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.ReadOnly = true;
            this.txtArrival.Size = new System.Drawing.Size(180, 22);
            this.txtArrival.TabIndex = 20;
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(187, 210);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.ReadOnly = true;
            this.txtDeparture.Size = new System.Drawing.Size(180, 22);
            this.txtDeparture.TabIndex = 21;
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 656);
            this.Controls.Add(this.bookingsDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Bookings";
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.Bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bookingsDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtUpdateSearch;
        private System.Windows.Forms.ComboBox cmbUpdateJob;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpdateFName;
        private System.Windows.Forms.Button btnUpdateReset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.TextBox txtUpdateLName;
        private System.Windows.Forms.ComboBox cmbUpdateRole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeleteReset;
        private System.Windows.Forms.TextBox txtGuestFName_Delete;
        private System.Windows.Forms.Button btnDeleteEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddReset;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.TextBox txtGuestFNameAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuestLNameAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSearchReset;
        private System.Windows.Forms.RadioButton rdoStaff;
        private System.Windows.Forms.RadioButton rdoDes;
        private System.Windows.Forms.RadioButton rdoAsc;
        private System.Windows.Forms.RadioButton rdoClerk;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtCheckout;
        private System.Windows.Forms.DateTimePicker dtCheckin;
        private System.Windows.Forms.TextBox txtRoomNrAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRoomNr_Delete;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGuestLName_Delete;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cmbConfirm;
        private System.Windows.Forms.TextBox txtBookingID_Delete;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox txtArrival;
    }
}