namespace HotelManagementSystem
{
    partial class LogIn
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbNotView = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbViewPassword = new System.Windows.Forms.PictureBox();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbNotView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(70, 103);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(70, 141);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(146, 101);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(192, 20);
            this.txtUsername.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtUsername, "Enter your username");
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(146, 141);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(131, 20);
            this.txtPassword.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtPassword, "Enter your password");
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(130, 245);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 54);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.toolTip1.SetToolTip(this.btnLogin, "Click to Login");
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbNotView
            // 
            this.pbNotView.Image = global::HotelManagementSystem.Properties.Resources.OIP;
            this.pbNotView.Location = new System.Drawing.Point(280, 136);
            this.pbNotView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbNotView.Name = "pbNotView";
            this.pbNotView.Size = new System.Drawing.Size(34, 38);
            this.pbNotView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotView.TabIndex = 8;
            this.pbNotView.TabStop = false;
            this.pbNotView.Click += new System.EventHandler(this.pbNotView_Click);
            // 
            // pbExit
            // 
            this.pbExit.Location = new System.Drawing.Point(308, 17);
            this.pbExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(50, 37);
            this.pbExit.TabIndex = 7;
            this.pbExit.TabStop = false;
            // 
            // pbViewPassword
            // 
            this.pbViewPassword.Image = global::HotelManagementSystem.Properties.Resources.preview_show_interface_icon_free_vector;
            this.pbViewPassword.Location = new System.Drawing.Point(280, 136);
            this.pbViewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbViewPassword.Name = "pbViewPassword";
            this.pbViewPassword.Size = new System.Drawing.Size(34, 39);
            this.pbViewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbViewPassword.TabIndex = 6;
            this.pbViewPassword.TabStop = false;
            this.toolTip1.SetToolTip(this.pbViewPassword, "Click to see or hide Password");
            this.pbViewPassword.Click += new System.EventHandler(this.pbViewPassword_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.Location = new System.Drawing.Point(130, 305);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(147, 35);
            this.btnLanguage.TabIndex = 9;
            this.btnLanguage.Text = "AFRIKAANS";
            this.toolTip1.SetToolTip(this.btnLanguage, "Click to change languages");
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click_1);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 366);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pbViewPassword);
            this.Controls.Add(this.pbNotView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogIn";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pbNotView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbViewPassword;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbNotView;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}