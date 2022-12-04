namespace OmniscentPOSAI
{
    partial class form_voidCode
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.tb_voidCode = new System.Windows.Forms.TextBox();
            this.panel_voidCodeHead = new System.Windows.Forms.Panel();
            this.btn_closeManagerCode = new System.Windows.Forms.Button();
            this.panel_voidCode = new System.Windows.Forms.Panel();
            this.tb_searchBox = new System.Windows.Forms.TextBox();
            this.lbl_voidCode = new System.Windows.Forms.Label();
            this.lbl_voidBy = new System.Windows.Forms.Label();
            this.tb_voidBy = new System.Windows.Forms.TextBox();
            this.panel_voidCodeHead.SuspendLayout();
            this.panel_voidCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OK.ForeColor = System.Drawing.Color.Black;
            this.btn_OK.Location = new System.Drawing.Point(266, 209);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 30);
            this.btn_OK.TabIndex = 17;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tb_voidCode
            // 
            this.tb_voidCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_voidCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_voidCode.Location = new System.Drawing.Point(60, 123);
            this.tb_voidCode.MaxLength = 4;
            this.tb_voidCode.Name = "tb_voidCode";
            this.tb_voidCode.PasswordChar = '•';
            this.tb_voidCode.Size = new System.Drawing.Size(272, 38);
            this.tb_voidCode.TabIndex = 1;
            this.tb_voidCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_voidCode.UseSystemPasswordChar = true;
            this.tb_voidCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_voidCode_KeyPress);
            // 
            // panel_voidCodeHead
            // 
            this.panel_voidCodeHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_voidCodeHead.Controls.Add(this.btn_closeManagerCode);
            this.panel_voidCodeHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_voidCodeHead.Location = new System.Drawing.Point(0, 0);
            this.panel_voidCodeHead.Name = "panel_voidCodeHead";
            this.panel_voidCodeHead.Size = new System.Drawing.Size(394, 30);
            this.panel_voidCodeHead.TabIndex = 18;
            // 
            // btn_closeManagerCode
            // 
            this.btn_closeManagerCode.BackColor = System.Drawing.Color.Red;
            this.btn_closeManagerCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeManagerCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeManagerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeManagerCode.ForeColor = System.Drawing.Color.White;
            this.btn_closeManagerCode.Location = new System.Drawing.Point(364, 0);
            this.btn_closeManagerCode.Name = "btn_closeManagerCode";
            this.btn_closeManagerCode.Size = new System.Drawing.Size(28, 28);
            this.btn_closeManagerCode.TabIndex = 5;
            this.btn_closeManagerCode.Text = "X";
            this.btn_closeManagerCode.UseVisualStyleBackColor = false;
            this.btn_closeManagerCode.Click += new System.EventHandler(this.btn_voidCodeClose_Click);
            // 
            // panel_voidCode
            // 
            this.panel_voidCode.Controls.Add(this.tb_searchBox);
            this.panel_voidCode.Controls.Add(this.lbl_voidCode);
            this.panel_voidCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_voidCode.Location = new System.Drawing.Point(0, 30);
            this.panel_voidCode.Name = "panel_voidCode";
            this.panel_voidCode.Size = new System.Drawing.Size(394, 75);
            this.panel_voidCode.TabIndex = 19;
            // 
            // tb_searchBox
            // 
            this.tb_searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchBox.Location = new System.Drawing.Point(628, 20);
            this.tb_searchBox.Name = "tb_searchBox";
            this.tb_searchBox.Size = new System.Drawing.Size(0, 29);
            this.tb_searchBox.TabIndex = 5;
            // 
            // lbl_voidCode
            // 
            this.lbl_voidCode.AutoSize = true;
            this.lbl_voidCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_voidCode.ForeColor = System.Drawing.Color.White;
            this.lbl_voidCode.Location = new System.Drawing.Point(22, 20);
            this.lbl_voidCode.Name = "lbl_voidCode";
            this.lbl_voidCode.Size = new System.Drawing.Size(149, 31);
            this.lbl_voidCode.TabIndex = 4;
            this.lbl_voidCode.Text = "Void Code";
            // 
            // lbl_voidBy
            // 
            this.lbl_voidBy.AutoSize = true;
            this.lbl_voidBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_voidBy.ForeColor = System.Drawing.Color.White;
            this.lbl_voidBy.Location = new System.Drawing.Point(22, 191);
            this.lbl_voidBy.Name = "lbl_voidBy";
            this.lbl_voidBy.Size = new System.Drawing.Size(147, 16);
            this.lbl_voidBy.TabIndex = 4;
            this.lbl_voidBy.Text = "Void By (username):";
            // 
            // tb_voidBy
            // 
            this.tb_voidBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_voidBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_voidBy.Location = new System.Drawing.Point(28, 210);
            this.tb_voidBy.Name = "tb_voidBy";
            this.tb_voidBy.Size = new System.Drawing.Size(195, 29);
            this.tb_voidBy.TabIndex = 16;
            this.tb_voidBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_voidBy_KeyPress);
            // 
            // form_voidCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(394, 254);
            this.ControlBox = false;
            this.Controls.Add(this.panel_voidCode);
            this.Controls.Add(this.lbl_voidBy);
            this.Controls.Add(this.panel_voidCodeHead);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tb_voidBy);
            this.Controls.Add(this.tb_voidCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_voidCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel_voidCodeHead.ResumeLayout(false);
            this.panel_voidCode.ResumeLayout(false);
            this.panel_voidCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox tb_voidCode;
        private System.Windows.Forms.Panel panel_voidCodeHead;
        private System.Windows.Forms.Button btn_closeManagerCode;
        private System.Windows.Forms.Panel panel_voidCode;
        private System.Windows.Forms.TextBox tb_searchBox;
        private System.Windows.Forms.Label lbl_voidCode;
        private System.Windows.Forms.Label lbl_voidBy;
        private System.Windows.Forms.TextBox tb_voidBy;
    }
}