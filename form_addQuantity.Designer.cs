namespace OmniscentPOSAI
{
    partial class form_addQuantity
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
            this.btn_closeAddQuantity = new System.Windows.Forms.Button();
            this.panel_addQuantityHead = new System.Windows.Forms.Panel();
            this.panel_addToCart = new System.Windows.Forms.Panel();
            this.tb_searchBox = new System.Windows.Forms.TextBox();
            this.lbl_addQuantity = new System.Windows.Forms.Label();
            this.tb_addQuantity = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.panel_addQuantityHead.SuspendLayout();
            this.panel_addToCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_closeAddQuantity
            // 
            this.btn_closeAddQuantity.BackColor = System.Drawing.Color.Red;
            this.btn_closeAddQuantity.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeAddQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeAddQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeAddQuantity.ForeColor = System.Drawing.Color.White;
            this.btn_closeAddQuantity.Location = new System.Drawing.Point(364, 0);
            this.btn_closeAddQuantity.Name = "btn_closeAddQuantity";
            this.btn_closeAddQuantity.Size = new System.Drawing.Size(28, 28);
            this.btn_closeAddQuantity.TabIndex = 5;
            this.btn_closeAddQuantity.Text = "X";
            this.btn_closeAddQuantity.UseVisualStyleBackColor = false;
            this.btn_closeAddQuantity.Click += new System.EventHandler(this.btn_closeAddQuantity_Click);
            // 
            // panel_addQuantityHead
            // 
            this.panel_addQuantityHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_addQuantityHead.Controls.Add(this.btn_closeAddQuantity);
            this.panel_addQuantityHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_addQuantityHead.Location = new System.Drawing.Point(0, 0);
            this.panel_addQuantityHead.Name = "panel_addQuantityHead";
            this.panel_addQuantityHead.Size = new System.Drawing.Size(394, 30);
            this.panel_addQuantityHead.TabIndex = 3;
            // 
            // panel_addToCart
            // 
            this.panel_addToCart.Controls.Add(this.tb_searchBox);
            this.panel_addToCart.Controls.Add(this.lbl_addQuantity);
            this.panel_addToCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_addToCart.Location = new System.Drawing.Point(0, 30);
            this.panel_addToCart.Name = "panel_addToCart";
            this.panel_addToCart.Size = new System.Drawing.Size(394, 75);
            this.panel_addToCart.TabIndex = 10;
            // 
            // tb_searchBox
            // 
            this.tb_searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchBox.Location = new System.Drawing.Point(628, 20);
            this.tb_searchBox.Name = "tb_searchBox";
            this.tb_searchBox.Size = new System.Drawing.Size(0, 29);
            this.tb_searchBox.TabIndex = 5;
            // 
            // lbl_addQuantity
            // 
            this.lbl_addQuantity.AutoSize = true;
            this.lbl_addQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addQuantity.ForeColor = System.Drawing.Color.White;
            this.lbl_addQuantity.Location = new System.Drawing.Point(22, 20);
            this.lbl_addQuantity.Name = "lbl_addQuantity";
            this.lbl_addQuantity.Size = new System.Drawing.Size(183, 31);
            this.lbl_addQuantity.TabIndex = 4;
            this.lbl_addQuantity.Text = "Add Quantity";
            // 
            // tb_addQuantity
            // 
            this.tb_addQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_addQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_addQuantity.Location = new System.Drawing.Point(28, 129);
            this.tb_addQuantity.Name = "tb_addQuantity";
            this.tb_addQuantity.Size = new System.Drawing.Size(200, 38);
            this.tb_addQuantity.TabIndex = 1;
            this.tb_addQuantity.Text = "1";
            this.tb_addQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_addQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_addQuantity_KeyPress);
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OK.ForeColor = System.Drawing.Color.Black;
            this.btn_OK.Location = new System.Drawing.Point(259, 134);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 30);
            this.btn_OK.TabIndex = 11;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // form_addQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(394, 194);
            this.ControlBox = false;
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tb_addQuantity);
            this.Controls.Add(this.panel_addToCart);
            this.Controls.Add(this.panel_addQuantityHead);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_addQuantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel_addQuantityHead.ResumeLayout(false);
            this.panel_addToCart.ResumeLayout(false);
            this.panel_addToCart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_closeAddQuantity;
        private System.Windows.Forms.Panel panel_addQuantityHead;
        private System.Windows.Forms.Panel panel_addToCart;
        private System.Windows.Forms.TextBox tb_searchBox;
        private System.Windows.Forms.Label lbl_addQuantity;
        private System.Windows.Forms.TextBox tb_addQuantity;
        private System.Windows.Forms.Button btn_OK;
    }
}