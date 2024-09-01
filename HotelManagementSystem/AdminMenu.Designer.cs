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
            this.btnLanguage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuests
            // 
            this.btnGuests.Location = new System.Drawing.Point(135, 10);
            this.btnGuests.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuests.Name = "btnGuests";
            this.btnGuests.Size = new System.Drawing.Size(253, 44);
            this.btnGuests.TabIndex = 2;
            this.btnGuests.Text = "Maintain Guests";
            this.btnGuests.UseVisualStyleBackColor = true;
            this.btnGuests.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(135, 58);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(253, 44);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Maintain Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Location = new System.Drawing.Point(135, 107);
            this.btnRooms.Margin = new System.Windows.Forms.Padding(2);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(253, 44);
            this.btnRooms.TabIndex = 4;
            this.btnRooms.Text = "Maintain Rooms";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Location = new System.Drawing.Point(135, 156);
            this.btnBookings.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(253, 44);
            this.btnBookings.TabIndex = 5;
            this.btnBookings.Text = "Maintain Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.Location = new System.Drawing.Point(135, 205);
            this.btnJobs.Margin = new System.Windows.Forms.Padding(2);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(253, 44);
            this.btnJobs.TabIndex = 6;
            this.btnJobs.Text = "Maintain Jobs";
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(135, 254);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(253, 44);
            this.btnCheckIn.TabIndex = 7;
            this.btnCheckIn.Text = "Check Guest In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(135, 349);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(253, 44);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Request Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(135, 301);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(253, 44);
            this.btnCheckOut.TabIndex = 9;
            this.btnCheckOut.Text = "Check Guest Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.Location = new System.Drawing.Point(494, 371);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(86, 23);
            this.btnLanguage.TabIndex = 10;
            this.btnLanguage.Text = "Afrikaans";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(600, 403);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnJobs);
            this.Controls.Add(this.btnBookings);
            this.Controls.Add(this.btnRooms);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnGuests);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnLanguage;
    }
}