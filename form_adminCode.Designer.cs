namespace OmniscentPOSAI
{
    partial class form_adminCode
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
            this.panel_adminCodeHead = new System.Windows.Forms.Panel();
            this.btn_closeAdminCode = new System.Windows.Forms.Button();
            this.lbl_adminCode = new System.Windows.Forms.Label();
            this.panel_adminCode = new System.Windows.Forms.Panel();
            this.tb_searchBox = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tb_adminCode = new System.Windows.Forms.TextBox();
            this.panel_adminCodeHead.SuspendLayout();
            this.panel_adminCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_adminCodeHead
            // 
            this.panel_adminCodeHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_adminCodeHead.Controls.Add(this.btn_closeAdminCode);
            this.panel_adminCodeHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_adminCodeHead.Location = new System.Drawing.Point(0, 0);
            this.panel_adminCodeHead.Name = "panel_adminCodeHead";
            this.panel_adminCodeHead.Size = new System.Drawing.Size(394, 30);
            this.panel_adminCodeHead.TabIndex = 4;
            // 
            // btn_closeAdminCode
            // 
            this.btn_closeAdminCode.BackColor = System.Drawing.Color.Red;
            this.btn_closeAdminCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeAdminCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeAdminCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeAdminCode.ForeColor = System.Drawing.Color.White;
            this.btn_closeAdminCode.Location = new System.Drawing.Point(364, 0);
            this.btn_closeAdminCode.Name = "btn_closeAdminCode";
            this.btn_closeAdminCode.Size = new System.Drawing.Size(28, 28);
            this.btn_closeAdminCode.TabIndex = 5;
            this.btn_closeAdminCode.Text = "X";
            this.btn_closeAdminCode.UseVisualStyleBackColor = false;
            this.btn_closeAdminCode.Click += new System.EventHandler(this.btn_closeAdminCode_Click);
            // 
            // lbl_adminCode
            // 
            this.lbl_adminCode.AutoSize = true;
            this.lbl_adminCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminCode.ForeColor = System.Drawing.Color.White;
            this.lbl_adminCode.Location = new System.Drawing.Point(22, 20);
            this.lbl_adminCode.Name = "lbl_adminCode";
            this.lbl_adminCode.Size = new System.Drawing.Size(172, 31);
            this.lbl_adminCode.TabIndex = 4;
            this.lbl_adminCode.Text = "Admin Code";
            // 
            // panel_adminCode
            // 
            this.panel_adminCode.Controls.Add(this.tb_searchBox);
            this.panel_adminCode.Controls.Add(this.lbl_adminCode);
            this.panel_adminCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_adminCode.Location = new System.Drawing.Point(0, 30);
            this.panel_adminCode.Name = "panel_adminCode";
            this.panel_adminCode.Size = new System.Drawing.Size(394, 75);
            this.panel_adminCode.TabIndex = 11;
            // 
            // tb_searchBox
            // 
            this.tb_searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchBox.Location = new System.Drawing.Point(628, 20);
            this.tb_searchBox.Name = "tb_searchBox";
            this.tb_searchBox.Size = new System.Drawing.Size(0, 29);
            this.tb_searchBox.TabIndex = 5;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OK.ForeColor = System.Drawing.Color.Black;
            this.btn_OK.Location = new System.Drawing.Point(259, 128);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 30);
            this.btn_OK.TabIndex = 13;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tb_adminCode
            // 
            this.tb_adminCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_adminCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_adminCode.Location = new System.Drawing.Point(33, 128);
            this.tb_adminCode.Name = "tb_adminCode";
            this.tb_adminCode.Size = new System.Drawing.Size(200, 38);
            this.tb_adminCode.TabIndex = 12;
            // 
            // form_adminCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(394, 194);
            this.ControlBox = false;
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tb_adminCode);
            this.Controls.Add(this.panel_adminCode);
            this.Controls.Add(this.panel_adminCodeHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_adminCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel_adminCodeHead.ResumeLayout(false);
            this.panel_adminCode.ResumeLayout(false);
            this.panel_adminCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_adminCodeHead;
        private System.Windows.Forms.Button btn_closeAdminCode;
        private System.Windows.Forms.Label lbl_adminCode;
        private System.Windows.Forms.Panel panel_adminCode;
        private System.Windows.Forms.TextBox tb_searchBox;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox tb_adminCode;
    }
}