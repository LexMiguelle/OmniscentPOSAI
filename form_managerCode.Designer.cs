namespace OmniscentPOSAI
{
    partial class form_managerCode
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
            this.tb_managerCode = new System.Windows.Forms.TextBox();
            this.panel_managerCodeHead = new System.Windows.Forms.Panel();
            this.btn_closeManagerCode = new System.Windows.Forms.Button();
            this.panel_managerCode = new System.Windows.Forms.Panel();
            this.tb_searchBox = new System.Windows.Forms.TextBox();
            this.lbl_managerCode = new System.Windows.Forms.Label();
            this.panel_managerCodeHead.SuspendLayout();
            this.panel_managerCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OK.ForeColor = System.Drawing.Color.Black;
            this.btn_OK.Location = new System.Drawing.Point(254, 128);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 30);
            this.btn_OK.TabIndex = 17;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tb_managerCode
            // 
            this.tb_managerCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_managerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_managerCode.Location = new System.Drawing.Point(28, 128);
            this.tb_managerCode.Name = "tb_managerCode";
            this.tb_managerCode.Size = new System.Drawing.Size(200, 38);
            this.tb_managerCode.TabIndex = 16;
            // 
            // panel_managerCodeHead
            // 
            this.panel_managerCodeHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_managerCodeHead.Controls.Add(this.btn_closeManagerCode);
            this.panel_managerCodeHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_managerCodeHead.Location = new System.Drawing.Point(0, 0);
            this.panel_managerCodeHead.Name = "panel_managerCodeHead";
            this.panel_managerCodeHead.Size = new System.Drawing.Size(394, 30);
            this.panel_managerCodeHead.TabIndex = 18;
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
            this.btn_closeManagerCode.Click += new System.EventHandler(this.btn_closeManagerCode_Click);
            // 
            // panel_managerCode
            // 
            this.panel_managerCode.Controls.Add(this.tb_searchBox);
            this.panel_managerCode.Controls.Add(this.lbl_managerCode);
            this.panel_managerCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_managerCode.Location = new System.Drawing.Point(0, 30);
            this.panel_managerCode.Name = "panel_managerCode";
            this.panel_managerCode.Size = new System.Drawing.Size(394, 75);
            this.panel_managerCode.TabIndex = 19;
            // 
            // tb_searchBox
            // 
            this.tb_searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchBox.Location = new System.Drawing.Point(628, 20);
            this.tb_searchBox.Name = "tb_searchBox";
            this.tb_searchBox.Size = new System.Drawing.Size(0, 29);
            this.tb_searchBox.TabIndex = 5;
            // 
            // lbl_managerCode
            // 
            this.lbl_managerCode.AutoSize = true;
            this.lbl_managerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_managerCode.ForeColor = System.Drawing.Color.White;
            this.lbl_managerCode.Location = new System.Drawing.Point(22, 20);
            this.lbl_managerCode.Name = "lbl_managerCode";
            this.lbl_managerCode.Size = new System.Drawing.Size(204, 31);
            this.lbl_managerCode.TabIndex = 4;
            this.lbl_managerCode.Text = "Manager Code";
            // 
            // form_managerCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(394, 194);
            this.ControlBox = false;
            this.Controls.Add(this.panel_managerCode);
            this.Controls.Add(this.panel_managerCodeHead);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tb_managerCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_managerCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel_managerCodeHead.ResumeLayout(false);
            this.panel_managerCode.ResumeLayout(false);
            this.panel_managerCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox tb_managerCode;
        private System.Windows.Forms.Panel panel_managerCodeHead;
        private System.Windows.Forms.Button btn_closeManagerCode;
        private System.Windows.Forms.Panel panel_managerCode;
        private System.Windows.Forms.TextBox tb_searchBox;
        private System.Windows.Forms.Label lbl_managerCode;
    }
}