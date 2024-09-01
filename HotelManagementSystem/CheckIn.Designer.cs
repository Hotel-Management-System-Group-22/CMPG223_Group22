namespace HotelManagementSystem
{
    partial class CheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGuestFName = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.btnBookingUpdate = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.txtRoomNr = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtGuestFName = new System.Windows.Forms.TextBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtGuestLName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBxCheckIn = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGuestLName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBxCheckIn.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 402);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 247);
            this.dataGridView1.TabIndex = 10;
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
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(197, 33);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(191, 30);
            this.txtBookingID.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtBookingID, "Enter Booking ID");
            this.txtBookingID.TextChanged += new System.EventHandler(this.txtBookingID_TextChanged);
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(19, 38);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(113, 25);
            this.lblBookingID.TabIndex = 6;
            this.lblBookingID.Text = "Booking ID:";
            // 
            // btnBookingUpdate
            // 
            this.btnBookingUpdate.Location = new System.Drawing.Point(560, 138);
            this.btnBookingUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookingUpdate.Name = "btnBookingUpdate";
            this.btnBookingUpdate.Size = new System.Drawing.Size(227, 58);
            this.btnBookingUpdate.TabIndex = 6;
            this.btnBookingUpdate.Text = "Update or Search Booking Info";
            this.toolTip1.SetToolTip(this.btnBookingUpdate, "Click to navigate to BOokings Form");
            this.btnBookingUpdate.UseVisualStyleBackColor = true;
            this.btnBookingUpdate.Click += new System.EventHandler(this.btnBookingUpdate_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(560, 87);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(227, 39);
            this.btnCheckIn.TabIndex = 4;
            this.btnCheckIn.Text = "Check In";
            this.toolTip1.SetToolTip(this.btnCheckIn, "Click to Check-In");
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // txtRoomNr
            // 
            this.txtRoomNr.BackColor = System.Drawing.SystemColors.Window;
            this.txtRoomNr.Location = new System.Drawing.Point(195, 31);
            this.txtRoomNr.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomNr.Name = "txtRoomNr";
            this.txtRoomNr.ReadOnly = true;
            this.txtRoomNr.Size = new System.Drawing.Size(191, 30);
            this.txtRoomNr.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtRoomNr, "Enter Room ID");
            this.txtRoomNr.TextChanged += new System.EventHandler(this.txtRoomID_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 224);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(325, 30);
            this.dateTimePicker1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Select Guest Check-In Date");
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(560, 209);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(227, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnCancel, "Click to cancle Check-In");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.txtGuestFName.TextChanged += new System.EventHandler(this.txtGuestID_TextChanged);
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
            // btnLanguage
            // 
            this.btnLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(1003, 39);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(4);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(195, 39);
            this.btnLanguage.TabIndex = 21;
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1261, 676);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grpBxCheckIn
            // 
            this.grpBxCheckIn.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpBxCheckIn.Controls.Add(this.groupBox1);
            this.grpBxCheckIn.Controls.Add(this.lblBookingID);
            this.grpBxCheckIn.Controls.Add(this.txtBookingID);
            this.grpBxCheckIn.Controls.Add(this.btnCancel);
            this.grpBxCheckIn.Controls.Add(this.btnBookingUpdate);
            this.grpBxCheckIn.Controls.Add(this.btnCheckIn);
            this.grpBxCheckIn.Controls.Add(this.dateTimePicker1);
            this.grpBxCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxCheckIn.Location = new System.Drawing.Point(71, 130);
            this.grpBxCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxCheckIn.Name = "grpBxCheckIn";
            this.grpBxCheckIn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxCheckIn.Size = new System.Drawing.Size(812, 265);
            this.grpBxCheckIn.TabIndex = 23;
            this.grpBxCheckIn.TabStop = false;
            this.grpBxCheckIn.Text = "Check - In";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGuestLName);
            this.groupBox1.Controls.Add(this.lblGuestLName);
            this.groupBox1.Controls.Add(this.txtGuestFName);
            this.groupBox1.Controls.Add(this.lblGuestFName);
            this.groupBox1.Controls.Add(this.txtRoomNr);
            this.groupBox1.Controls.Add(this.lblRoomID);
            this.groupBox1.Location = new System.Drawing.Point(24, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(519, 146);
            this.groupBox1.TabIndex = 11;
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
            this.lblGuestLName.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(53, 30);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 678);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpBxCheckIn);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBxCheckIn.ResumeLayout(false);
            this.grpBxCheckIn.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblGuestFName;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Button btnBookingUpdate;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.TextBox txtRoomNr;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtGuestFName;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBxCheckIn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblGuestLName;
        private System.Windows.Forms.TextBox txtGuestLName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}