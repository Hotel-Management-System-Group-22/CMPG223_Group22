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
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.txtGuest_Departure = new System.Windows.Forms.TextBox();
            this.TxtBooking_ID = new System.Windows.Forms.TextBox();
            this.txtGuest_Arrival = new System.Windows.Forms.TextBox();
            this.TxtRoom_ID = new System.Windows.Forms.TextBox();
            this.BtnAddBooking = new System.Windows.Forms.Button();
            this.BtnEditBooking = new System.Windows.Forms.Button();
            this.BtnDeleteBooking = new System.Windows.Forms.Button();
            this.BtnCancelBooking = new System.Windows.Forms.Button();
            this.lblGuestDeparture = new System.Windows.Forms.Label();
            this.lblGuestArrival = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.TxtGuest_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookings
            // 
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(12, 12);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.RowTemplate.Height = 24;
            this.dgvBookings.Size = new System.Drawing.Size(507, 321);
            this.dgvBookings.TabIndex = 0;
            // 
            // txtGuest_Departure
            // 
            this.txtGuest_Departure.Location = new System.Drawing.Point(646, 242);
            this.txtGuest_Departure.Name = "txtGuest_Departure";
            this.txtGuest_Departure.Size = new System.Drawing.Size(100, 22);
            this.txtGuest_Departure.TabIndex = 1;
            // 
            // TxtBooking_ID
            // 
            this.TxtBooking_ID.Location = new System.Drawing.Point(646, 35);
            this.TxtBooking_ID.Name = "TxtBooking_ID";
            this.TxtBooking_ID.Size = new System.Drawing.Size(100, 22);
            this.TxtBooking_ID.TabIndex = 3;
            // 
            // txtGuest_Arrival
            // 
            this.txtGuest_Arrival.Location = new System.Drawing.Point(646, 181);
            this.txtGuest_Arrival.Name = "txtGuest_Arrival";
            this.txtGuest_Arrival.Size = new System.Drawing.Size(100, 22);
            this.txtGuest_Arrival.TabIndex = 4;
            // 
            // TxtRoom_ID
            // 
            this.TxtRoom_ID.Location = new System.Drawing.Point(646, 134);
            this.TxtRoom_ID.Name = "TxtRoom_ID";
            this.TxtRoom_ID.Size = new System.Drawing.Size(100, 22);
            this.TxtRoom_ID.TabIndex = 5;
            // 
            // BtnAddBooking
            // 
            this.BtnAddBooking.Location = new System.Drawing.Point(33, 377);
            this.BtnAddBooking.Name = "BtnAddBooking";
            this.BtnAddBooking.Size = new System.Drawing.Size(75, 23);
            this.BtnAddBooking.TabIndex = 6;
            this.BtnAddBooking.Text = "Add Booking ";
            this.BtnAddBooking.UseVisualStyleBackColor = true;
            // 
            // BtnEditBooking
            // 
            this.BtnEditBooking.Location = new System.Drawing.Point(168, 377);
            this.BtnEditBooking.Name = "BtnEditBooking";
            this.BtnEditBooking.Size = new System.Drawing.Size(75, 23);
            this.BtnEditBooking.TabIndex = 7;
            this.BtnEditBooking.Text = "Edit Booking";
            this.BtnEditBooking.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteBooking
            // 
            this.BtnDeleteBooking.Location = new System.Drawing.Point(333, 377);
            this.BtnDeleteBooking.Name = "BtnDeleteBooking";
            this.BtnDeleteBooking.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteBooking.TabIndex = 8;
            this.BtnDeleteBooking.Text = "Delete Booking ";
            this.BtnDeleteBooking.UseVisualStyleBackColor = true;
            // 
            // BtnCancelBooking
            // 
            this.BtnCancelBooking.Location = new System.Drawing.Point(479, 377);
            this.BtnCancelBooking.Name = "BtnCancelBooking";
            this.BtnCancelBooking.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelBooking.TabIndex = 9;
            this.BtnCancelBooking.Text = "Cancel";
            this.BtnCancelBooking.UseVisualStyleBackColor = true;
            // 
            // lblGuestDeparture
            // 
            this.lblGuestDeparture.AutoSize = true;
            this.lblGuestDeparture.Location = new System.Drawing.Point(554, 242);
            this.lblGuestDeparture.Name = "lblGuestDeparture";
            this.lblGuestDeparture.Size = new System.Drawing.Size(44, 16);
            this.lblGuestDeparture.TabIndex = 11;
            this.lblGuestDeparture.Text = "label1";
            // 
            // lblGuestArrival
            // 
            this.lblGuestArrival.AutoSize = true;
            this.lblGuestArrival.Location = new System.Drawing.Point(554, 187);
            this.lblGuestArrival.Name = "lblGuestArrival";
            this.lblGuestArrival.Size = new System.Drawing.Size(44, 16);
            this.lblGuestArrival.TabIndex = 12;
            this.lblGuestArrival.Text = "label2";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(554, 134);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(44, 16);
            this.lblRoomID.TabIndex = 13;
            this.lblRoomID.Text = "label3";
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Location = new System.Drawing.Point(554, 80);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(44, 16);
            this.lblGuestID.TabIndex = 14;
            this.lblGuestID.Text = "label4";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(554, 35);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(44, 16);
            this.lblBookingID.TabIndex = 15;
            this.lblBookingID.Text = "label5";
            // 
            // TxtGuest_ID
            // 
            this.TxtGuest_ID.Location = new System.Drawing.Point(646, 80);
            this.TxtGuest_ID.Name = "TxtGuest_ID";
            this.TxtGuest_ID.Size = new System.Drawing.Size(100, 22);
            this.TxtGuest_ID.TabIndex = 16;
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtGuest_ID);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.lblGuestArrival);
            this.Controls.Add(this.lblGuestDeparture);
            this.Controls.Add(this.BtnCancelBooking);
            this.Controls.Add(this.BtnDeleteBooking);
            this.Controls.Add(this.BtnEditBooking);
            this.Controls.Add(this.BtnAddBooking);
            this.Controls.Add(this.TxtRoom_ID);
            this.Controls.Add(this.txtGuest_Arrival);
            this.Controls.Add(this.TxtBooking_ID);
            this.Controls.Add(this.txtGuest_Departure);
            this.Controls.Add(this.dgvBookings);
            this.Name = "Bookings";
            this.Text = "Bookings";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.TextBox txtGuest_Departure;
        private System.Windows.Forms.TextBox TxtBooking_ID;
        private System.Windows.Forms.TextBox txtGuest_Arrival;
        private System.Windows.Forms.TextBox TxtRoom_ID;
        private System.Windows.Forms.Button BtnAddBooking;
        private System.Windows.Forms.Button BtnEditBooking;
        private System.Windows.Forms.Button BtnDeleteBooking;
        private System.Windows.Forms.Button BtnCancelBooking;
        private System.Windows.Forms.Label lblGuestDeparture;
        private System.Windows.Forms.Label lblGuestArrival;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox TxtGuest_ID;
    }
}