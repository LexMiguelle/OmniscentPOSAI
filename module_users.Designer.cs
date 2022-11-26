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
            this.tp_changePassword = new System.Windows.Forms.TabPage();
            this.tp_accountStatus = new System.Windows.Forms.TabPage();
            this.tp_deleteAccount = new System.Windows.Forms.TabPage();
            this.tp_activityLog = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.tp_createAccount.Location = new System.Drawing.Point(4, 22);
            this.tp_createAccount.Name = "tp_createAccount";
            this.tp_createAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tp_createAccount.Size = new System.Drawing.Size(1056, 560);
            this.tp_createAccount.TabIndex = 0;
            this.tp_createAccount.Text = "Create Account";
            this.tp_createAccount.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_createAccount;
        private System.Windows.Forms.TabPage tp_changePassword;
        private System.Windows.Forms.TabPage tp_accountStatus;
        private System.Windows.Forms.TabPage tp_deleteAccount;
        private System.Windows.Forms.TabPage tp_activityLog;
    }
}