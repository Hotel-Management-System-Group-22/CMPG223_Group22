namespace HotelManagementSystem
{
    partial class Guests
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
            this.grpBoxMenu = new System.Windows.Forms.GroupBox();
            this.BtnDeleteGuest = new System.Windows.Forms.Button();
            this.BtnUpdatePage = new System.Windows.Forms.Button();
            this.BtnAddPage = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPgAddGuest = new System.Windows.Forms.TabPage();
            this.BtnAddGuest = new System.Windows.Forms.Button();
            this.TxtFName_Add = new System.Windows.Forms.TextBox();
            this.TxtLName_Add = new System.Windows.Forms.TextBox();
            this.TxtContactNo_Add = new System.Windows.Forms.TextBox();
            this.TxtEmail_Add = new System.Windows.Forms.TextBox();
            this.lblFNameAdd = new System.Windows.Forms.Label();
            this.lblLNameAdd = new System.Windows.Forms.Label();
            this.LblContactNo = new System.Windows.Forms.Label();
            this.LblEmailAddress = new System.Windows.Forms.Label();
            this.tbPgUpdateGuest = new System.Windows.Forms.TabPage();
            this.LblEmail_Update = new System.Windows.Forms.Label();
            this.LblContactNo_Update = new System.Windows.Forms.Label();
            this.LblLName_Update = new System.Windows.Forms.Label();
            this.TxtLName_Update = new System.Windows.Forms.TextBox();
            this.TxtContactNo_Update = new System.Windows.Forms.TextBox();
            this.TxtBoxEmail_Update = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.grpBxSortBy = new System.Windows.Forms.GroupBox();
            this.RdnAsc = new System.Windows.Forms.RadioButton();
            this.RdnDesc = new System.Windows.Forms.RadioButton();
            this.BtnReset = new System.Windows.Forms.Button();
            this.TxtFName_Update = new System.Windows.Forms.TextBox();
            this.LblGroupBY = new System.Windows.Forms.Label();
            this.LblFName_Update = new System.Windows.Forms.Label();
            this.tbPageDeleteGuest = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdnBtnAscDelete = new System.Windows.Forms.RadioButton();
            this.RdnBtnDescDelete = new System.Windows.Forms.RadioButton();
            this.txtFName_Delete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReset_Delet = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.DgvGuests = new System.Windows.Forms.DataGridView();
            this.grpBoxMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPgAddGuest.SuspendLayout();
            this.tbPgUpdateGuest.SuspendLayout();
            this.grpBxSortBy.SuspendLayout();
            this.tbPageDeleteGuest.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxMenu
            // 
            this.grpBoxMenu.Controls.Add(this.BtnDeleteGuest);
            this.grpBoxMenu.Controls.Add(this.BtnUpdatePage);
            this.grpBoxMenu.Controls.Add(this.BtnAddPage);
            this.grpBoxMenu.Location = new System.Drawing.Point(937, 12);
            this.grpBoxMenu.Name = "grpBoxMenu";
            this.grpBoxMenu.Size = new System.Drawing.Size(268, 238);
            this.grpBoxMenu.TabIndex = 0;
            this.grpBoxMenu.TabStop = false;
            this.grpBoxMenu.Text = "Menu";
            // 
            // BtnDeleteGuest
            // 
            this.BtnDeleteGuest.Location = new System.Drawing.Point(11, 176);
            this.BtnDeleteGuest.Name = "BtnDeleteGuest";
            this.BtnDeleteGuest.Size = new System.Drawing.Size(243, 62);
            this.BtnDeleteGuest.TabIndex = 3;
            this.BtnDeleteGuest.Text = "DELETE GUEST";
            this.BtnDeleteGuest.UseVisualStyleBackColor = true;
            this.BtnDeleteGuest.Click += new System.EventHandler(this.BtnDeleteGuest_Click);
            // 
            // BtnUpdatePage
            // 
            this.BtnUpdatePage.Location = new System.Drawing.Point(6, 99);
            this.BtnUpdatePage.Name = "BtnUpdatePage";
            this.BtnUpdatePage.Size = new System.Drawing.Size(243, 51);
            this.BtnUpdatePage.TabIndex = 2;
            this.BtnUpdatePage.Text = "UPDATE GUEST";
            this.BtnUpdatePage.UseVisualStyleBackColor = true;
            this.BtnUpdatePage.Click += new System.EventHandler(this.BtnUpdatePage_Click);
            // 
            // BtnAddPage
            // 
            this.BtnAddPage.Location = new System.Drawing.Point(11, 18);
            this.BtnAddPage.Name = "BtnAddPage";
            this.BtnAddPage.Size = new System.Drawing.Size(243, 50);
            this.BtnAddPage.TabIndex = 0;
            this.BtnAddPage.Text = "ADD GUEST";
            this.BtnAddPage.UseVisualStyleBackColor = true;
            this.BtnAddPage.Click += new System.EventHandler(this.BtnAddPage_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPgAddGuest);
            this.tabControl1.Controls.Add(this.tbPgUpdateGuest);
            this.tabControl1.Controls.Add(this.tbPageDeleteGuest);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(38, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 279);
            this.tabControl1.TabIndex = 1;
            // 
            // tbPgAddGuest
            // 
            this.tbPgAddGuest.Controls.Add(this.BtnAddGuest);
            this.tbPgAddGuest.Controls.Add(this.TxtFName_Add);
            this.tbPgAddGuest.Controls.Add(this.TxtLName_Add);
            this.tbPgAddGuest.Controls.Add(this.TxtContactNo_Add);
            this.tbPgAddGuest.Controls.Add(this.TxtEmail_Add);
            this.tbPgAddGuest.Controls.Add(this.lblFNameAdd);
            this.tbPgAddGuest.Controls.Add(this.lblLNameAdd);
            this.tbPgAddGuest.Controls.Add(this.LblContactNo);
            this.tbPgAddGuest.Controls.Add(this.LblEmailAddress);
            this.tbPgAddGuest.Location = new System.Drawing.Point(4, 25);
            this.tbPgAddGuest.Name = "tbPgAddGuest";
            this.tbPgAddGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgAddGuest.Size = new System.Drawing.Size(754, 250);
            this.tbPgAddGuest.TabIndex = 0;
            this.tbPgAddGuest.Text = "ADD GUEST";
            this.tbPgAddGuest.UseVisualStyleBackColor = true;
            // 
            // BtnAddGuest
            // 
            this.BtnAddGuest.Location = new System.Drawing.Point(23, 197);
            this.BtnAddGuest.Name = "BtnAddGuest";
            this.BtnAddGuest.Size = new System.Drawing.Size(160, 23);
            this.BtnAddGuest.TabIndex = 3;
            this.BtnAddGuest.Text = "Add Guest";
            this.BtnAddGuest.UseVisualStyleBackColor = true;
            this.BtnAddGuest.Click += new System.EventHandler(this.BtnAddGuest_Click);
            // 
            // TxtFName_Add
            // 
            this.TxtFName_Add.Location = new System.Drawing.Point(114, 21);
            this.TxtFName_Add.Name = "TxtFName_Add";
            this.TxtFName_Add.Size = new System.Drawing.Size(100, 22);
            this.TxtFName_Add.TabIndex = 10;
            // 
            // TxtLName_Add
            // 
            this.TxtLName_Add.Location = new System.Drawing.Point(114, 58);
            this.TxtLName_Add.Name = "TxtLName_Add";
            this.TxtLName_Add.Size = new System.Drawing.Size(100, 22);
            this.TxtLName_Add.TabIndex = 9;
            // 
            // TxtContactNo_Add
            // 
            this.TxtContactNo_Add.Location = new System.Drawing.Point(127, 100);
            this.TxtContactNo_Add.Name = "TxtContactNo_Add";
            this.TxtContactNo_Add.Size = new System.Drawing.Size(100, 22);
            this.TxtContactNo_Add.TabIndex = 8;
            // 
            // TxtEmail_Add
            // 
            this.TxtEmail_Add.Location = new System.Drawing.Point(127, 136);
            this.TxtEmail_Add.Name = "TxtEmail_Add";
            this.TxtEmail_Add.Size = new System.Drawing.Size(100, 22);
            this.TxtEmail_Add.TabIndex = 7;
            // 
            // lblFNameAdd
            // 
            this.lblFNameAdd.AutoSize = true;
            this.lblFNameAdd.Location = new System.Drawing.Point(20, 24);
            this.lblFNameAdd.Name = "lblFNameAdd";
            this.lblFNameAdd.Size = new System.Drawing.Size(75, 16);
            this.lblFNameAdd.TabIndex = 3;
            this.lblFNameAdd.Text = "First Name:\r\n";
            // 
            // lblLNameAdd
            // 
            this.lblLNameAdd.AutoSize = true;
            this.lblLNameAdd.Location = new System.Drawing.Point(20, 61);
            this.lblLNameAdd.Name = "lblLNameAdd";
            this.lblLNameAdd.Size = new System.Drawing.Size(75, 16);
            this.lblLNameAdd.TabIndex = 4;
            this.lblLNameAdd.Text = "Last Name:";
            // 
            // LblContactNo
            // 
            this.LblContactNo.AutoSize = true;
            this.LblContactNo.Location = new System.Drawing.Point(20, 100);
            this.LblContactNo.Name = "LblContactNo";
            this.LblContactNo.Size = new System.Drawing.Size(101, 16);
            this.LblContactNo.TabIndex = 5;
            this.LblContactNo.Text = "Contct Number: ";
            // 
            // LblEmailAddress
            // 
            this.LblEmailAddress.AutoSize = true;
            this.LblEmailAddress.Location = new System.Drawing.Point(20, 136);
            this.LblEmailAddress.Name = "LblEmailAddress";
            this.LblEmailAddress.Size = new System.Drawing.Size(101, 16);
            this.LblEmailAddress.TabIndex = 6;
            this.LblEmailAddress.Text = "Email Address: ";
            // 
            // tbPgUpdateGuest
            // 
            this.tbPgUpdateGuest.Controls.Add(this.LblEmail_Update);
            this.tbPgUpdateGuest.Controls.Add(this.LblContactNo_Update);
            this.tbPgUpdateGuest.Controls.Add(this.LblLName_Update);
            this.tbPgUpdateGuest.Controls.Add(this.TxtLName_Update);
            this.tbPgUpdateGuest.Controls.Add(this.TxtContactNo_Update);
            this.tbPgUpdateGuest.Controls.Add(this.TxtBoxEmail_Update);
            this.tbPgUpdateGuest.Controls.Add(this.BtnUpdate);
            this.tbPgUpdateGuest.Controls.Add(this.grpBxSortBy);
            this.tbPgUpdateGuest.Controls.Add(this.BtnReset);
            this.tbPgUpdateGuest.Controls.Add(this.TxtFName_Update);
            this.tbPgUpdateGuest.Controls.Add(this.LblGroupBY);
            this.tbPgUpdateGuest.Controls.Add(this.LblFName_Update);
            this.tbPgUpdateGuest.Location = new System.Drawing.Point(4, 25);
            this.tbPgUpdateGuest.Name = "tbPgUpdateGuest";
            this.tbPgUpdateGuest.Size = new System.Drawing.Size(754, 250);
            this.tbPgUpdateGuest.TabIndex = 2;
            this.tbPgUpdateGuest.Text = "UPDATE GUEST";
            this.tbPgUpdateGuest.UseVisualStyleBackColor = true;
            // 
            // LblEmail_Update
            // 
            this.LblEmail_Update.AutoSize = true;
            this.LblEmail_Update.Location = new System.Drawing.Point(42, 125);
            this.LblEmail_Update.Name = "LblEmail_Update";
            this.LblEmail_Update.Size = new System.Drawing.Size(98, 16);
            this.LblEmail_Update.TabIndex = 14;
            this.LblEmail_Update.Text = "Email Address:";
            // 
            // LblContactNo_Update
            // 
            this.LblContactNo_Update.AutoSize = true;
            this.LblContactNo_Update.Location = new System.Drawing.Point(34, 94);
            this.LblContactNo_Update.Name = "LblContactNo_Update";
            this.LblContactNo_Update.Size = new System.Drawing.Size(106, 16);
            this.LblContactNo_Update.TabIndex = 13;
            this.LblContactNo_Update.Text = "Contact Number:";
            // 
            // LblLName_Update
            // 
            this.LblLName_Update.AutoSize = true;
            this.LblLName_Update.Location = new System.Drawing.Point(65, 66);
            this.LblLName_Update.Name = "LblLName_Update";
            this.LblLName_Update.Size = new System.Drawing.Size(75, 16);
            this.LblLName_Update.TabIndex = 12;
            this.LblLName_Update.Text = "Last Name:\r\n";
            // 
            // TxtLName_Update
            // 
            this.TxtLName_Update.Location = new System.Drawing.Point(151, 60);
            this.TxtLName_Update.Name = "TxtLName_Update";
            this.TxtLName_Update.Size = new System.Drawing.Size(100, 22);
            this.TxtLName_Update.TabIndex = 10;
            // 
            // TxtContactNo_Update
            // 
            this.TxtContactNo_Update.Location = new System.Drawing.Point(151, 88);
            this.TxtContactNo_Update.Name = "TxtContactNo_Update";
            this.TxtContactNo_Update.Size = new System.Drawing.Size(100, 22);
            this.TxtContactNo_Update.TabIndex = 9;
            // 
            // TxtBoxEmail_Update
            // 
            this.TxtBoxEmail_Update.Location = new System.Drawing.Point(151, 119);
            this.TxtBoxEmail_Update.Name = "TxtBoxEmail_Update";
            this.TxtBoxEmail_Update.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxEmail_Update.TabIndex = 8;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(614, 73);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update ";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // grpBxSortBy
            // 
            this.grpBxSortBy.Controls.Add(this.RdnAsc);
            this.grpBxSortBy.Controls.Add(this.RdnDesc);
            this.grpBxSortBy.Location = new System.Drawing.Point(192, 147);
            this.grpBxSortBy.Name = "grpBxSortBy";
            this.grpBxSortBy.Size = new System.Drawing.Size(200, 100);
            this.grpBxSortBy.TabIndex = 7;
            this.grpBxSortBy.TabStop = false;
            this.grpBxSortBy.Text = "According to:";
            // 
            // RdnAsc
            // 
            this.RdnAsc.AutoSize = true;
            this.RdnAsc.Location = new System.Drawing.Point(33, 23);
            this.RdnAsc.Name = "RdnAsc";
            this.RdnAsc.Size = new System.Drawing.Size(85, 20);
            this.RdnAsc.TabIndex = 6;
            this.RdnAsc.TabStop = true;
            this.RdnAsc.Text = "Asceding";
            this.RdnAsc.UseVisualStyleBackColor = true;
            // 
            // RdnDesc
            // 
            this.RdnDesc.AutoSize = true;
            this.RdnDesc.Location = new System.Drawing.Point(33, 64);
            this.RdnDesc.Name = "RdnDesc";
            this.RdnDesc.Size = new System.Drawing.Size(94, 20);
            this.RdnDesc.TabIndex = 5;
            this.RdnDesc.TabStop = true;
            this.RdnDesc.Text = "Desceding";
            this.RdnDesc.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(614, 17);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtFName_Update
            // 
            this.TxtFName_Update.Location = new System.Drawing.Point(151, 32);
            this.TxtFName_Update.Name = "TxtFName_Update";
            this.TxtFName_Update.Size = new System.Drawing.Size(100, 22);
            this.TxtFName_Update.TabIndex = 3;
            // 
            // LblGroupBY
            // 
            this.LblGroupBY.AutoSize = true;
            this.LblGroupBY.Location = new System.Drawing.Point(46, 156);
            this.LblGroupBY.Name = "LblGroupBY";
            this.LblGroupBY.Size = new System.Drawing.Size(140, 16);
            this.LblGroupBY.TabIndex = 1;
            this.LblGroupBY.Text = "Sort by Last Names in:";
            // 
            // LblFName_Update
            // 
            this.LblFName_Update.AutoSize = true;
            this.LblFName_Update.Location = new System.Drawing.Point(65, 38);
            this.LblFName_Update.Name = "LblFName_Update";
            this.LblFName_Update.Size = new System.Drawing.Size(75, 16);
            this.LblFName_Update.TabIndex = 0;
            this.LblFName_Update.Text = "First Name:";
            // 
            // tbPageDeleteGuest
            // 
            this.tbPageDeleteGuest.Controls.Add(this.groupBox1);
            this.tbPageDeleteGuest.Controls.Add(this.txtFName_Delete);
            this.tbPageDeleteGuest.Controls.Add(this.label2);
            this.tbPageDeleteGuest.Controls.Add(this.label1);
            this.tbPageDeleteGuest.Controls.Add(this.BtnReset_Delet);
            this.tbPageDeleteGuest.Controls.Add(this.BtnDelete);
            this.tbPageDeleteGuest.Location = new System.Drawing.Point(4, 25);
            this.tbPageDeleteGuest.Name = "tbPageDeleteGuest";
            this.tbPageDeleteGuest.Size = new System.Drawing.Size(754, 250);
            this.tbPageDeleteGuest.TabIndex = 3;
            this.tbPageDeleteGuest.Text = "DELETE GUEST";
            this.tbPageDeleteGuest.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdnBtnAscDelete);
            this.groupBox1.Controls.Add(this.RdnBtnDescDelete);
            this.groupBox1.Location = new System.Drawing.Point(227, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "According to:";
            // 
            // RdnBtnAscDelete
            // 
            this.RdnBtnAscDelete.AutoSize = true;
            this.RdnBtnAscDelete.Location = new System.Drawing.Point(6, 28);
            this.RdnBtnAscDelete.Name = "RdnBtnAscDelete";
            this.RdnBtnAscDelete.Size = new System.Drawing.Size(85, 20);
            this.RdnBtnAscDelete.TabIndex = 2;
            this.RdnBtnAscDelete.TabStop = true;
            this.RdnBtnAscDelete.Text = "Asceding";
            this.RdnBtnAscDelete.UseVisualStyleBackColor = true;
            this.RdnBtnAscDelete.CheckedChanged += new System.EventHandler(this.RdnBtnAscDelete_CheckedChanged);
            // 
            // RdnBtnDescDelete
            // 
            this.RdnBtnDescDelete.AutoSize = true;
            this.RdnBtnDescDelete.Location = new System.Drawing.Point(6, 59);
            this.RdnBtnDescDelete.Name = "RdnBtnDescDelete";
            this.RdnBtnDescDelete.Size = new System.Drawing.Size(94, 20);
            this.RdnBtnDescDelete.TabIndex = 3;
            this.RdnBtnDescDelete.TabStop = true;
            this.RdnBtnDescDelete.Text = "Desceding";
            this.RdnBtnDescDelete.UseVisualStyleBackColor = true;
            // 
            // txtFName_Delete
            // 
            this.txtFName_Delete.Location = new System.Drawing.Point(165, 30);
            this.txtFName_Delete.Name = "txtFName_Delete";
            this.txtFName_Delete.Size = new System.Drawing.Size(100, 22);
            this.txtFName_Delete.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sort according to Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guest First Name:";
            // 
            // BtnReset_Delet
            // 
            this.BtnReset_Delet.Location = new System.Drawing.Point(626, 23);
            this.BtnReset_Delet.Name = "BtnReset_Delet";
            this.BtnReset_Delet.Size = new System.Drawing.Size(75, 23);
            this.BtnReset_Delet.TabIndex = 1;
            this.BtnReset_Delet.Text = "Reset";
            this.BtnReset_Delet.UseVisualStyleBackColor = true;
            this.BtnReset_Delet.Click += new System.EventHandler(this.BtnReset_Delet_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(626, 91);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleName = "tbPgSearch";
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(754, 250);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "SEARCH GUEST";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(169, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(53, 21);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(44, 16);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "label3";
            // 
            // DgvGuests
            // 
            this.DgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGuests.Location = new System.Drawing.Point(38, 343);
            this.DgvGuests.Name = "DgvGuests";
            this.DgvGuests.RowHeadersWidth = 51;
            this.DgvGuests.RowTemplate.Height = 24;
            this.DgvGuests.Size = new System.Drawing.Size(1167, 215);
            this.DgvGuests.TabIndex = 2;
            // 
            // Guests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 592);
            this.Controls.Add(this.DgvGuests);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpBoxMenu);
            this.Name = "Guests";
            this.Text = "Guests";
            this.grpBoxMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbPgAddGuest.ResumeLayout(false);
            this.tbPgAddGuest.PerformLayout();
            this.tbPgUpdateGuest.ResumeLayout(false);
            this.tbPgUpdateGuest.PerformLayout();
            this.grpBxSortBy.ResumeLayout(false);
            this.grpBxSortBy.PerformLayout();
            this.tbPageDeleteGuest.ResumeLayout(false);
            this.tbPageDeleteGuest.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnDeleteGuest;
        private System.Windows.Forms.Button BtnUpdatePage;
        private System.Windows.Forms.Button BtnAddPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPgAddGuest;
        private System.Windows.Forms.TabPage tbPgUpdateGuest;
        private System.Windows.Forms.TabPage tbPageDeleteGuest;
        private System.Windows.Forms.DataGridView DgvGuests;
        private System.Windows.Forms.Label lblFNameAdd;
        private System.Windows.Forms.Label lblLNameAdd;
        private System.Windows.Forms.Label LblContactNo;
        private System.Windows.Forms.Label LblEmailAddress;
        private System.Windows.Forms.Button BtnAddGuest;
        private System.Windows.Forms.TextBox TxtFName_Add;
        private System.Windows.Forms.TextBox TxtLName_Add;
        private System.Windows.Forms.TextBox TxtContactNo_Add;
        private System.Windows.Forms.TextBox TxtEmail_Add;
        private System.Windows.Forms.GroupBox grpBxSortBy;
        private System.Windows.Forms.RadioButton RdnAsc;
        private System.Windows.Forms.RadioButton RdnDesc;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox TxtFName_Update;
        private System.Windows.Forms.Label LblGroupBY;
        private System.Windows.Forms.Label LblFName_Update;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdnBtnAscDelete;
        private System.Windows.Forms.RadioButton RdnBtnDescDelete;
        private System.Windows.Forms.TextBox txtFName_Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReset_Delet;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtLName_Update;
        private System.Windows.Forms.TextBox TxtContactNo_Update;
        private System.Windows.Forms.TextBox TxtBoxEmail_Update;
        private System.Windows.Forms.Label LblEmail_Update;
        private System.Windows.Forms.Label LblContactNo_Update;
        private System.Windows.Forms.Label LblLName_Update;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox textBox1;
    }
}

