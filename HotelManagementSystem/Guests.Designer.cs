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
            this.grpBoxMenu = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnDeleteGuest = new System.Windows.Forms.Button();
            this.BtnUpdatePage = new System.Windows.Forms.Button();
            this.BtnAddPage = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbAddGuest = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail_Search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContact_Search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLName_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName_Search = new System.Windows.Forms.TextBox();
            this.DgvGuests = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxMenu
            // 
            this.grpBoxMenu.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpBoxMenu.Controls.Add(this.button2);
            this.grpBoxMenu.Controls.Add(this.BtnDeleteGuest);
            this.grpBoxMenu.Controls.Add(this.BtnUpdatePage);
            this.grpBoxMenu.Controls.Add(this.BtnAddPage);
            this.grpBoxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxMenu.Location = new System.Drawing.Point(32, 104);
            this.grpBoxMenu.Name = "grpBoxMenu";
            this.grpBoxMenu.Size = new System.Drawing.Size(275, 277);
            this.grpBoxMenu.TabIndex = 0;
            this.grpBoxMenu.TabStop = false;
            this.grpBoxMenu.Text = "Menu";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "SEARCH GUEST";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnDeleteGuest
            // 
            this.BtnDeleteGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteGuest.Location = new System.Drawing.Point(11, 155);
            this.BtnDeleteGuest.Name = "BtnDeleteGuest";
            this.BtnDeleteGuest.Size = new System.Drawing.Size(254, 46);
            this.BtnDeleteGuest.TabIndex = 3;
            this.BtnDeleteGuest.Text = "DELETE GUEST";
            this.BtnDeleteGuest.UseVisualStyleBackColor = true;
            this.BtnDeleteGuest.Click += new System.EventHandler(this.BtnDeleteGuest_Click);
            // 
            // BtnUpdatePage
            // 
            this.BtnUpdatePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdatePage.Location = new System.Drawing.Point(11, 96);
            this.BtnUpdatePage.Name = "BtnUpdatePage";
            this.BtnUpdatePage.Size = new System.Drawing.Size(254, 45);
            this.BtnUpdatePage.TabIndex = 2;
            this.BtnUpdatePage.Text = "UPDATE GUEST";
            this.BtnUpdatePage.UseVisualStyleBackColor = true;
            this.BtnUpdatePage.Click += new System.EventHandler(this.BtnUpdatePage_Click);
            // 
            // BtnAddPage
            // 
            this.BtnAddPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPage.Location = new System.Drawing.Point(11, 33);
            this.BtnAddPage.Name = "BtnAddPage";
            this.BtnAddPage.Size = new System.Drawing.Size(254, 47);
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
            this.tabControl1.Location = new System.Drawing.Point(387, 127);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 258);
            this.tabControl1.TabIndex = 1;
            // 
            // tbAddGuest
            // 
            this.tbAddGuest.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbAddGuest.Controls.Add(this.button1);
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
            this.tbAddGuest.Size = new System.Drawing.Size(746, 229);
            this.tbAddGuest.TabIndex = 0;
            this.tbAddGuest.Text = "ADD GUEST";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(483, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnAddGuest
            // 
            this.BtnAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddGuest.Location = new System.Drawing.Point(483, 158);
            this.BtnAddGuest.Name = "BtnAddGuest";
            this.BtnAddGuest.Size = new System.Drawing.Size(243, 45);
            this.BtnAddGuest.TabIndex = 3;
            this.BtnAddGuest.Text = "Add Guest";
            this.BtnAddGuest.UseVisualStyleBackColor = true;
            this.BtnAddGuest.Click += new System.EventHandler(this.BtnAddGuest_Click);
            // 
            // TxtFName_Add
            // 
            this.TxtFName_Add.Location = new System.Drawing.Point(193, 45);
            this.TxtFName_Add.Name = "TxtFName_Add";
            this.TxtFName_Add.Size = new System.Drawing.Size(220, 22);
            this.TxtFName_Add.TabIndex = 10;
            this.TxtFName_Add.TextChanged += new System.EventHandler(this.TxtFName_Add_TextChanged);
            // 
            // TxtLName_Add
            // 
            this.TxtLName_Add.Location = new System.Drawing.Point(193, 87);
            this.TxtLName_Add.Name = "TxtLName_Add";
            this.TxtLName_Add.Size = new System.Drawing.Size(220, 22);
            this.TxtLName_Add.TabIndex = 9;
            this.TxtLName_Add.TextChanged += new System.EventHandler(this.TxtLName_Add_TextChanged);
            // 
            // TxtContactNo_Add
            // 
            this.TxtContactNo_Add.Location = new System.Drawing.Point(193, 132);
            this.TxtContactNo_Add.Name = "TxtContactNo_Add";
            this.TxtContactNo_Add.Size = new System.Drawing.Size(220, 22);
            this.TxtContactNo_Add.TabIndex = 8;
            this.TxtContactNo_Add.TextChanged += new System.EventHandler(this.TxtContactNo_Add_TextChanged);
            // 
            // TxtEmail_Add
            // 
            this.TxtEmail_Add.Location = new System.Drawing.Point(193, 168);
            this.TxtEmail_Add.Name = "TxtEmail_Add";
            this.TxtEmail_Add.Size = new System.Drawing.Size(220, 22);
            this.TxtEmail_Add.TabIndex = 7;
            this.TxtEmail_Add.TextChanged += new System.EventHandler(this.TxtEmail_Add_TextChanged);
            // 
            // lblFNameAdd
            // 
            this.lblFNameAdd.AutoSize = true;
            this.lblFNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNameAdd.Location = new System.Drawing.Point(73, 48);
            this.lblFNameAdd.Name = "lblFNameAdd";
            this.lblFNameAdd.Size = new System.Drawing.Size(112, 25);
            this.lblFNameAdd.TabIndex = 3;
            this.lblFNameAdd.Text = "First Name:\r\n";
            // 
            // lblLNameAdd
            // 
            this.lblLNameAdd.AutoSize = true;
            this.lblLNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLNameAdd.Location = new System.Drawing.Point(73, 87);
            this.lblLNameAdd.Name = "lblLNameAdd";
            this.lblLNameAdd.Size = new System.Drawing.Size(112, 25);
            this.lblLNameAdd.TabIndex = 4;
            this.lblLNameAdd.Text = "Last Name:";
            // 
            // LblContactNo
            // 
            this.LblContactNo.AutoSize = true;
            this.LblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactNo.Location = new System.Drawing.Point(20, 128);
            this.LblContactNo.Name = "LblContactNo";
            this.LblContactNo.Size = new System.Drawing.Size(165, 25);
            this.LblContactNo.TabIndex = 5;
            this.LblContactNo.Text = "Contact Number: ";
            // 
            // LblEmailAddress
            // 
            this.LblEmailAddress.AutoSize = true;
            this.LblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailAddress.Location = new System.Drawing.Point(38, 168);
            this.LblEmailAddress.Name = "LblEmailAddress";
            this.LblEmailAddress.Size = new System.Drawing.Size(149, 25);
            this.LblEmailAddress.TabIndex = 6;
            this.LblEmailAddress.Text = "Email Address: ";
            // 
            // tbUpdateGuest
            // 
            this.tbUpdateGuest.BackColor = System.Drawing.Color.PapayaWhip;
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
            this.tbUpdateGuest.Size = new System.Drawing.Size(746, 229);
            this.tbUpdateGuest.TabIndex = 2;
            this.tbUpdateGuest.Text = "UPDATE GUEST";
            // 
            // LblEmail_Update
            // 
            this.LblEmail_Update.AutoSize = true;
            this.LblEmail_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail_Update.Location = new System.Drawing.Point(34, 141);
            this.LblEmail_Update.Name = "LblEmail_Update";
            this.LblEmail_Update.Size = new System.Drawing.Size(144, 25);
            this.LblEmail_Update.TabIndex = 14;
            this.LblEmail_Update.Text = "Email Address:";
            // 
            // LblContactNo_Update
            // 
            this.LblContactNo_Update.AutoSize = true;
            this.LblContactNo_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactNo_Update.Location = new System.Drawing.Point(18, 107);
            this.LblContactNo_Update.Name = "LblContactNo_Update";
            this.LblContactNo_Update.Size = new System.Drawing.Size(160, 25);
            this.LblContactNo_Update.TabIndex = 13;
            this.LblContactNo_Update.Text = "Contact Number:";
            // 
            // LblLName_Update
            // 
            this.LblLName_Update.AutoSize = true;
            this.LblLName_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLName_Update.Location = new System.Drawing.Point(66, 67);
            this.LblLName_Update.Name = "LblLName_Update";
            this.LblLName_Update.Size = new System.Drawing.Size(112, 25);
            this.LblLName_Update.TabIndex = 12;
            this.LblLName_Update.Text = "Last Name:\r\n";
            // 
            // TxtLName_Update
            // 
            this.TxtLName_Update.Location = new System.Drawing.Point(196, 71);
            this.TxtLName_Update.Name = "TxtLName_Update";
            this.TxtLName_Update.Size = new System.Drawing.Size(214, 22);
            this.TxtLName_Update.TabIndex = 10;
            this.TxtLName_Update.TextChanged += new System.EventHandler(this.TxtLName_Update_TextChanged);
            // 
            // TxtContactNo_Update
            // 
            this.TxtContactNo_Update.Location = new System.Drawing.Point(196, 111);
            this.TxtContactNo_Update.Name = "TxtContactNo_Update";
            this.TxtContactNo_Update.Size = new System.Drawing.Size(214, 22);
            this.TxtContactNo_Update.TabIndex = 9;
            this.TxtContactNo_Update.TextChanged += new System.EventHandler(this.TxtContactNo_Update_TextChanged);
            // 
            // TxtBoxEmail_Update
            // 
            this.TxtBoxEmail_Update.Location = new System.Drawing.Point(196, 145);
            this.TxtBoxEmail_Update.Name = "TxtBoxEmail_Update";
            this.TxtBoxEmail_Update.Size = new System.Drawing.Size(214, 22);
            this.TxtBoxEmail_Update.TabIndex = 8;
            this.TxtBoxEmail_Update.TextChanged += new System.EventHandler(this.TxtBoxEmail_Update_TextChanged);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(475, 157);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(224, 43);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update ";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(475, 90);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(224, 43);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtFName_Update
            // 
            this.TxtFName_Update.Location = new System.Drawing.Point(196, 32);
            this.TxtFName_Update.Name = "TxtFName_Update";
            this.TxtFName_Update.Size = new System.Drawing.Size(214, 22);
            this.TxtFName_Update.TabIndex = 3;
            this.TxtFName_Update.TextChanged += new System.EventHandler(this.TxtFName_Update_TextChanged);
            // 
            // LblFName_Update
            // 
            this.LblFName_Update.AutoSize = true;
            this.LblFName_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFName_Update.Location = new System.Drawing.Point(66, 29);
            this.LblFName_Update.Name = "LblFName_Update";
            this.LblFName_Update.Size = new System.Drawing.Size(112, 25);
            this.LblFName_Update.TabIndex = 0;
            this.LblFName_Update.Text = "First Name:";
            // 
            // tbDeleteGuest
            // 
            this.tbDeleteGuest.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbDeleteGuest.Controls.Add(this.cbConfirmation);
            this.tbDeleteGuest.Controls.Add(this.groupBox1);
            this.tbDeleteGuest.Controls.Add(this.BtnDelete);
            this.tbDeleteGuest.Location = new System.Drawing.Point(4, 25);
            this.tbDeleteGuest.Name = "tbDeleteGuest";
            this.tbDeleteGuest.Size = new System.Drawing.Size(746, 229);
            this.tbDeleteGuest.TabIndex = 3;
            this.tbDeleteGuest.Text = "DELETE GUEST";
            // 
            // cbConfirmation
            // 
            this.cbConfirmation.AutoSize = true;
            this.cbConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConfirmation.Location = new System.Drawing.Point(440, 133);
            this.cbConfirmation.Name = "cbConfirmation";
            this.cbConfirmation.Size = new System.Drawing.Size(303, 24);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 200);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirm Values";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Email Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Contact Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Last Name:\r\n";
            // 
            // txtLName_delete
            // 
            this.txtLName_delete.BackColor = System.Drawing.SystemColors.Window;
            this.txtLName_delete.Location = new System.Drawing.Point(183, 74);
            this.txtLName_delete.Name = "txtLName_delete";
            this.txtLName_delete.ReadOnly = true;
            this.txtLName_delete.Size = new System.Drawing.Size(183, 30);
            this.txtLName_delete.TabIndex = 27;
            this.txtLName_delete.TextChanged += new System.EventHandler(this.txtLName_delete_TextChanged);
            // 
            // txtCellNr_Delete
            // 
            this.txtCellNr_Delete.BackColor = System.Drawing.SystemColors.Window;
            this.txtCellNr_Delete.Location = new System.Drawing.Point(183, 110);
            this.txtCellNr_Delete.Name = "txtCellNr_Delete";
            this.txtCellNr_Delete.ReadOnly = true;
            this.txtCellNr_Delete.Size = new System.Drawing.Size(183, 30);
            this.txtCellNr_Delete.TabIndex = 26;
            this.txtCellNr_Delete.TextChanged += new System.EventHandler(this.txtCellNr_Delete_TextChanged);
            // 
            // txtEmail_Delete
            // 
            this.txtEmail_Delete.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail_Delete.Location = new System.Drawing.Point(183, 155);
            this.txtEmail_Delete.Name = "txtEmail_Delete";
            this.txtEmail_Delete.ReadOnly = true;
            this.txtEmail_Delete.Size = new System.Drawing.Size(183, 30);
            this.txtEmail_Delete.TabIndex = 25;
            this.txtEmail_Delete.TextChanged += new System.EventHandler(this.txtEmail_Delete_TextChanged);
            // 
            // txtFName_Delete
            // 
            this.txtFName_Delete.BackColor = System.Drawing.SystemColors.Window;
            this.txtFName_Delete.Location = new System.Drawing.Point(183, 32);
            this.txtFName_Delete.Name = "txtFName_Delete";
            this.txtFName_Delete.ReadOnly = true;
            this.txtFName_Delete.Size = new System.Drawing.Size(183, 30);
            this.txtFName_Delete.TabIndex = 24;
            this.txtFName_Delete.TextChanged += new System.EventHandler(this.txtFName_Delete_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "First Name:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(522, 165);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(210, 46);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // tbSearchGuest
            // 
            this.tbSearchGuest.AccessibleName = "tbPgSearch";
            this.tbSearchGuest.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbSearchGuest.Controls.Add(this.btnResetSearch);
            this.tbSearchGuest.Controls.Add(this.groupBox3);
            this.tbSearchGuest.Controls.Add(this.groupBox2);
            this.tbSearchGuest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbSearchGuest.Location = new System.Drawing.Point(4, 25);
            this.tbSearchGuest.Name = "tbSearchGuest";
            this.tbSearchGuest.Size = new System.Drawing.Size(746, 229);
            this.tbSearchGuest.TabIndex = 4;
            this.tbSearchGuest.Text = "SEARCH GUEST";
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSearch.Location = new System.Drawing.Point(492, 184);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(239, 42);
            this.btnResetSearch.TabIndex = 13;
            this.btnResetSearch.Text = "Reset";
            this.btnResetSearch.UseVisualStyleBackColor = true;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoDsc);
            this.groupBox3.Controls.Add(this.rdoAsc);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(543, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 173);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort by:";
            // 
            // rdoDsc
            // 
            this.rdoDsc.AutoSize = true;
            this.rdoDsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDsc.Location = new System.Drawing.Point(9, 92);
            this.rdoDsc.Name = "rdoDsc";
            this.rdoDsc.Size = new System.Drawing.Size(137, 29);
            this.rdoDsc.TabIndex = 6;
            this.rdoDsc.TabStop = true;
            this.rdoDsc.Text = "Descending";
            this.rdoDsc.UseVisualStyleBackColor = true;
            this.rdoDsc.CheckedChanged += new System.EventHandler(this.rdoDsc_CheckedChanged);
            // 
            // rdoAsc
            // 
            this.rdoAsc.AutoSize = true;
            this.rdoAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAsc.Location = new System.Drawing.Point(9, 43);
            this.rdoAsc.Name = "rdoAsc";
            this.rdoAsc.Size = new System.Drawing.Size(126, 29);
            this.rdoAsc.TabIndex = 3;
            this.rdoAsc.TabStop = true;
            this.rdoAsc.Text = "Ascending";
            this.rdoAsc.UseVisualStyleBackColor = true;
            this.rdoAsc.CheckedChanged += new System.EventHandler(this.rdoAsc_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtEmail_Search);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtContact_Search);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLName_Search);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFName_Search);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Guest Email:";
            // 
            // txtEmail_Search
            // 
            this.txtEmail_Search.Location = new System.Drawing.Point(252, 139);
            this.txtEmail_Search.Name = "txtEmail_Search";
            this.txtEmail_Search.Size = new System.Drawing.Size(206, 30);
            this.txtEmail_Search.TabIndex = 11;
            this.txtEmail_Search.TextChanged += new System.EventHandler(this.txtEmail_Search_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Guest Contact Number:";
            // 
            // txtContact_Search
            // 
            this.txtContact_Search.Location = new System.Drawing.Point(252, 104);
            this.txtContact_Search.Name = "txtContact_Search";
            this.txtContact_Search.Size = new System.Drawing.Size(206, 30);
            this.txtContact_Search.TabIndex = 9;
            this.txtContact_Search.TextChanged += new System.EventHandler(this.txtContact_Search_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Guest First Name:";
            // 
            // txtLName_Search
            // 
            this.txtLName_Search.Location = new System.Drawing.Point(252, 29);
            this.txtLName_Search.Name = "txtLName_Search";
            this.txtLName_Search.Size = new System.Drawing.Size(206, 30);
            this.txtLName_Search.TabIndex = 7;
            this.txtLName_Search.TextChanged += new System.EventHandler(this.txtLName_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Guest Last Name:";
            // 
            // txtFName_Search
            // 
            this.txtFName_Search.Location = new System.Drawing.Point(252, 65);
            this.txtFName_Search.Name = "txtFName_Search";
            this.txtFName_Search.Size = new System.Drawing.Size(206, 30);
            this.txtFName_Search.TabIndex = 5;
            this.txtFName_Search.TextChanged += new System.EventHandler(this.txtFName_Search_TextChanged);
            // 
            // DgvGuests
            // 
            this.DgvGuests.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.DgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGuests.Location = new System.Drawing.Point(37, 391);
            this.DgvGuests.Name = "DgvGuests";
            this.DgvGuests.RowHeadersWidth = 51;
            this.DgvGuests.RowTemplate.Height = 24;
            this.DgvGuests.Size = new System.Drawing.Size(1134, 221);
            this.DgvGuests.TabIndex = 2;
            this.DgvGuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGuests_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox1.BackgroundImage = global::HotelManagementSystem.Properties.Resources.Maintain_Guests___1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-26, -59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1274, 707);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Location = new System.Drawing.Point(391, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 28);
            this.panel1.TabIndex = 25;
            // 
            // Guests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1231, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvGuests);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpBoxMenu);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txtContact_Search;
        private System.Windows.Forms.TextBox txtLName_Search;
        private System.Windows.Forms.TextBox txtFName_Search;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoDsc;
        private System.Windows.Forms.RadioButton rdoAsc;
        private System.Windows.Forms.Button btnResetSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

