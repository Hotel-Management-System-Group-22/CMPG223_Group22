namespace HotelManagementSystem
{
    partial class ClerkMenu
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
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnGuests = new System.Windows.Forms.Button();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(174, 258);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(253, 44);
            this.btnCheckOut.TabIndex = 15;
            this.btnCheckOut.Text = "Check Guests out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(174, 210);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(253, 44);
            this.btnCheckIn.TabIndex = 14;
            this.btnCheckIn.Text = "Check Guest In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Location = new System.Drawing.Point(174, 161);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(253, 44);
            this.btnBookings.TabIndex = 12;
            this.btnBookings.Text = "Maintain Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(174, 112);
            this.btnRooms.Margin = new System.Windows.Forms.Padding(2);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(253, 44);
            this.btnRooms.TabIndex = 11;
            this.btnRooms.Text = "Maintain Rooms";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuests
            // 
            this.btnGuests.Location = new System.Drawing.Point(174, 63);
            this.btnGuests.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuests.Name = "btnGuests";
            this.btnGuests.Size = new System.Drawing.Size(253, 44);
            this.btnGuests.TabIndex = 9;
            this.btnGuests.Text = "Maintain Guests";
            this.btnGuests.UseVisualStyleBackColor = true;
            this.btnGuests.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.Location = new System.Drawing.Point(504, 326);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(76, 30);
            this.btnLanguage.TabIndex = 16;
            this.btnLanguage.Text = "Afrikaans";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // ClerkMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnGuests);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClerkMenu";
            this.Text = "ClerkMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnGuests;
        private System.Windows.Forms.Button btnLanguage;
    }
}