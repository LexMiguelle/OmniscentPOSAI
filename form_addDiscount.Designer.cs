namespace OmniscentPOSAI
{
    partial class form_addDiscount
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
            this.btn_closeAddDiscount = new System.Windows.Forms.Button();
            this.panel_addDiscountHead = new System.Windows.Forms.Panel();
            this.lbl_addDiscount = new System.Windows.Forms.Label();
            this.panel_checkPrice = new System.Windows.Forms.Panel();
            this.lbl_prc = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_discountPercentage = new System.Windows.Forms.Label();
            this.lbl_discountedPrice = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.btn_confirmDiscount = new System.Windows.Forms.Button();
            this.tb_discountPercentage = new System.Windows.Forms.TextBox();
            this.tb_discountedPrice = new System.Windows.Forms.TextBox();
            this.panel_addDiscountHead.SuspendLayout();
            this.panel_checkPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_closeAddDiscount
            // 
            this.btn_closeAddDiscount.BackColor = System.Drawing.Color.Red;
            this.btn_closeAddDiscount.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeAddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeAddDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeAddDiscount.ForeColor = System.Drawing.Color.White;
            this.btn_closeAddDiscount.Location = new System.Drawing.Point(374, 0);
            this.btn_closeAddDiscount.Name = "btn_closeAddDiscount";
            this.btn_closeAddDiscount.Size = new System.Drawing.Size(28, 28);
            this.btn_closeAddDiscount.TabIndex = 5;
            this.btn_closeAddDiscount.Text = "X";
            this.btn_closeAddDiscount.UseVisualStyleBackColor = false;
            this.btn_closeAddDiscount.Click += new System.EventHandler(this.btn_closeAddDiscount_Click);
            // 
            // panel_addDiscountHead
            // 
            this.panel_addDiscountHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_addDiscountHead.Controls.Add(this.btn_closeAddDiscount);
            this.panel_addDiscountHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_addDiscountHead.Location = new System.Drawing.Point(0, 0);
            this.panel_addDiscountHead.Name = "panel_addDiscountHead";
            this.panel_addDiscountHead.Size = new System.Drawing.Size(404, 30);
            this.panel_addDiscountHead.TabIndex = 1;
            // 
            // lbl_addDiscount
            // 
            this.lbl_addDiscount.AutoSize = true;
            this.lbl_addDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addDiscount.ForeColor = System.Drawing.Color.White;
            this.lbl_addDiscount.Location = new System.Drawing.Point(22, 20);
            this.lbl_addDiscount.Name = "lbl_addDiscount";
            this.lbl_addDiscount.Size = new System.Drawing.Size(188, 31);
            this.lbl_addDiscount.TabIndex = 4;
            this.lbl_addDiscount.Text = "Add Discount";
            // 
            // panel_checkPrice
            // 
            this.panel_checkPrice.Controls.Add(this.lbl_prc);
            this.panel_checkPrice.Controls.Add(this.lbl_ID);
            this.panel_checkPrice.Controls.Add(this.lbl_addDiscount);
            this.panel_checkPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_checkPrice.Location = new System.Drawing.Point(0, 30);
            this.panel_checkPrice.Name = "panel_checkPrice";
            this.panel_checkPrice.Size = new System.Drawing.Size(404, 75);
            this.panel_checkPrice.TabIndex = 8;
            // 
            // lbl_prc
            // 
            this.lbl_prc.AutoSize = true;
            this.lbl_prc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prc.ForeColor = System.Drawing.Color.White;
            this.lbl_prc.Location = new System.Drawing.Point(331, 36);
            this.lbl_prc.Name = "lbl_prc";
            this.lbl_prc.Size = new System.Drawing.Size(29, 16);
            this.lbl_prc.TabIndex = 4;
            this.lbl_prc.Text = "prc";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(331, 20);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(22, 16);
            this.lbl_ID.TabIndex = 4;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(48, 125);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(67, 25);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price:";
            // 
            // lbl_discountPercentage
            // 
            this.lbl_discountPercentage.AutoSize = true;
            this.lbl_discountPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discountPercentage.ForeColor = System.Drawing.Color.White;
            this.lbl_discountPercentage.Location = new System.Drawing.Point(48, 187);
            this.lbl_discountPercentage.Name = "lbl_discountPercentage";
            this.lbl_discountPercentage.Size = new System.Drawing.Size(218, 25);
            this.lbl_discountPercentage.TabIndex = 4;
            this.lbl_discountPercentage.Text = "Discount Percentage:";
            // 
            // lbl_discountedPrice
            // 
            this.lbl_discountedPrice.AutoSize = true;
            this.lbl_discountedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discountedPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_discountedPrice.Location = new System.Drawing.Point(48, 249);
            this.lbl_discountedPrice.Name = "lbl_discountedPrice";
            this.lbl_discountedPrice.Size = new System.Drawing.Size(181, 25);
            this.lbl_discountedPrice.TabIndex = 4;
            this.lbl_discountedPrice.Text = "Discounted Price:";
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(53, 153);
            this.tb_price.Name = "tb_price";
            this.tb_price.ReadOnly = true;
            this.tb_price.Size = new System.Drawing.Size(300, 31);
            this.tb_price.TabIndex = 9;
            // 
            // btn_confirmDiscount
            // 
            this.btn_confirmDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_confirmDiscount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_confirmDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmDiscount.ForeColor = System.Drawing.Color.Black;
            this.btn_confirmDiscount.Location = new System.Drawing.Point(0, 329);
            this.btn_confirmDiscount.Name = "btn_confirmDiscount";
            this.btn_confirmDiscount.Size = new System.Drawing.Size(404, 75);
            this.btn_confirmDiscount.TabIndex = 10;
            this.btn_confirmDiscount.Text = "CONFIRM";
            this.btn_confirmDiscount.UseVisualStyleBackColor = false;
            this.btn_confirmDiscount.Click += new System.EventHandler(this.btn_confirmDiscount_Click);
            // 
            // tb_discountPercentage
            // 
            this.tb_discountPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_discountPercentage.Location = new System.Drawing.Point(53, 215);
            this.tb_discountPercentage.Name = "tb_discountPercentage";
            this.tb_discountPercentage.Size = new System.Drawing.Size(300, 31);
            this.tb_discountPercentage.TabIndex = 9;
            this.tb_discountPercentage.TextChanged += new System.EventHandler(this.tb_discountPercentage_TextChanged);
            // 
            // tb_discountedPrice
            // 
            this.tb_discountedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_discountedPrice.Location = new System.Drawing.Point(53, 277);
            this.tb_discountedPrice.Name = "tb_discountedPrice";
            this.tb_discountedPrice.ReadOnly = true;
            this.tb_discountedPrice.Size = new System.Drawing.Size(300, 31);
            this.tb_discountedPrice.TabIndex = 9;
            // 
            // form_addDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(404, 404);
            this.ControlBox = false;
            this.Controls.Add(this.btn_confirmDiscount);
            this.Controls.Add(this.tb_discountedPrice);
            this.Controls.Add(this.tb_discountPercentage);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.lbl_discountedPrice);
            this.Controls.Add(this.lbl_discountPercentage);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.panel_checkPrice);
            this.Controls.Add(this.panel_addDiscountHead);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "form_addDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_addDiscountHead.ResumeLayout(false);
            this.panel_checkPrice.ResumeLayout(false);
            this.panel_checkPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_closeAddDiscount;
        private System.Windows.Forms.Panel panel_addDiscountHead;
        private System.Windows.Forms.Label lbl_addDiscount;
        private System.Windows.Forms.Panel panel_checkPrice;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_discountPercentage;
        private System.Windows.Forms.Label lbl_discountedPrice;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Button btn_confirmDiscount;
        private System.Windows.Forms.TextBox tb_discountPercentage;
        private System.Windows.Forms.TextBox tb_discountedPrice;
        public System.Windows.Forms.Label lbl_prc;
        public System.Windows.Forms.Label lbl_ID;
    }
}