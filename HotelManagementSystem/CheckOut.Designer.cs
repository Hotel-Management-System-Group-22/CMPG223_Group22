namespace HotelManagementSystem
{
    partial class CheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            this.lblBookingID = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckOutCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtGuestLName = new System.Windows.Forms.TextBox();
            this.txtGuestFName = new System.Windows.Forms.TextBox();
            this.txtCheckOutRoom = new System.Windows.Forms.TextBox();
            this.btnBookingUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBxCheckOut = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGuestLName = new System.Windows.Forms.Label();
            this.lblGuestFName = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBxCheckOut.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(13, 46);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(113, 25);
            this.lblBookingID.TabIndex = 15;
            this.lblBookingID.Text = "Booking ID:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(545, 87);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(227, 39);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Check Out";
            this.toolTip1.SetToolTip(this.btnCheckOut, "Click to Check-Out Guest");
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckOutCancel
            // 
            this.btnCheckOutCancel.Location = new System.Drawing.Point(545, 212);
            this.btnCheckOutCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOutCancel.Name = "btnCheckOutCancel";
            this.btnCheckOutCancel.Size = new System.Drawing.Size(227, 39);
            this.btnCheckOutCancel.TabIndex = 5;
            this.btnCheckOutCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnCheckOutCancel, "Click to cancle Checkout");
            this.btnCheckOutCancel.UseVisualStyleBackColor = true;
            this.btnCheckOutCancel.Click += new System.EventHandler(this.btnCheckOutCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 226);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(331, 30);
            this.dateTimePicker1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Select Check-Out Date");
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(164, 39);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(184, 30);
            this.txtBookingID.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtBookingID, "Enter Booking ID");
            this.txtBookingID.TextChanged += new System.EventHandler(this.txtBookingID_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 411);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 224);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnLanguage
            // 
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(936, 46);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(195, 46);
            this.btnLanguage.TabIndex = 20;
            this.btnLanguage.Text = "Afrikaans";
            this.toolTip1.SetToolTip(this.btnLanguage, "Click to change languages");
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // txtGuestLName
            // 
            this.txtGuestLName.BackColor = System.Drawing.SystemColors.Window;
            this.txtGuestLName.Location = new System.Drawing.Point(195, 106);
            this.txtGuestLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestLName.Name = "txtGuestLName";
            this.txtGuestLName.ReadOnly = true;
            this.txtGuestLName.Size = new System.Drawing.Size(191, 30);
            this.txtGuestLName.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtGuestLName, "Enter Guest ID");
            this.txtGuestLName.TextChanged += new System.EventHandler(this.txtGuestLName_TextChanged);
            // 
            // txtGuestFName
            // 
            this.txtGuestFName.BackColor = System.Drawing.SystemColors.Window;
            this.txtGuestFName.Location = new System.Drawing.Point(195, 68);
            this.txtGuestFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestFName.Name = "txtGuestFName";
            this.txtGuestFName.ReadOnly = true;
            this.txtGuestFName.Size = new System.Drawing.Size(191, 30);
            this.txtGuestFName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtGuestFName, "Enter Guest ID");
            this.txtGuestFName.TextChanged += new System.EventHandler(this.txtGuestFName_TextChanged);
            // 
            // txtCheckOutRoom
            // 
            this.txtCheckOutRoom.BackColor = System.Drawing.SystemColors.Window;
            this.txtCheckOutRoom.Location = new System.Drawing.Point(195, 31);
            this.txtCheckOutRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckOutRoom.Name = "txtCheckOutRoom";
            this.txtCheckOutRoom.ReadOnly = true;
            this.txtCheckOutRoom.Size = new System.Drawing.Size(191, 30);
            this.txtCheckOutRoom.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtCheckOutRoom, "Enter Room ID");
            this.txtCheckOutRoom.TextChanged += new System.EventHandler(this.txtCheckOutRoom_TextChanged);
            // 
            // btnBookingUpdate
            // 
            this.btnBookingUpdate.Location = new System.Drawing.Point(545, 138);
            this.btnBookingUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookingUpdate.Name = "btnBookingUpdate";
            this.btnBookingUpdate.Size = new System.Drawing.Size(227, 66);
            this.btnBookingUpdate.TabIndex = 6;
            this.btnBookingUpdate.Text = "Update or Search Booking Info";
            this.toolTip1.SetToolTip(this.btnBookingUpdate, "Click to Navigate to Bookings Form");
            this.btnBookingUpdate.UseVisualStyleBackColor = true;
            this.btnBookingUpdate.Click += new System.EventHandler(this.btnBookingUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1191, 670);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // grpBxCheckOut
            // 
            this.grpBxCheckOut.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpBxCheckOut.Controls.Add(this.groupBox1);
            this.grpBxCheckOut.Controls.Add(this.lblBookingID);
            this.grpBxCheckOut.Controls.Add(this.txtBookingID);
            this.grpBxCheckOut.Controls.Add(this.btnCheckOutCancel);
            this.grpBxCheckOut.Controls.Add(this.btnCheckOut);
            this.grpBxCheckOut.Controls.Add(this.btnBookingUpdate);
            this.grpBxCheckOut.Controls.Add(this.dateTimePicker1);
            this.grpBxCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxCheckOut.Location = new System.Drawing.Point(64, 130);
            this.grpBxCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxCheckOut.Name = "grpBxCheckOut";
            this.grpBxCheckOut.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxCheckOut.Size = new System.Drawing.Size(785, 258);
            this.grpBxCheckOut.TabIndex = 22;
            this.grpBxCheckOut.TabStop = false;
            this.grpBxCheckOut.Text = "Check - Out";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGuestLName);
            this.groupBox1.Controls.Add(this.lblGuestLName);
            this.groupBox1.Controls.Add(this.txtGuestFName);
            this.groupBox1.Controls.Add(this.lblGuestFName);
            this.groupBox1.Controls.Add(this.txtCheckOutRoom);
            this.groupBox1.Controls.Add(this.lblRoomID);
            this.groupBox1.Location = new System.Drawing.Point(19, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(519, 146);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Details";
            // 
            // lblGuestLName
            // 
            this.lblGuestLName.AutoSize = true;
            this.lblGuestLName.Location = new System.Drawing.Point(15, 108);
            this.lblGuestLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestLName.Name = "lblGuestLName";
            this.lblGuestLName.Size = new System.Drawing.Size(169, 25);
            this.lblGuestLName.TabIndex = 10;
            this.lblGuestLName.Text = "Guest Last Name:";
            // 
            // lblGuestFName
            // 
            this.lblGuestFName.AutoSize = true;
            this.lblGuestFName.Location = new System.Drawing.Point(15, 73);
            this.lblGuestFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestFName.Name = "lblGuestFName";
            this.lblGuestFName.Size = new System.Drawing.Size(169, 25);
            this.lblGuestFName.TabIndex = 7;
            this.lblGuestFName.Text = "Guest First Name:";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(15, 31);
            this.lblRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(143, 25);
            this.lblRoomID.TabIndex = 8;
            this.lblRoomID.Text = "Room Number:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(53, 41);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 670);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpBxCheckOut);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBxCheckOut.ResumeLayout(false);
            this.grpBxCheckOut.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckOutCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBxCheckOut;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGuestLName;
        private System.Windows.Forms.Label lblGuestLName;
        private System.Windows.Forms.TextBox txtGuestFName;
        private System.Windows.Forms.Label lblGuestFName;
        private System.Windows.Forms.TextBox txtCheckOutRoom;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Button btnBookingUpdate;
    }
}