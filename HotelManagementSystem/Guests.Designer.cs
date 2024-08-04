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
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.txtGuest_Email = new System.Windows.Forms.TextBox();
            this.txtGuest_ContactNo = new System.Windows.Forms.TextBox();
            this.txtGuest_LName = new System.Windows.Forms.TextBox();
            this.txtGuestFName = new System.Windows.Forms.TextBox();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.LblContactNo = new System.Windows.Forms.Label();
            this.LblLName = new System.Windows.Forms.Label();
            this.LblFName = new System.Windows.Forms.Label();
            this.LblGuest = new System.Windows.Forms.Label();
            this.BtnAddGuest = new System.Windows.Forms.Button();
            this.BtnEditGuest = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancelGuest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuests
            // 
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(12, 23);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.RowHeadersWidth = 51;
            this.dgvGuests.RowTemplate.Height = 24;
            this.dgvGuests.Size = new System.Drawing.Size(405, 348);
            this.dgvGuests.TabIndex = 0;
            // 
            // txtGuest_Email
            // 
            this.txtGuest_Email.Location = new System.Drawing.Point(633, 368);
            this.txtGuest_Email.Name = "txtGuest_Email";
            this.txtGuest_Email.Size = new System.Drawing.Size(100, 22);
            this.txtGuest_Email.TabIndex = 1;
            // 
            // txtGuest_ContactNo
            // 
            this.txtGuest_ContactNo.Location = new System.Drawing.Point(633, 283);
            this.txtGuest_ContactNo.Name = "txtGuest_ContactNo";
            this.txtGuest_ContactNo.Size = new System.Drawing.Size(100, 22);
            this.txtGuest_ContactNo.TabIndex = 2;
            // 
            // txtGuest_LName
            // 
            this.txtGuest_LName.Location = new System.Drawing.Point(633, 213);
            this.txtGuest_LName.Name = "txtGuest_LName";
            this.txtGuest_LName.Size = new System.Drawing.Size(100, 22);
            this.txtGuest_LName.TabIndex = 3;
            // 
            // txtGuestFName
            // 
            this.txtGuestFName.Location = new System.Drawing.Point(633, 122);
            this.txtGuestFName.Name = "txtGuestFName";
            this.txtGuestFName.Size = new System.Drawing.Size(100, 22);
            this.txtGuestFName.TabIndex = 4;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(633, 47);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(100, 22);
            this.txtGuestID.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(510, 368);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // LblContactNo
            // 
            this.LblContactNo.AutoSize = true;
            this.LblContactNo.Location = new System.Drawing.Point(510, 289);
            this.LblContactNo.Name = "LblContactNo";
            this.LblContactNo.Size = new System.Drawing.Size(106, 16);
            this.LblContactNo.TabIndex = 7;
            this.LblContactNo.Text = "Contact Number:";
            // 
            // LblLName
            // 
            this.LblLName.AutoSize = true;
            this.LblLName.Location = new System.Drawing.Point(510, 219);
            this.LblLName.Name = "LblLName";
            this.LblLName.Size = new System.Drawing.Size(75, 16);
            this.LblLName.TabIndex = 8;
            this.LblLName.Text = "Last Name:";
            // 
            // LblFName
            // 
            this.LblFName.AutoSize = true;
            this.LblFName.Location = new System.Drawing.Point(510, 128);
            this.LblFName.Name = "LblFName";
            this.LblFName.Size = new System.Drawing.Size(75, 16);
            this.LblFName.TabIndex = 9;
            this.LblFName.Text = "First Name:";
            // 
            // LblGuest
            // 
            this.LblGuest.AutoSize = true;
            this.LblGuest.Location = new System.Drawing.Point(453, 53);
            this.LblGuest.Name = "LblGuest";
            this.LblGuest.Size = new System.Drawing.Size(132, 16);
            this.LblGuest.TabIndex = 10;
            this.LblGuest.Text = "Identification Number";
            // 
            // BtnAddGuest
            // 
            this.BtnAddGuest.Location = new System.Drawing.Point(12, 402);
            this.BtnAddGuest.Name = "BtnAddGuest";
            this.BtnAddGuest.Size = new System.Drawing.Size(75, 23);
            this.BtnAddGuest.TabIndex = 11;
            this.BtnAddGuest.Text = "Add Guest";
            this.BtnAddGuest.UseVisualStyleBackColor = true;
            // 
            // BtnEditGuest
            // 
            this.BtnEditGuest.Location = new System.Drawing.Point(116, 402);
            this.BtnEditGuest.Name = "BtnEditGuest";
            this.BtnEditGuest.Size = new System.Drawing.Size(75, 23);
            this.BtnEditGuest.TabIndex = 12;
            this.BtnEditGuest.Text = "Edit Guest";
            this.BtnEditGuest.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(251, 402);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Delete Guest";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnCancelGuest
            // 
            this.BtnCancelGuest.Location = new System.Drawing.Point(394, 402);
            this.BtnCancelGuest.Name = "BtnCancelGuest";
            this.BtnCancelGuest.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelGuest.TabIndex = 14;
            this.BtnCancelGuest.Text = "Cancel";
            this.BtnCancelGuest.UseVisualStyleBackColor = true;
            // 
            // Guests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelGuest);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEditGuest);
            this.Controls.Add(this.BtnAddGuest);
            this.Controls.Add(this.LblGuest);
            this.Controls.Add(this.LblFName);
            this.Controls.Add(this.LblLName);
            this.Controls.Add(this.LblContactNo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.txtGuestFName);
            this.Controls.Add(this.txtGuest_LName);
            this.Controls.Add(this.txtGuest_ContactNo);
            this.Controls.Add(this.txtGuest_Email);
            this.Controls.Add(this.dgvGuests);
            this.Name = "Guests";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.TextBox txtGuest_Email;
        private System.Windows.Forms.TextBox txtGuest_ContactNo;
        private System.Windows.Forms.TextBox txtGuest_LName;
        private System.Windows.Forms.TextBox txtGuestFName;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label LblContactNo;
        private System.Windows.Forms.Label LblLName;
        private System.Windows.Forms.Label LblFName;
        private System.Windows.Forms.Label LblGuest;
        private System.Windows.Forms.Button BtnAddGuest;
        private System.Windows.Forms.Button BtnEditGuest;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancelGuest;
    }
}

