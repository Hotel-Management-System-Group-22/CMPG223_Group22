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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guests));
            this.grpBoxMenu = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnDeleteGuest = new System.Windows.Forms.Button();
            this.BtnUpdatePage = new System.Windows.Forms.Button();
            this.BtnAddPage = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbAddGuest = new System.Windows.Forms.TabPage();
            this.BtnAddGuest = new System.Windows.Forms.Button();
            this.TxtFName_Add = new System.Windows.Forms.TextBox();
            this.TxtLName_Add = new System.Windows.Forms.TextBox();
            this.TxtContactNo_Add = new System.Windows.Forms.TextBox();
            this.TxtEmail_Add = new System.Windows.Forms.TextBox();
            this.lblFNameAdd = new System.Windows.Forms.Label();
            this.lblLNameAdd = new System.Windows.Forms.Label();
            this.LblContactNo = new System.Windows.Forms.Label();
            this.LblEmailAddress = new System.Windows.Forms.Label();
            this.tbUpdateGuest = new System.Windows.Forms.TabPage();
            this.LblEmail_Update = new System.Windows.Forms.Label();
            this.LblContactNo_Update = new System.Windows.Forms.Label();
            this.LblLName_Update = new System.Windows.Forms.Label();
            this.TxtLName_Update = new System.Windows.Forms.TextBox();
            this.TxtContactNo_Update = new System.Windows.Forms.TextBox();
            this.TxtBoxEmail_Update = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.TxtFName_Update = new System.Windows.Forms.TextBox();
            this.LblFName_Update = new System.Windows.Forms.Label();
            this.tbDeleteGuest = new System.Windows.Forms.TabPage();
            this.cbConfirmation = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLName_delete = new System.Windows.Forms.TextBox();
            this.txtCellNr_Delete = new System.Windows.Forms.TextBox();
            this.txtEmail_Delete = new System.Windows.Forms.TextBox();
            this.txtFName_Delete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.tbSearchGuest = new System.Windows.Forms.TabPage();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoDsc = new System.Windows.Forms.RadioButton();
            this.rdoAsc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail_Search = new System.Windows.Forms.TextBox();
            this.rdoEmail = new System.Windows.Forms.RadioButton();
            this.txtContact_Search = new System.Windows.Forms.TextBox();
            this.rdoContact = new System.Windows.Forms.RadioButton();
            this.txtLName_Search = new System.Windows.Forms.TextBox();
            this.rdoFName = new System.Windows.Forms.RadioButton();
            this.txtFName_Search = new System.Windows.Forms.TextBox();
            this.rdoLName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.DgvGuests = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbAddGuest.SuspendLayout();
            this.tbUpdateGuest.SuspendLayout();
            this.tbDeleteGuest.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbSearchGuest.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxMenu
            // 
            this.grpBoxMenu.Controls.Add(this.button2);
            this.grpBoxMenu.Controls.Add(this.BtnDeleteGuest);
            this.grpBoxMenu.Controls.Add(this.BtnUpdatePage);
            this.grpBoxMenu.Controls.Add(this.BtnAddPage);
            this.grpBoxMenu.Location = new System.Drawing.Point(79, 183);
            this.grpBoxMenu.Name = "grpBoxMenu";
            this.grpBoxMenu.Size = new System.Drawing.Size(226, 238);
            this.grpBoxMenu.TabIndex = 0;
            this.grpBoxMenu.TabStop = false;
            this.grpBoxMenu.Text = "Menu";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "SEARCH GUEST";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnDeleteGuest
            // 
            this.BtnDeleteGuest.Location = new System.Drawing.Point(11, 123);
            this.BtnDeleteGuest.Name = "BtnDeleteGuest";
            this.BtnDeleteGuest.Size = new System.Drawing.Size(203, 46);
            this.BtnDeleteGuest.TabIndex = 3;
            this.BtnDeleteGuest.Text = "DELETE GUEST";
            this.BtnDeleteGuest.UseVisualStyleBackColor = true;
            this.BtnDeleteGuest.Click += new System.EventHandler(this.BtnDeleteGuest_Click);
            // 
            // BtnUpdatePage
            // 
            this.BtnUpdatePage.Location = new System.Drawing.Point(11, 64);
            this.BtnUpdatePage.Name = "BtnUpdatePage";
            this.BtnUpdatePage.Size = new System.Drawing.Size(203, 45);
            this.BtnUpdatePage.TabIndex = 2;
            this.BtnUpdatePage.Text = "UPDATE GUEST";
            this.BtnUpdatePage.UseVisualStyleBackColor = true;
            this.BtnUpdatePage.Click += new System.EventHandler(this.BtnUpdatePage_Click);
            // 
            // BtnAddPage
            // 
            this.BtnAddPage.Location = new System.Drawing.Point(11, 18);
            this.BtnAddPage.Name = "BtnAddPage";
            this.BtnAddPage.Size = new System.Drawing.Size(203, 40);
            this.BtnAddPage.TabIndex = 0;
            this.BtnAddPage.Text = "ADD GUEST";
            this.BtnAddPage.UseVisualStyleBackColor = true;
            this.BtnAddPage.Click += new System.EventHandler(this.BtnAddPage_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbAddGuest);
            this.tabControl1.Controls.Add(this.tbUpdateGuest);
            this.tabControl1.Controls.Add(this.tbDeleteGuest);
            this.tabControl1.Controls.Add(this.tbSearchGuest);
            this.tabControl1.Location = new System.Drawing.Point(413, 183);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 238);
            this.tabControl1.TabIndex = 1;
            // 
            // tbAddGuest
            // 
            this.tbAddGuest.Controls.Add(this.BtnAddGuest);
            this.tbAddGuest.Controls.Add(this.TxtFName_Add);
            this.tbAddGuest.Controls.Add(this.TxtLName_Add);
            this.tbAddGuest.Controls.Add(this.TxtContactNo_Add);
            this.tbAddGuest.Controls.Add(this.TxtEmail_Add);
            this.tbAddGuest.Controls.Add(this.lblFNameAdd);
            this.tbAddGuest.Controls.Add(this.lblLNameAdd);
            this.tbAddGuest.Controls.Add(this.LblContactNo);
            this.tbAddGuest.Controls.Add(this.LblEmailAddress);
            this.tbAddGuest.Location = new System.Drawing.Point(4, 25);
            this.tbAddGuest.Name = "tbAddGuest";
            this.tbAddGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddGuest.Size = new System.Drawing.Size(685, 209);
            this.tbAddGuest.TabIndex = 0;
            this.tbAddGuest.Text = "ADD GUEST";
            this.tbAddGuest.UseVisualStyleBackColor = true;
            // 
            // BtnAddGuest
            // 
            this.BtnAddGuest.Location = new System.Drawing.Point(500, 24);
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
            this.TxtFName_Add.TextChanged += new System.EventHandler(this.TxtFName_Add_TextChanged);
            // 
            // TxtLName_Add
            // 
            this.TxtLName_Add.Location = new System.Drawing.Point(114, 58);
            this.TxtLName_Add.Name = "TxtLName_Add";
            this.TxtLName_Add.Size = new System.Drawing.Size(100, 22);
            this.TxtLName_Add.TabIndex = 9;
            this.TxtLName_Add.TextChanged += new System.EventHandler(this.TxtLName_Add_TextChanged);
            // 
            // TxtContactNo_Add
            // 
            this.TxtContactNo_Add.Location = new System.Drawing.Point(127, 100);
            this.TxtContactNo_Add.Name = "TxtContactNo_Add";
            this.TxtContactNo_Add.Size = new System.Drawing.Size(100, 22);
            this.TxtContactNo_Add.TabIndex = 8;
            this.TxtContactNo_Add.TextChanged += new System.EventHandler(this.TxtContactNo_Add_TextChanged);
            // 
            // TxtEmail_Add
            // 
            this.TxtEmail_Add.Location = new System.Drawing.Point(127, 136);
            this.TxtEmail_Add.Name = "TxtEmail_Add";
            this.TxtEmail_Add.Size = new System.Drawing.Size(100, 22);
            this.TxtEmail_Add.TabIndex = 7;
            this.TxtEmail_Add.TextChanged += new System.EventHandler(this.TxtEmail_Add_TextChanged);
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
            this.LblContactNo.Size = new System.Drawing.Size(109, 16);
            this.LblContactNo.TabIndex = 5;
            this.LblContactNo.Text = "Contact Number: ";
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
            // tbUpdateGuest
            // 
            this.tbUpdateGuest.Controls.Add(this.LblEmail_Update);
            this.tbUpdateGuest.Controls.Add(this.LblContactNo_Update);
            this.tbUpdateGuest.Controls.Add(this.LblLName_Update);
            this.tbUpdateGuest.Controls.Add(this.TxtLName_Update);
            this.tbUpdateGuest.Controls.Add(this.TxtContactNo_Update);
            this.tbUpdateGuest.Controls.Add(this.TxtBoxEmail_Update);
            this.tbUpdateGuest.Controls.Add(this.BtnUpdate);
            this.tbUpdateGuest.Controls.Add(this.BtnReset);
            this.tbUpdateGuest.Controls.Add(this.TxtFName_Update);
            this.tbUpdateGuest.Controls.Add(this.LblFName_Update);
            this.tbUpdateGuest.Location = new System.Drawing.Point(4, 25);
            this.tbUpdateGuest.Name = "tbUpdateGuest";
            this.tbUpdateGuest.Size = new System.Drawing.Size(754, 250);
            this.tbUpdateGuest.TabIndex = 2;
            this.tbUpdateGuest.Text = "UPDATE GUEST";
            this.tbUpdateGuest.UseVisualStyleBackColor = true;
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
            this.TxtLName_Update.TextChanged += new System.EventHandler(this.TxtLName_Update_TextChanged);
            // 
            // TxtContactNo_Update
            // 
            this.TxtContactNo_Update.Location = new System.Drawing.Point(151, 88);
            this.TxtContactNo_Update.Name = "TxtContactNo_Update";
            this.TxtContactNo_Update.Size = new System.Drawing.Size(100, 22);
            this.TxtContactNo_Update.TabIndex = 9;
            this.TxtContactNo_Update.TextChanged += new System.EventHandler(this.TxtContactNo_Update_TextChanged);
            // 
            // TxtBoxEmail_Update
            // 
            this.TxtBoxEmail_Update.Location = new System.Drawing.Point(151, 119);
            this.TxtBoxEmail_Update.Name = "TxtBoxEmail_Update";
            this.TxtBoxEmail_Update.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxEmail_Update.TabIndex = 8;
            this.TxtBoxEmail_Update.TextChanged += new System.EventHandler(this.TxtBoxEmail_Update_TextChanged);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(160, 183);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update ";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(37, 183);
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
            this.TxtFName_Update.TextChanged += new System.EventHandler(this.TxtFName_Update_TextChanged);
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
            // tbDeleteGuest
            // 
            this.tbDeleteGuest.Controls.Add(this.cbConfirmation);
            this.tbDeleteGuest.Controls.Add(this.groupBox1);
            this.tbDeleteGuest.Controls.Add(this.BtnDelete);
            this.tbDeleteGuest.Location = new System.Drawing.Point(4, 25);
            this.tbDeleteGuest.Name = "tbDeleteGuest";
            this.tbDeleteGuest.Size = new System.Drawing.Size(754, 250);
            this.tbDeleteGuest.TabIndex = 3;
            this.tbDeleteGuest.Text = "DELETE GUEST";
            this.tbDeleteGuest.UseVisualStyleBackColor = true;
            // 
            // cbConfirmation
            // 
            this.cbConfirmation.AutoSize = true;
            this.cbConfirmation.Location = new System.Drawing.Point(469, 201);
            this.cbConfirmation.Name = "cbConfirmation";
            this.cbConfirmation.Size = new System.Drawing.Size(238, 20);
            this.cbConfirmation.TabIndex = 24;
            this.cbConfirmation.Text = "Is this the Guest you want to delete?";
            this.cbConfirmation.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLName_delete);
            this.groupBox1.Controls.Add(this.txtCellNr_Delete);
            this.groupBox1.Controls.Add(this.txtEmail_Delete);
            this.groupBox1.Controls.Add(this.txtFName_Delete);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(20, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 169);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirm Values";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Email Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Contact Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Last Name:\r\n";
            // 
            // txtLName_delete
            // 
            this.txtLName_delete.Location = new System.Drawing.Point(158, 64);
            this.txtLName_delete.Name = "txtLName_delete";
            this.txtLName_delete.ReadOnly = true;
            this.txtLName_delete.Size = new System.Drawing.Size(100, 22);
            this.txtLName_delete.TabIndex = 27;
            this.txtLName_delete.TextChanged += new System.EventHandler(this.txtLName_delete_TextChanged);
            // 
            // txtCellNr_Delete
            // 
            this.txtCellNr_Delete.Location = new System.Drawing.Point(158, 92);
            this.txtCellNr_Delete.Name = "txtCellNr_Delete";
            this.txtCellNr_Delete.ReadOnly = true;
            this.txtCellNr_Delete.Size = new System.Drawing.Size(100, 22);
            this.txtCellNr_Delete.TabIndex = 26;
            this.txtCellNr_Delete.TextChanged += new System.EventHandler(this.txtCellNr_Delete_TextChanged);
            // 
            // txtEmail_Delete
            // 
            this.txtEmail_Delete.Location = new System.Drawing.Point(158, 123);
            this.txtEmail_Delete.Name = "txtEmail_Delete";
            this.txtEmail_Delete.ReadOnly = true;
            this.txtEmail_Delete.Size = new System.Drawing.Size(100, 22);
            this.txtEmail_Delete.TabIndex = 25;
            this.txtEmail_Delete.TextChanged += new System.EventHandler(this.txtEmail_Delete_TextChanged);
            // 
            // txtFName_Delete
            // 
            this.txtFName_Delete.Location = new System.Drawing.Point(158, 36);
            this.txtFName_Delete.Name = "txtFName_Delete";
            this.txtFName_Delete.ReadOnly = true;
            this.txtFName_Delete.Size = new System.Drawing.Size(100, 22);
            this.txtFName_Delete.TabIndex = 24;
            this.txtFName_Delete.TextChanged += new System.EventHandler(this.txtFName_Delete_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "First Name:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(72, 201);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(202, 46);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // tbSearchGuest
            // 
            this.tbSearchGuest.AccessibleName = "tbPgSearch";
            this.tbSearchGuest.Controls.Add(this.btnResetSearch);
            this.tbSearchGuest.Controls.Add(this.groupBox3);
            this.tbSearchGuest.Controls.Add(this.groupBox2);
            this.tbSearchGuest.Controls.Add(this.btnSearch);
            this.tbSearchGuest.Location = new System.Drawing.Point(4, 25);
            this.tbSearchGuest.Name = "tbSearchGuest";
            this.tbSearchGuest.Size = new System.Drawing.Size(754, 250);
            this.tbSearchGuest.TabIndex = 4;
            this.tbSearchGuest.Text = "SEARCH GUEST";
            this.tbSearchGuest.UseVisualStyleBackColor = true;
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.Location = new System.Drawing.Point(471, 201);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(145, 42);
            this.btnResetSearch.TabIndex = 13;
            this.btnResetSearch.Text = "Reset";
            this.btnResetSearch.UseVisualStyleBackColor = true;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoDsc);
            this.groupBox3.Controls.Add(this.rdoAsc);
            this.groupBox3.Location = new System.Drawing.Point(581, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 121);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort by:";
            // 
            // rdoDsc
            // 
            this.rdoDsc.AutoSize = true;
            this.rdoDsc.Location = new System.Drawing.Point(20, 66);
            this.rdoDsc.Name = "rdoDsc";
            this.rdoDsc.Size = new System.Drawing.Size(101, 20);
            this.rdoDsc.TabIndex = 6;
            this.rdoDsc.TabStop = true;
            this.rdoDsc.Text = "Descending";
            this.rdoDsc.UseVisualStyleBackColor = true;
            // 
            // rdoAsc
            // 
            this.rdoAsc.AutoSize = true;
            this.rdoAsc.Location = new System.Drawing.Point(20, 34);
            this.rdoAsc.Name = "rdoAsc";
            this.rdoAsc.Size = new System.Drawing.Size(92, 20);
            this.rdoAsc.TabIndex = 3;
            this.rdoAsc.TabStop = true;
            this.rdoAsc.Text = "Ascending";
            this.rdoAsc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmail_Search);
            this.groupBox2.Controls.Add(this.rdoEmail);
            this.groupBox2.Controls.Add(this.txtContact_Search);
            this.groupBox2.Controls.Add(this.rdoContact);
            this.groupBox2.Controls.Add(this.txtLName_Search);
            this.groupBox2.Controls.Add(this.rdoFName);
            this.groupBox2.Controls.Add(this.txtFName_Search);
            this.groupBox2.Controls.Add(this.rdoLName);
            this.groupBox2.Location = new System.Drawing.Point(26, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 157);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by:";
            // 
            // txtEmail_Search
            // 
            this.txtEmail_Search.Location = new System.Drawing.Point(192, 129);
            this.txtEmail_Search.Name = "txtEmail_Search";
            this.txtEmail_Search.Size = new System.Drawing.Size(167, 22);
            this.txtEmail_Search.TabIndex = 11;
            // 
            // rdoEmail
            // 
            this.rdoEmail.AutoSize = true;
            this.rdoEmail.Location = new System.Drawing.Point(20, 129);
            this.rdoEmail.Name = "rdoEmail";
            this.rdoEmail.Size = new System.Drawing.Size(100, 20);
            this.rdoEmail.TabIndex = 10;
            this.rdoEmail.TabStop = true;
            this.rdoEmail.Text = "Guest Email";
            this.rdoEmail.UseVisualStyleBackColor = true;
            this.rdoEmail.CheckedChanged += new System.EventHandler(this.rdoEmail_CheckedChanged);
            // 
            // txtContact_Search
            // 
            this.txtContact_Search.Location = new System.Drawing.Point(192, 101);
            this.txtContact_Search.Name = "txtContact_Search";
            this.txtContact_Search.Size = new System.Drawing.Size(167, 22);
            this.txtContact_Search.TabIndex = 9;
            // 
            // rdoContact
            // 
            this.rdoContact.AutoSize = true;
            this.rdoContact.Location = new System.Drawing.Point(20, 101);
            this.rdoContact.Name = "rdoContact";
            this.rdoContact.Size = new System.Drawing.Size(162, 20);
            this.rdoContact.TabIndex = 8;
            this.rdoContact.TabStop = true;
            this.rdoContact.Text = "Guest Contact Number";
            this.rdoContact.UseVisualStyleBackColor = true;
            this.rdoContact.CheckedChanged += new System.EventHandler(this.rdoContact_CheckedChanged);
            // 
            // txtLName_Search
            // 
            this.txtLName_Search.Location = new System.Drawing.Point(192, 32);
            this.txtLName_Search.Name = "txtLName_Search";
            this.txtLName_Search.Size = new System.Drawing.Size(167, 22);
            this.txtLName_Search.TabIndex = 7;
            // 
            // rdoFName
            // 
            this.rdoFName.AutoSize = true;
            this.rdoFName.Location = new System.Drawing.Point(20, 66);
            this.rdoFName.Name = "rdoFName";
            this.rdoFName.Size = new System.Drawing.Size(131, 20);
            this.rdoFName.TabIndex = 6;
            this.rdoFName.TabStop = true;
            this.rdoFName.Text = "Guest First Name";
            this.rdoFName.UseVisualStyleBackColor = true;
            this.rdoFName.CheckedChanged += new System.EventHandler(this.rdoFName_CheckedChanged);
            // 
            // txtFName_Search
            // 
            this.txtFName_Search.Location = new System.Drawing.Point(192, 64);
            this.txtFName_Search.Name = "txtFName_Search";
            this.txtFName_Search.Size = new System.Drawing.Size(167, 22);
            this.txtFName_Search.TabIndex = 5;
            // 
            // rdoLName
            // 
            this.rdoLName.AutoSize = true;
            this.rdoLName.Location = new System.Drawing.Point(20, 34);
            this.rdoLName.Name = "rdoLName";
            this.rdoLName.Size = new System.Drawing.Size(131, 20);
            this.rdoLName.TabIndex = 3;
            this.rdoLName.TabStop = true;
            this.rdoLName.Text = "Guest Last Name";
            this.rdoLName.UseVisualStyleBackColor = true;
            this.rdoLName.CheckedChanged += new System.EventHandler(this.rdoLName_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(471, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 42);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Submit_Click);
            // 
            // DgvGuests
            // 
            this.DgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGuests.Location = new System.Drawing.Point(79, 427);
            this.DgvGuests.Name = "DgvGuests";
            this.DgvGuests.RowHeadersWidth = 51;
            this.DgvGuests.RowTemplate.Height = 24;
            this.DgvGuests.Size = new System.Drawing.Size(1043, 221);
            this.DgvGuests.TabIndex = 2;
            this.DgvGuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGuests_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Guests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 648);
            this.Controls.Add(this.DgvGuests);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpBoxMenu);
            this.DoubleBuffered = true;
            this.Name = "Guests";
            this.Text = "Guests";
            this.Load += new System.EventHandler(this.Guests_Load);
            this.grpBoxMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbAddGuest.ResumeLayout(false);
            this.tbAddGuest.PerformLayout();
            this.tbUpdateGuest.ResumeLayout(false);
            this.tbUpdateGuest.PerformLayout();
            this.tbDeleteGuest.ResumeLayout(false);
            this.tbDeleteGuest.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbSearchGuest.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnDeleteGuest;
        private System.Windows.Forms.Button BtnUpdatePage;
        private System.Windows.Forms.Button BtnAddPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbAddGuest;
        private System.Windows.Forms.TabPage tbUpdateGuest;
        private System.Windows.Forms.TabPage tbDeleteGuest;
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
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TextBox TxtFName_Update;
        private System.Windows.Forms.Label LblFName_Update;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtLName_Update;
        private System.Windows.Forms.TextBox TxtContactNo_Update;
        private System.Windows.Forms.TextBox TxtBoxEmail_Update;
        private System.Windows.Forms.Label LblEmail_Update;
        private System.Windows.Forms.Label LblContactNo_Update;
        private System.Windows.Forms.Label LblLName_Update;
        private System.Windows.Forms.TabPage tbSearchGuest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoLName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLName_delete;
        private System.Windows.Forms.TextBox txtCellNr_Delete;
        private System.Windows.Forms.TextBox txtEmail_Delete;
        private System.Windows.Forms.TextBox txtFName_Delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbConfirmation;
        private System.Windows.Forms.TextBox txtEmail_Search;
        private System.Windows.Forms.RadioButton rdoEmail;
        private System.Windows.Forms.TextBox txtContact_Search;
        private System.Windows.Forms.RadioButton rdoContact;
        private System.Windows.Forms.TextBox txtLName_Search;
        private System.Windows.Forms.RadioButton rdoFName;
        private System.Windows.Forms.TextBox txtFName_Search;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoDsc;
        private System.Windows.Forms.RadioButton rdoAsc;
        private System.Windows.Forms.Button btnResetSearch;
    }
}

