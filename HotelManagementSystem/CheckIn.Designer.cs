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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.btnBookingUpdate = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.btnLanguage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(657, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Location = new System.Drawing.Point(83, 116);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(49, 13);
            this.lblGuestID.TabIndex = 7;
            this.lblGuestID.Text = "Guest ID";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(206, 68);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(100, 20);
            this.txtBookingID.TabIndex = 0;
            this.txtBookingID.TextChanged += new System.EventHandler(this.txtBookingID_TextChanged);
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(83, 68);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(60, 13);
            this.lblBookingID.TabIndex = 6;
            this.lblBookingID.Text = "Booking ID";
            // 
            // btnBookingUpdate
            // 
            this.btnBookingUpdate.Location = new System.Drawing.Point(590, 216);
            this.btnBookingUpdate.Name = "btnBookingUpdate";
            this.btnBookingUpdate.Size = new System.Drawing.Size(146, 32);
            this.btnBookingUpdate.TabIndex = 6;
            this.btnBookingUpdate.Text = "Update Booking Info";
            this.btnBookingUpdate.UseVisualStyleBackColor = true;
            this.btnBookingUpdate.Click += new System.EventHandler(this.btnBookingUpdate_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(381, 216);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(79, 32);
            this.btnCheckIn.TabIndex = 4;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(206, 163);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(100, 20);
            this.txtRoomID.TabIndex = 2;
            this.txtRoomID.TextChanged += new System.EventHandler(this.txtRoomID_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(489, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(206, 116);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(100, 20);
            this.txtGuestID.TabIndex = 1;
            this.txtGuestID.TextChanged += new System.EventHandler(this.txtGuestID_TextChanged);
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(83, 170);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(49, 13);
            this.lblRoomID.TabIndex = 8;
            this.lblRoomID.Text = "Room ID";
            // 
            // btnLanguage
            // 
            this.btnLanguage.Location = new System.Drawing.Point(668, 415);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(75, 23);
            this.btnLanguage.TabIndex = 21;
            this.btnLanguage.Text = "Afrikaans";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBookingUpdate);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.txtBookingID);
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Button btnBookingUpdate;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Button btnLanguage;
    }
}