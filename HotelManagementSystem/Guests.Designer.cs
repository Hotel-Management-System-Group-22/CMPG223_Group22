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
            this.grpBoxMenu = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPgAddGuest = new System.Windows.Forms.TabPage();
            this.tbPageSearchGuest = new System.Windows.Forms.TabPage();
            this.tbPgUpdateGuest = new System.Windows.Forms.TabPage();
            this.tbPageDeleteGuest = new System.Windows.Forms.TabPage();
            this.DgvGuests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBoxMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPgAddGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxMenu
            // 
            this.grpBoxMenu.Controls.Add(this.button4);
            this.grpBoxMenu.Controls.Add(this.button3);
            this.grpBoxMenu.Controls.Add(this.button2);
            this.grpBoxMenu.Controls.Add(this.button1);
            this.grpBoxMenu.Location = new System.Drawing.Point(937, 12);
            this.grpBoxMenu.Name = "grpBoxMenu";
            this.grpBoxMenu.Size = new System.Drawing.Size(268, 297);
            this.grpBoxMenu.TabIndex = 0;
            this.grpBoxMenu.TabStop = false;
            this.grpBoxMenu.Text = "Menu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD GUEST";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "SEARCH GUEST ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(243, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "UPDATE GUEST";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "DELETE GUEST";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPgAddGuest);
            this.tabControl1.Controls.Add(this.tbPageSearchGuest);
            this.tabControl1.Controls.Add(this.tbPgUpdateGuest);
            this.tabControl1.Controls.Add(this.tbPageDeleteGuest);
            this.tabControl1.Location = new System.Drawing.Point(38, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 279);
            this.tabControl1.TabIndex = 1;
            // 
            // tbPgAddGuest
            // 
            this.tbPgAddGuest.Controls.Add(this.label1);
            this.tbPgAddGuest.Controls.Add(this.label2);
            this.tbPgAddGuest.Controls.Add(this.label3);
            this.tbPgAddGuest.Controls.Add(this.label4);
            this.tbPgAddGuest.Location = new System.Drawing.Point(4, 25);
            this.tbPgAddGuest.Name = "tbPgAddGuest";
            this.tbPgAddGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgAddGuest.Size = new System.Drawing.Size(754, 250);
            this.tbPgAddGuest.TabIndex = 0;
            this.tbPgAddGuest.Text = "ADD GUEST";
            this.tbPgAddGuest.UseVisualStyleBackColor = true;
            // 
            // tbPageSearchGuest
            // 
            this.tbPageSearchGuest.Location = new System.Drawing.Point(4, 25);
            this.tbPageSearchGuest.Name = "tbPageSearchGuest";
            this.tbPageSearchGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageSearchGuest.Size = new System.Drawing.Size(754, 219);
            this.tbPageSearchGuest.TabIndex = 1;
            this.tbPageSearchGuest.Text = "SEARCH GUEST";
            this.tbPageSearchGuest.UseVisualStyleBackColor = true;
            // 
            // tbPgUpdateGuest
            // 
            this.tbPgUpdateGuest.Location = new System.Drawing.Point(4, 25);
            this.tbPgUpdateGuest.Name = "tbPgUpdateGuest";
            this.tbPgUpdateGuest.Size = new System.Drawing.Size(754, 219);
            this.tbPgUpdateGuest.TabIndex = 2;
            this.tbPgUpdateGuest.Text = "UPDATE GUEST";
            this.tbPgUpdateGuest.UseVisualStyleBackColor = true;
            // 
            // tbPageDeleteGuest
            // 
            this.tbPageDeleteGuest.Location = new System.Drawing.Point(4, 25);
            this.tbPageDeleteGuest.Name = "tbPageDeleteGuest";
            this.tbPageDeleteGuest.Size = new System.Drawing.Size(754, 219);
            this.tbPageDeleteGuest.TabIndex = 3;
            this.tbPageDeleteGuest.Text = "DELETE GUEST";
            this.tbPageDeleteGuest.UseVisualStyleBackColor = true;
            // 
            // DgvGuests
            // 
            this.DgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGuests.Location = new System.Drawing.Point(38, 343);
            this.DgvGuests.Name = "DgvGuests";
            this.DgvGuests.RowHeadersWidth = 51;
            this.DgvGuests.RowTemplate.Height = 24;
            this.DgvGuests.Size = new System.Drawing.Size(1167, 215);
            this.DgvGuests.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // Guests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 592);
            this.Controls.Add(this.DgvGuests);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpBoxMenu);
            this.Name = "Guests";
            this.Text = "Guests";
            this.grpBoxMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbPgAddGuest.ResumeLayout(false);
            this.tbPgAddGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPgAddGuest;
        private System.Windows.Forms.TabPage tbPageSearchGuest;
        private System.Windows.Forms.TabPage tbPgUpdateGuest;
        private System.Windows.Forms.TabPage tbPageDeleteGuest;
        private System.Windows.Forms.DataGridView DgvGuests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

