namespace HotelManagementSystem
{
    partial class AdminMenu
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
            this.btnGuests = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuests
            // 
            this.btnGuests.Location = new System.Drawing.Point(180, 12);
            this.btnGuests.Name = "btnGuests";
            this.btnGuests.Size = new System.Drawing.Size(337, 54);
            this.btnGuests.TabIndex = 2;
            this.btnGuests.Text = "Maintain Guests";
            this.btnGuests.UseVisualStyleBackColor = true;
            this.btnGuests.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(180, 72);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(337, 54);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Maintain Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(180, 132);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(337, 54);
            this.btnRooms.TabIndex = 4;
            this.btnRooms.Text = "Maintain Rooms";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Location = new System.Drawing.Point(180, 192);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(337, 54);
            this.btnBookings.TabIndex = 5;
            this.btnBookings.Text = "Maintain Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.Location = new System.Drawing.Point(180, 252);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(337, 54);
            this.btnJobs.TabIndex = 6;
            this.btnJobs.Text = "Maintain Jobs";
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(180, 312);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(337, 54);
            this.btnCheckIn.TabIndex = 7;
            this.btnCheckIn.Text = "Check Guest In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(180, 430);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(337, 54);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Request Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(180, 370);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(337, 54);
            this.btnCheckOut.TabIndex = 9;
            this.btnCheckOut.Text = "Check Guest Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.button8_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnJobs);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnGuests);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuests;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnCheckOut;
    }
}