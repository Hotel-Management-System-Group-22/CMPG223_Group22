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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckOutCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCheckOutRoomID = new System.Windows.Forms.TextBox();
            this.txtCheckOutGuestID = new System.Windows.Forms.TextBox();
            this.txtCheckOutBookingID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Room ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Guest ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Booking ID";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(381, 225);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 14;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCheckOutCancel
            // 
            this.btnCheckOutCancel.Location = new System.Drawing.Point(86, 286);
            this.btnCheckOutCancel.Name = "btnCheckOutCancel";
            this.btnCheckOutCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOutCancel.TabIndex = 13;
            this.btnCheckOutCancel.Text = "Cancel";
            this.btnCheckOutCancel.UseVisualStyleBackColor = true;
            this.btnCheckOutCancel.Click += new System.EventHandler(this.btnCheckOutCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // txtCheckOutRoomID
            // 
            this.txtCheckOutRoomID.Location = new System.Drawing.Point(206, 162);
            this.txtCheckOutRoomID.Name = "txtCheckOutRoomID";
            this.txtCheckOutRoomID.Size = new System.Drawing.Size(100, 20);
            this.txtCheckOutRoomID.TabIndex = 11;
            // 
            // txtCheckOutGuestID
            // 
            this.txtCheckOutGuestID.Location = new System.Drawing.Point(206, 115);
            this.txtCheckOutGuestID.Name = "txtCheckOutGuestID";
            this.txtCheckOutGuestID.Size = new System.Drawing.Size(100, 20);
            this.txtCheckOutGuestID.TabIndex = 10;
            // 
            // txtCheckOutBookingID
            // 
            this.txtCheckOutBookingID.Location = new System.Drawing.Point(206, 67);
            this.txtCheckOutBookingID.Name = "txtCheckOutBookingID";
            this.txtCheckOutBookingID.Size = new System.Drawing.Size(100, 20);
            this.txtCheckOutBookingID.TabIndex = 9;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckOutCancel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtCheckOutRoomID);
            this.Controls.Add(this.txtCheckOutGuestID);
            this.Controls.Add(this.txtCheckOutBookingID);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckOutCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCheckOutRoomID;
        private System.Windows.Forms.TextBox txtCheckOutGuestID;
        private System.Windows.Forms.TextBox txtCheckOutBookingID;
    }
}