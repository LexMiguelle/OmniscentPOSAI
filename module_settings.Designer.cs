namespace OmniscentPOSAI
{
    partial class module_settings
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
            this.lbl_stocks = new System.Windows.Forms.Label();
            this.panel_stocksHead = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_closeSettings = new System.Windows.Forms.Button();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_OldPassword = new System.Windows.Forms.Label();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_cashierLogout = new System.Windows.Forms.Button();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.lbl_confirmPassword = new System.Windows.Forms.Label();
            this.tb_oldPasswod = new System.Windows.Forms.TextBox();
            this.tb_newPassword = new System.Windows.Forms.TextBox();
            this.tb_confirmPassword = new System.Windows.Forms.TextBox();
            this.btn_updatePassword = new System.Windows.Forms.Button();
            this.panel_stocksHead.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_stocks
            // 
            this.lbl_stocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_stocks.AutoSize = true;
            this.lbl_stocks.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stocks.ForeColor = System.Drawing.Color.White;
            this.lbl_stocks.Location = new System.Drawing.Point(24, 20);
            this.lbl_stocks.Name = "lbl_stocks";
            this.lbl_stocks.Size = new System.Drawing.Size(121, 31);
            this.lbl_stocks.TabIndex = 0;
            this.lbl_stocks.Text = "Settings";
            // 
            // panel_stocksHead
            // 
            this.panel_stocksHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_stocksHead.Controls.Add(this.btn_closeSettings);
            this.panel_stocksHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_stocksHead.ForeColor = System.Drawing.Color.White;
            this.panel_stocksHead.Location = new System.Drawing.Point(0, 0);
            this.panel_stocksHead.Name = "panel_stocksHead";
            this.panel_stocksHead.Size = new System.Drawing.Size(500, 30);
            this.panel_stocksHead.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_stocks);
            this.panel1.Controls.Add(this.btn_cashierLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 75);
            this.panel1.TabIndex = 4;
            // 
            // btn_closeSettings
            // 
            this.btn_closeSettings.BackColor = System.Drawing.Color.Red;
            this.btn_closeSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeSettings.ForeColor = System.Drawing.Color.White;
            this.btn_closeSettings.Location = new System.Drawing.Point(468, 0);
            this.btn_closeSettings.Name = "btn_closeSettings";
            this.btn_closeSettings.Size = new System.Drawing.Size(30, 28);
            this.btn_closeSettings.TabIndex = 1;
            this.btn_closeSettings.Text = "X";
            this.btn_closeSettings.UseVisualStyleBackColor = false;
            this.btn_closeSettings.Click += new System.EventHandler(this.btn_closeSettings_Click);
            // 
            // lbl_userName
            // 
            this.lbl_userName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.ForeColor = System.Drawing.Color.White;
            this.lbl_userName.Location = new System.Drawing.Point(111, 162);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(116, 25);
            this.lbl_userName.TabIndex = 0;
            this.lbl_userName.Text = "Username:";
            // 
            // lbl_OldPassword
            // 
            this.lbl_OldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_OldPassword.AutoSize = true;
            this.lbl_OldPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OldPassword.ForeColor = System.Drawing.Color.White;
            this.lbl_OldPassword.Location = new System.Drawing.Point(76, 213);
            this.lbl_OldPassword.Name = "lbl_OldPassword";
            this.lbl_OldPassword.Size = new System.Drawing.Size(151, 25);
            this.lbl_OldPassword.TabIndex = 0;
            this.lbl_OldPassword.Text = "Old Password:";
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewPassword.ForeColor = System.Drawing.Color.White;
            this.lbl_NewPassword.Location = new System.Drawing.Point(67, 263);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(160, 25);
            this.lbl_NewPassword.TabIndex = 0;
            this.lbl_NewPassword.Text = "New Password:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 458);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 30);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_cashierLogout
            // 
            this.btn_cashierLogout.BackColor = System.Drawing.Color.Red;
            this.btn_cashierLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cashierLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cashierLogout.ForeColor = System.Drawing.Color.White;
            this.btn_cashierLogout.Location = new System.Drawing.Point(288, 19);
            this.btn_cashierLogout.Name = "btn_cashierLogout";
            this.btn_cashierLogout.Size = new System.Drawing.Size(200, 40);
            this.btn_cashierLogout.TabIndex = 6;
            this.btn_cashierLogout.Text = "Logout";
            this.btn_cashierLogout.UseVisualStyleBackColor = false;
            // 
            // tb_userName
            // 
            this.tb_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userName.Location = new System.Drawing.Point(233, 158);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(200, 29);
            this.tb_userName.TabIndex = 7;
            // 
            // lbl_confirmPassword
            // 
            this.lbl_confirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_confirmPassword.AutoSize = true;
            this.lbl_confirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmPassword.ForeColor = System.Drawing.Color.White;
            this.lbl_confirmPassword.Location = new System.Drawing.Point(35, 313);
            this.lbl_confirmPassword.Name = "lbl_confirmPassword";
            this.lbl_confirmPassword.Size = new System.Drawing.Size(192, 25);
            this.lbl_confirmPassword.TabIndex = 0;
            this.lbl_confirmPassword.Text = "Confirm Password:";
            // 
            // tb_oldPasswod
            // 
            this.tb_oldPasswod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_oldPasswod.Location = new System.Drawing.Point(233, 209);
            this.tb_oldPasswod.Name = "tb_oldPasswod";
            this.tb_oldPasswod.Size = new System.Drawing.Size(200, 29);
            this.tb_oldPasswod.TabIndex = 7;
            // 
            // tb_newPassword
            // 
            this.tb_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_newPassword.Location = new System.Drawing.Point(233, 259);
            this.tb_newPassword.Name = "tb_newPassword";
            this.tb_newPassword.Size = new System.Drawing.Size(200, 29);
            this.tb_newPassword.TabIndex = 7;
            // 
            // tb_confirmPassword
            // 
            this.tb_confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirmPassword.Location = new System.Drawing.Point(233, 309);
            this.tb_confirmPassword.Name = "tb_confirmPassword";
            this.tb_confirmPassword.Size = new System.Drawing.Size(200, 29);
            this.tb_confirmPassword.TabIndex = 7;
            // 
            // btn_updatePassword
            // 
            this.btn_updatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_updatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_updatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePassword.Location = new System.Drawing.Point(233, 365);
            this.btn_updatePassword.Name = "btn_updatePassword";
            this.btn_updatePassword.Size = new System.Drawing.Size(200, 40);
            this.btn_updatePassword.TabIndex = 6;
            this.btn_updatePassword.Text = "Update";
            this.btn_updatePassword.UseVisualStyleBackColor = false;
            this.btn_updatePassword.Click += new System.EventHandler(this.btn_updatePassword_Click);
            // 
            // module_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.ControlBox = false;
            this.Controls.Add(this.tb_confirmPassword);
            this.Controls.Add(this.tb_newPassword);
            this.Controls.Add(this.tb_oldPasswod);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.btn_updatePassword);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_confirmPassword);
            this.Controls.Add(this.lbl_NewPassword);
            this.Controls.Add(this.lbl_OldPassword);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_stocksHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "module_settings";
            this.panel_stocksHead.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stocks;
        private System.Windows.Forms.Panel panel_stocksHead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_closeSettings;
        private System.Windows.Forms.Button btn_cashierLogout;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_OldPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label lbl_confirmPassword;
        private System.Windows.Forms.TextBox tb_oldPasswod;
        private System.Windows.Forms.TextBox tb_newPassword;
        private System.Windows.Forms.TextBox tb_confirmPassword;
        private System.Windows.Forms.Button btn_updatePassword;
    }
}