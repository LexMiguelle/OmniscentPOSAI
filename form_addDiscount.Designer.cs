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
            this.tb_decNum = new System.Windows.Forms.TextBox();
            this.tb_discountedPrice = new System.Windows.Forms.TextBox();
            this.tb_wholeNum = new System.Windows.Forms.TextBox();
            this.tb_dot = new System.Windows.Forms.TextBox();
            this.tb_percentValue = new System.Windows.Forms.TextBox();
            this.lbl_OR = new System.Windows.Forms.Label();
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
            this.btn_closeAddDiscount.TabIndex = 0;
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
            this.tb_price.TabStop = false;
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
            this.btn_confirmDiscount.TabIndex = 3;
            this.btn_confirmDiscount.Text = "CONFIRM";
            this.btn_confirmDiscount.UseVisualStyleBackColor = false;
            this.btn_confirmDiscount.Click += new System.EventHandler(this.btn_confirmDiscount_Click);
            // 
            // tb_decNum
            // 
            this.tb_decNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_decNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_decNum.Location = new System.Drawing.Point(136, 215);
            this.tb_decNum.MaxLength = 2;
            this.tb_decNum.Name = "tb_decNum";
            this.tb_decNum.Size = new System.Drawing.Size(93, 24);
            this.tb_decNum.TabIndex = 2;
            this.tb_decNum.Text = "00";
            this.tb_decNum.TextChanged += new System.EventHandler(this.getDiscountPercentage_TextChanged);
            this.tb_decNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_decNum_KeyPress);
            // 
            // tb_discountedPrice
            // 
            this.tb_discountedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_discountedPrice.Location = new System.Drawing.Point(53, 277);
            this.tb_discountedPrice.Name = "tb_discountedPrice";
            this.tb_discountedPrice.ReadOnly = true;
            this.tb_discountedPrice.Size = new System.Drawing.Size(300, 31);
            this.tb_discountedPrice.TabIndex = 9;
            this.tb_discountedPrice.TabStop = false;
            // 
            // tb_wholeNum
            // 
            this.tb_wholeNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_wholeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_wholeNum.Location = new System.Drawing.Point(53, 215);
            this.tb_wholeNum.MaxLength = 1;
            this.tb_wholeNum.Name = "tb_wholeNum";
            this.tb_wholeNum.Size = new System.Drawing.Size(70, 24);
            this.tb_wholeNum.TabIndex = 1;
            this.tb_wholeNum.Text = "0";
            this.tb_wholeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_wholeNum.TextChanged += new System.EventHandler(this.getDiscountPercentage_TextChanged);
            this.tb_wholeNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_wholeNum_KeyPress);
            // 
            // tb_dot
            // 
            this.tb_dot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dot.Location = new System.Drawing.Point(123, 215);
            this.tb_dot.MaxLength = 4;
            this.tb_dot.Name = "tb_dot";
            this.tb_dot.ReadOnly = true;
            this.tb_dot.Size = new System.Drawing.Size(13, 24);
            this.tb_dot.TabIndex = 0;
            this.tb_dot.TabStop = false;
            this.tb_dot.Text = ".";
            this.tb_dot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_percentValue
            // 
            this.tb_percentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_percentValue.Location = new System.Drawing.Point(272, 215);
            this.tb_percentValue.MaxLength = 2;
            this.tb_percentValue.Name = "tb_percentValue";
            this.tb_percentValue.ReadOnly = true;
            this.tb_percentValue.Size = new System.Drawing.Size(81, 31);
            this.tb_percentValue.TabIndex = 0;
            this.tb_percentValue.TabStop = false;
            this.tb_percentValue.Text = "0%";
            this.tb_percentValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_OR
            // 
            this.lbl_OR.AutoSize = true;
            this.lbl_OR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OR.ForeColor = System.Drawing.Color.White;
            this.lbl_OR.Location = new System.Drawing.Point(236, 223);
            this.lbl_OR.Name = "lbl_OR";
            this.lbl_OR.Size = new System.Drawing.Size(29, 16);
            this.lbl_OR.TabIndex = 4;
            this.lbl_OR.Text = "OR";
            // 
            // form_addDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(404, 404);
            this.ControlBox = false;
            this.Controls.Add(this.btn_confirmDiscount);
            this.Controls.Add(this.lbl_OR);
            this.Controls.Add(this.tb_discountedPrice);
            this.Controls.Add(this.tb_dot);
            this.Controls.Add(this.tb_wholeNum);
            this.Controls.Add(this.tb_percentValue);
            this.Controls.Add(this.tb_decNum);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.lbl_discountedPrice);
            this.Controls.Add(this.lbl_discountPercentage);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.panel_checkPrice);
            this.Controls.Add(this.panel_addDiscountHead);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "form_addDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Button btn_confirmDiscount;
        public System.Windows.Forms.Label lbl_prc;
        public System.Windows.Forms.Label lbl_ID;
        public System.Windows.Forms.TextBox tb_price;
        public System.Windows.Forms.TextBox tb_decNum;
        public System.Windows.Forms.TextBox tb_discountedPrice;
        public System.Windows.Forms.TextBox tb_wholeNum;
        public System.Windows.Forms.TextBox tb_dot;
        public System.Windows.Forms.TextBox tb_percentValue;
        public System.Windows.Forms.Label lbl_OR;
    }
}