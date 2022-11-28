namespace OmniscentPOSAI
{
    partial class module_users
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_createAccount = new System.Windows.Forms.TabPage();
            this.btn_cancelCA = new System.Windows.Forms.Button();
            this.btn_createCA = new System.Windows.Forms.Button();
            this.panel_createAccountHead = new System.Windows.Forms.Panel();
            this.lbl_createAccount = new System.Windows.Forms.Label();
            this.cb_roleCA = new System.Windows.Forms.ComboBox();
            this.lbl_roleCA = new System.Windows.Forms.Label();
            this.tb_retypePasswordCA = new System.Windows.Forms.TextBox();
            this.lbl_retypePasswordCA = new System.Windows.Forms.Label();
            this.tb_passwordCA = new System.Windows.Forms.TextBox();
            this.lbl_passwordCA = new System.Windows.Forms.Label();
            this.tb_firstNameCA = new System.Windows.Forms.TextBox();
            this.lbl_firstNameCA = new System.Windows.Forms.Label();
            this.tb_lastNameCA = new System.Windows.Forms.TextBox();
            this.lbl_lastNameCA = new System.Windows.Forms.Label();
            this.tb_userNameCA = new System.Windows.Forms.TextBox();
            this.lbl_userNameCA = new System.Windows.Forms.Label();
            this.tp_changePassword = new System.Windows.Forms.TabPage();
            this.tp_accountStatus = new System.Windows.Forms.TabPage();
            this.tp_deleteAccount = new System.Windows.Forms.TabPage();
            this.tp_activityLog = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_createAccount.SuspendLayout();
            this.panel_createAccountHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 75);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(779, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Management";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_createAccount);
            this.tabControl1.Controls.Add(this.tp_changePassword);
            this.tabControl1.Controls.Add(this.tp_accountStatus);
            this.tabControl1.Controls.Add(this.tp_deleteAccount);
            this.tabControl1.Controls.Add(this.tp_activityLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 586);
            this.tabControl1.TabIndex = 2;
            // 
            // tp_createAccount
            // 
            this.tp_createAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tp_createAccount.Controls.Add(this.btn_cancelCA);
            this.tp_createAccount.Controls.Add(this.btn_createCA);
            this.tp_createAccount.Controls.Add(this.panel_createAccountHead);
            this.tp_createAccount.Controls.Add(this.cb_roleCA);
            this.tp_createAccount.Controls.Add(this.lbl_roleCA);
            this.tp_createAccount.Controls.Add(this.tb_retypePasswordCA);
            this.tp_createAccount.Controls.Add(this.lbl_retypePasswordCA);
            this.tp_createAccount.Controls.Add(this.tb_passwordCA);
            this.tp_createAccount.Controls.Add(this.lbl_passwordCA);
            this.tp_createAccount.Controls.Add(this.tb_firstNameCA);
            this.tp_createAccount.Controls.Add(this.lbl_firstNameCA);
            this.tp_createAccount.Controls.Add(this.tb_lastNameCA);
            this.tp_createAccount.Controls.Add(this.lbl_lastNameCA);
            this.tp_createAccount.Controls.Add(this.tb_userNameCA);
            this.tp_createAccount.Controls.Add(this.lbl_userNameCA);
            this.tp_createAccount.Location = new System.Drawing.Point(4, 22);
            this.tp_createAccount.Name = "tp_createAccount";
            this.tp_createAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tp_createAccount.Size = new System.Drawing.Size(1056, 560);
            this.tp_createAccount.TabIndex = 0;
            this.tp_createAccount.Text = "Create Account";
            // 
            // btn_cancelCA
            // 
            this.btn_cancelCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cancelCA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelCA.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelCA.Location = new System.Drawing.Point(405, 499);
            this.btn_cancelCA.Name = "btn_cancelCA";
            this.btn_cancelCA.Size = new System.Drawing.Size(303, 30);
            this.btn_cancelCA.TabIndex = 8;
            this.btn_cancelCA.Text = "CANCEL";
            this.btn_cancelCA.UseVisualStyleBackColor = false;
            this.btn_cancelCA.Click += new System.EventHandler(this.btn_cancelCA_Click);
            // 
            // btn_createCA
            // 
            this.btn_createCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_createCA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_createCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createCA.Location = new System.Drawing.Point(357, 433);
            this.btn_createCA.Name = "btn_createCA";
            this.btn_createCA.Size = new System.Drawing.Size(400, 48);
            this.btn_createCA.TabIndex = 8;
            this.btn_createCA.Text = "CREATE";
            this.btn_createCA.UseVisualStyleBackColor = false;
            this.btn_createCA.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // panel_createAccountHead
            // 
            this.panel_createAccountHead.BackColor = System.Drawing.Color.Black;
            this.panel_createAccountHead.Controls.Add(this.lbl_createAccount);
            this.panel_createAccountHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_createAccountHead.Location = new System.Drawing.Point(3, 3);
            this.panel_createAccountHead.Name = "panel_createAccountHead";
            this.panel_createAccountHead.Size = new System.Drawing.Size(1050, 75);
            this.panel_createAccountHead.TabIndex = 7;
            // 
            // lbl_createAccount
            // 
            this.lbl_createAccount.AutoSize = true;
            this.lbl_createAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_createAccount.ForeColor = System.Drawing.Color.White;
            this.lbl_createAccount.Location = new System.Drawing.Point(394, 17);
            this.lbl_createAccount.Name = "lbl_createAccount";
            this.lbl_createAccount.Size = new System.Drawing.Size(311, 46);
            this.lbl_createAccount.TabIndex = 3;
            this.lbl_createAccount.Text = "Create Account";
            // 
            // cb_roleCA
            // 
            this.cb_roleCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_roleCA.FormattingEnabled = true;
            this.cb_roleCA.Items.AddRange(new object[] {
            "administrator",
            "cashier"});
            this.cb_roleCA.Location = new System.Drawing.Point(357, 247);
            this.cb_roleCA.Name = "cb_roleCA";
            this.cb_roleCA.Size = new System.Drawing.Size(400, 39);
            this.cb_roleCA.TabIndex = 6;
            // 
            // lbl_roleCA
            // 
            this.lbl_roleCA.AutoSize = true;
            this.lbl_roleCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roleCA.ForeColor = System.Drawing.Color.White;
            this.lbl_roleCA.Location = new System.Drawing.Point(263, 255);
            this.lbl_roleCA.Name = "lbl_roleCA";
            this.lbl_roleCA.Size = new System.Drawing.Size(83, 31);
            this.lbl_roleCA.TabIndex = 3;
            this.lbl_roleCA.Text = "Role:";
            // 
            // tb_retypePasswordCA
            // 
            this.tb_retypePasswordCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_retypePasswordCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_retypePasswordCA.Location = new System.Drawing.Point(357, 204);
            this.tb_retypePasswordCA.Name = "tb_retypePasswordCA";
            this.tb_retypePasswordCA.PasswordChar = '*';
            this.tb_retypePasswordCA.Size = new System.Drawing.Size(400, 38);
            this.tb_retypePasswordCA.TabIndex = 5;
            // 
            // lbl_retypePasswordCA
            // 
            this.lbl_retypePasswordCA.AutoSize = true;
            this.lbl_retypePasswordCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_retypePasswordCA.ForeColor = System.Drawing.Color.White;
            this.lbl_retypePasswordCA.Location = new System.Drawing.Point(94, 211);
            this.lbl_retypePasswordCA.Name = "lbl_retypePasswordCA";
            this.lbl_retypePasswordCA.Size = new System.Drawing.Size(252, 31);
            this.lbl_retypePasswordCA.TabIndex = 3;
            this.lbl_retypePasswordCA.Text = "Retype Password:";
            // 
            // tb_passwordCA
            // 
            this.tb_passwordCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_passwordCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordCA.Location = new System.Drawing.Point(357, 160);
            this.tb_passwordCA.Name = "tb_passwordCA";
            this.tb_passwordCA.PasswordChar = '*';
            this.tb_passwordCA.Size = new System.Drawing.Size(400, 38);
            this.tb_passwordCA.TabIndex = 5;
            // 
            // lbl_passwordCA
            // 
            this.lbl_passwordCA.AutoSize = true;
            this.lbl_passwordCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordCA.ForeColor = System.Drawing.Color.White;
            this.lbl_passwordCA.Location = new System.Drawing.Point(195, 167);
            this.lbl_passwordCA.Name = "lbl_passwordCA";
            this.lbl_passwordCA.Size = new System.Drawing.Size(151, 31);
            this.lbl_passwordCA.TabIndex = 3;
            this.lbl_passwordCA.Text = "Password:";
            // 
            // tb_firstNameCA
            // 
            this.tb_firstNameCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_firstNameCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_firstNameCA.Location = new System.Drawing.Point(357, 367);
            this.tb_firstNameCA.Name = "tb_firstNameCA";
            this.tb_firstNameCA.Size = new System.Drawing.Size(400, 38);
            this.tb_firstNameCA.TabIndex = 5;
            // 
            // lbl_firstNameCA
            // 
            this.lbl_firstNameCA.AutoSize = true;
            this.lbl_firstNameCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstNameCA.ForeColor = System.Drawing.Color.White;
            this.lbl_firstNameCA.Location = new System.Drawing.Point(180, 374);
            this.lbl_firstNameCA.Name = "lbl_firstNameCA";
            this.lbl_firstNameCA.Size = new System.Drawing.Size(166, 31);
            this.lbl_firstNameCA.TabIndex = 3;
            this.lbl_firstNameCA.Text = "First Name:";
            // 
            // tb_lastNameCA
            // 
            this.tb_lastNameCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_lastNameCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lastNameCA.Location = new System.Drawing.Point(357, 323);
            this.tb_lastNameCA.Name = "tb_lastNameCA";
            this.tb_lastNameCA.Size = new System.Drawing.Size(400, 38);
            this.tb_lastNameCA.TabIndex = 5;
            // 
            // lbl_lastNameCA
            // 
            this.lbl_lastNameCA.AutoSize = true;
            this.lbl_lastNameCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastNameCA.ForeColor = System.Drawing.Color.White;
            this.lbl_lastNameCA.Location = new System.Drawing.Point(183, 330);
            this.lbl_lastNameCA.Name = "lbl_lastNameCA";
            this.lbl_lastNameCA.Size = new System.Drawing.Size(163, 31);
            this.lbl_lastNameCA.TabIndex = 3;
            this.lbl_lastNameCA.Text = "Last Name:";
            // 
            // tb_userNameCA
            // 
            this.tb_userNameCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_userNameCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userNameCA.Location = new System.Drawing.Point(357, 116);
            this.tb_userNameCA.Name = "tb_userNameCA";
            this.tb_userNameCA.Size = new System.Drawing.Size(400, 38);
            this.tb_userNameCA.TabIndex = 5;
            // 
            // lbl_userNameCA
            // 
            this.lbl_userNameCA.AutoSize = true;
            this.lbl_userNameCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userNameCA.ForeColor = System.Drawing.Color.White;
            this.lbl_userNameCA.Location = new System.Drawing.Point(195, 123);
            this.lbl_userNameCA.Name = "lbl_userNameCA";
            this.lbl_userNameCA.Size = new System.Drawing.Size(156, 31);
            this.lbl_userNameCA.TabIndex = 3;
            this.lbl_userNameCA.Text = "Username:";
            // 
            // tp_changePassword
            // 
            this.tp_changePassword.Location = new System.Drawing.Point(4, 22);
            this.tp_changePassword.Name = "tp_changePassword";
            this.tp_changePassword.Padding = new System.Windows.Forms.Padding(3);
            this.tp_changePassword.Size = new System.Drawing.Size(1056, 560);
            this.tp_changePassword.TabIndex = 1;
            this.tp_changePassword.Text = "Change Password";
            this.tp_changePassword.UseVisualStyleBackColor = true;
            // 
            // tp_accountStatus
            // 
            this.tp_accountStatus.Location = new System.Drawing.Point(4, 22);
            this.tp_accountStatus.Name = "tp_accountStatus";
            this.tp_accountStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tp_accountStatus.Size = new System.Drawing.Size(1056, 560);
            this.tp_accountStatus.TabIndex = 2;
            this.tp_accountStatus.Text = "Account Status";
            this.tp_accountStatus.UseVisualStyleBackColor = true;
            // 
            // tp_deleteAccount
            // 
            this.tp_deleteAccount.Location = new System.Drawing.Point(4, 22);
            this.tp_deleteAccount.Name = "tp_deleteAccount";
            this.tp_deleteAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tp_deleteAccount.Size = new System.Drawing.Size(1056, 560);
            this.tp_deleteAccount.TabIndex = 3;
            this.tp_deleteAccount.Text = "Delete Account";
            this.tp_deleteAccount.UseVisualStyleBackColor = true;
            // 
            // tp_activityLog
            // 
            this.tp_activityLog.Location = new System.Drawing.Point(4, 22);
            this.tp_activityLog.Name = "tp_activityLog";
            this.tp_activityLog.Padding = new System.Windows.Forms.Padding(3);
            this.tp_activityLog.Size = new System.Drawing.Size(1056, 560);
            this.tp_activityLog.TabIndex = 4;
            this.tp_activityLog.Text = "Activity Log";
            this.tp_activityLog.UseVisualStyleBackColor = true;
            // 
            // module_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "module_users";
            this.Text = "module_users";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tp_createAccount.ResumeLayout(false);
            this.tp_createAccount.PerformLayout();
            this.panel_createAccountHead.ResumeLayout(false);
            this.panel_createAccountHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_createAccount;
        private System.Windows.Forms.TabPage tp_changePassword;
        private System.Windows.Forms.TabPage tp_accountStatus;
        private System.Windows.Forms.TabPage tp_deleteAccount;
        private System.Windows.Forms.TabPage tp_activityLog;
        private System.Windows.Forms.Button btn_createCA;
        private System.Windows.Forms.Panel panel_createAccountHead;
        private System.Windows.Forms.Label lbl_createAccount;
        private System.Windows.Forms.ComboBox cb_roleCA;
        private System.Windows.Forms.Label lbl_roleCA;
        private System.Windows.Forms.TextBox tb_retypePasswordCA;
        private System.Windows.Forms.Label lbl_retypePasswordCA;
        private System.Windows.Forms.TextBox tb_passwordCA;
        private System.Windows.Forms.Label lbl_passwordCA;
        private System.Windows.Forms.TextBox tb_firstNameCA;
        private System.Windows.Forms.Label lbl_firstNameCA;
        private System.Windows.Forms.TextBox tb_lastNameCA;
        private System.Windows.Forms.Label lbl_lastNameCA;
        private System.Windows.Forms.TextBox tb_userNameCA;
        private System.Windows.Forms.Label lbl_userNameCA;
        private System.Windows.Forms.Button btn_cancelCA;
        private System.Windows.Forms.TextBox textBox1;
    }
}