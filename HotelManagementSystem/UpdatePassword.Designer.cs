namespace HotelManagementSystem
{
    partial class UpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePassword));
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword2 = new System.Windows.Forms.TextBox();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Wheat;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(215, 142);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(148, 25);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password:";
            this.lblNewPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(148, 194);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(215, 25);
            this.lblConfirmNewPassword.TabIndex = 2;
            this.lblConfirmNewPassword.Text = "Confirm New Password";
            this.lblConfirmNewPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(371, 145);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(235, 22);
            this.txtNewPassword.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtNewPassword, "Enter new password that follows password policies");
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.Location = new System.Drawing.Point(371, 199);
            this.txtNewPassword2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.Size = new System.Drawing.Size(235, 22);
            this.txtNewPassword2.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtNewPassword2, "Retype password entered above");
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(237, 290);
            this.btnUpdatePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(284, 53);
            this.btnUpdatePassword.TabIndex = 5;
            this.btnUpdatePassword.Text = "Update Password";
            this.toolTip1.SetToolTip(this.btnUpdatePassword, "Click to Update Password");
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.Update_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 447);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnLanguage
            // 
            this.btnLanguage.Location = new System.Drawing.Point(237, 351);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(284, 47);
            this.btnLanguage.TabIndex = 7;
            this.btnLanguage.Text = "LANGUAGE";
            this.toolTip1.SetToolTip(this.btnLanguage, "Click to change Languages");
            this.btnLanguage.UseVisualStyleBackColor = true;
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.txtNewPassword2);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblConfirmNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdatePassword";
            this.Text = "UpdatePassword";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword2;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}