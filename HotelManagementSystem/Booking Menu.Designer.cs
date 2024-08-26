namespace HotelManagementSystem
{
    partial class Booking_Menu
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
            this.rbNewGuest = new System.Windows.Forms.RadioButton();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.rbCheckIn = new System.Windows.Forms.RadioButton();
            this.rbCheckOut = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbNewGuest
            // 
            this.rbNewGuest.AutoSize = true;
            this.rbNewGuest.Location = new System.Drawing.Point(47, 33);
            this.rbNewGuest.Name = "rbNewGuest";
            this.rbNewGuest.Size = new System.Drawing.Size(78, 17);
            this.rbNewGuest.TabIndex = 0;
            this.rbNewGuest.TabStop = true;
            this.rbNewGuest.Text = "New Guest";
            this.rbNewGuest.UseVisualStyleBackColor = true;
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(253, 33);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(115, 17);
            this.rbUpdate.TabIndex = 1;
            this.rbUpdate.TabStop = true;
            this.rbUpdate.Text = "Update Information";
            this.rbUpdate.UseVisualStyleBackColor = true;
            // 
            // rbCheckIn
            // 
            this.rbCheckIn.AutoSize = true;
            this.rbCheckIn.Location = new System.Drawing.Point(47, 70);
            this.rbCheckIn.Name = "rbCheckIn";
            this.rbCheckIn.Size = new System.Drawing.Size(68, 17);
            this.rbCheckIn.TabIndex = 2;
            this.rbCheckIn.TabStop = true;
            this.rbCheckIn.Text = "Check-In";
            this.rbCheckIn.UseVisualStyleBackColor = true;
            // 
            // rbCheckOut
            // 
            this.rbCheckOut.AutoSize = true;
            this.rbCheckOut.Location = new System.Drawing.Point(253, 70);
            this.rbCheckOut.Name = "rbCheckOut";
            this.rbCheckOut.Size = new System.Drawing.Size(76, 17);
            this.rbCheckOut.TabIndex = 3;
            this.rbCheckOut.TabStop = true;
            this.rbCheckOut.Text = "Check-Out";
            this.rbCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(386, 102);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(253, 102);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Booking_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 146);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rbCheckOut);
            this.Controls.Add(this.rbCheckIn);
            this.Controls.Add(this.rbUpdate);
            this.Controls.Add(this.rbNewGuest);
            this.Name = "Booking_Menu";
            this.Text = "Booking_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNewGuest;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.RadioButton rbCheckIn;
        private System.Windows.Forms.RadioButton rbCheckOut;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
    }
}