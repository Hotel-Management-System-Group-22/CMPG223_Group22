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
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword2 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLanguage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(161, 115);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(81, 13);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password:";
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(128, 163);
            this.lblConfirmNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(116, 13);
            this.lblConfirmNewPassword.TabIndex = 2;
            this.lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(278, 112);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(153, 20);
            this.txtNewPassword.TabIndex = 3;
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.Location = new System.Drawing.Point(278, 158);
            this.txtNewPassword2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.Size = new System.Drawing.Size(153, 20);
            this.txtNewPassword2.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(178, 236);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(213, 43);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE PASSWORD";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.Update_Click);
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
            // btnLanguage
            // 
            this.btnLanguage.Location = new System.Drawing.Point(178, 285);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(213, 41);
            this.btnLanguage.TabIndex = 6;
            this.btnLanguage.Text = "LANGUAGE";
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewPassword2);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblConfirmNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdatePassword";
            this.Text = "UpdatePassword";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button btnLanguage;
    }
}