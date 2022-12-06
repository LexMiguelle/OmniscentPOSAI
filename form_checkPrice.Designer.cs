namespace OmniscentPOSAI
{
    partial class form_checkPrice
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
            this.panel_checkPriceHead = new System.Windows.Forms.Panel();
            this.btn_closeCheckPrice = new System.Windows.Forms.Button();
            this.lbl_checkPrice = new System.Windows.Forms.Label();
            this.lbl_productID = new System.Windows.Forms.Label();
            this.lbl_product = new System.Windows.Forms.Label();
            this.lbl_productCode = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.tb_productID = new System.Windows.Forms.TextBox();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.tb_category = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_productCode = new System.Windows.Forms.TextBox();
            this.panel_checkPrice = new System.Windows.Forms.Panel();
            this.btn_scanBarcode = new System.Windows.Forms.Button();
            this.panel_checkPriceHead.SuspendLayout();
            this.panel_checkPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_checkPriceHead
            // 
            this.panel_checkPriceHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_checkPriceHead.Controls.Add(this.btn_closeCheckPrice);
            this.panel_checkPriceHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_checkPriceHead.Location = new System.Drawing.Point(0, 0);
            this.panel_checkPriceHead.Name = "panel_checkPriceHead";
            this.panel_checkPriceHead.Size = new System.Drawing.Size(414, 30);
            this.panel_checkPriceHead.TabIndex = 0;
            // 
            // btn_closeCheckPrice
            // 
            this.btn_closeCheckPrice.BackColor = System.Drawing.Color.Red;
            this.btn_closeCheckPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeCheckPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeCheckPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeCheckPrice.ForeColor = System.Drawing.Color.White;
            this.btn_closeCheckPrice.Location = new System.Drawing.Point(384, 0);
            this.btn_closeCheckPrice.Name = "btn_closeCheckPrice";
            this.btn_closeCheckPrice.Size = new System.Drawing.Size(28, 28);
            this.btn_closeCheckPrice.TabIndex = 5;
            this.btn_closeCheckPrice.Text = "X";
            this.btn_closeCheckPrice.UseVisualStyleBackColor = false;
            this.btn_closeCheckPrice.Click += new System.EventHandler(this.btn_closeCheckPrice_Click);
            // 
            // lbl_checkPrice
            // 
            this.lbl_checkPrice.AutoSize = true;
            this.lbl_checkPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_checkPrice.Location = new System.Drawing.Point(22, 20);
            this.lbl_checkPrice.Name = "lbl_checkPrice";
            this.lbl_checkPrice.Size = new System.Drawing.Size(172, 31);
            this.lbl_checkPrice.TabIndex = 4;
            this.lbl_checkPrice.Text = "Check Price";
            // 
            // lbl_productID
            // 
            this.lbl_productID.AutoSize = true;
            this.lbl_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productID.ForeColor = System.Drawing.Color.White;
            this.lbl_productID.Location = new System.Drawing.Point(46, 129);
            this.lbl_productID.Name = "lbl_productID";
            this.lbl_productID.Size = new System.Drawing.Size(102, 24);
            this.lbl_productID.TabIndex = 4;
            this.lbl_productID.Text = "Product ID:";
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product.ForeColor = System.Drawing.Color.White;
            this.lbl_product.Location = new System.Drawing.Point(68, 171);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(80, 24);
            this.lbl_product.TabIndex = 4;
            this.lbl_product.Text = "Product:";
            // 
            // lbl_productCode
            // 
            this.lbl_productCode.AutoSize = true;
            this.lbl_productCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productCode.ForeColor = System.Drawing.Color.White;
            this.lbl_productCode.Location = new System.Drawing.Point(17, 295);
            this.lbl_productCode.Name = "lbl_productCode";
            this.lbl_productCode.Size = new System.Drawing.Size(131, 24);
            this.lbl_productCode.TabIndex = 4;
            this.lbl_productCode.Text = "Product Code:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(90, 255);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(58, 24);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price:";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.Color.White;
            this.lbl_category.Location = new System.Drawing.Point(58, 213);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(90, 24);
            this.lbl_category.TabIndex = 4;
            this.lbl_category.Text = "Category:";
            // 
            // tb_productID
            // 
            this.tb_productID.Enabled = false;
            this.tb_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_productID.Location = new System.Drawing.Point(154, 127);
            this.tb_productID.Name = "tb_productID";
            this.tb_productID.Size = new System.Drawing.Size(200, 26);
            this.tb_productID.TabIndex = 6;
            // 
            // tb_productName
            // 
            this.tb_productName.Enabled = false;
            this.tb_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_productName.Location = new System.Drawing.Point(154, 169);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(200, 26);
            this.tb_productName.TabIndex = 6;
            // 
            // tb_category
            // 
            this.tb_category.Enabled = false;
            this.tb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_category.Location = new System.Drawing.Point(154, 211);
            this.tb_category.Name = "tb_category";
            this.tb_category.Size = new System.Drawing.Size(200, 26);
            this.tb_category.TabIndex = 6;
            // 
            // tb_price
            // 
            this.tb_price.Enabled = false;
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(154, 253);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(200, 26);
            this.tb_price.TabIndex = 6;
            // 
            // tb_productCode
            // 
            this.tb_productCode.Enabled = false;
            this.tb_productCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_productCode.Location = new System.Drawing.Point(154, 295);
            this.tb_productCode.Name = "tb_productCode";
            this.tb_productCode.Size = new System.Drawing.Size(200, 26);
            this.tb_productCode.TabIndex = 6;
            this.tb_productCode.TextChanged += new System.EventHandler(this.tb_productCode_TextChanged);
            this.tb_productCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_productCode_KeyPress);
            // 
            // panel_checkPrice
            // 
            this.panel_checkPrice.Controls.Add(this.lbl_checkPrice);
            this.panel_checkPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_checkPrice.Location = new System.Drawing.Point(0, 30);
            this.panel_checkPrice.Name = "panel_checkPrice";
            this.panel_checkPrice.Size = new System.Drawing.Size(414, 75);
            this.panel_checkPrice.TabIndex = 7;
            // 
            // btn_scanBarcode
            // 
            this.btn_scanBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_scanBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_scanBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scanBarcode.ForeColor = System.Drawing.Color.Black;
            this.btn_scanBarcode.Location = new System.Drawing.Point(154, 352);
            this.btn_scanBarcode.Name = "btn_scanBarcode";
            this.btn_scanBarcode.Size = new System.Drawing.Size(200, 40);
            this.btn_scanBarcode.TabIndex = 8;
            this.btn_scanBarcode.Text = "SCAN";
            this.btn_scanBarcode.UseVisualStyleBackColor = false;
            this.btn_scanBarcode.Click += new System.EventHandler(this.btn_scanBarcode_Click);
            // 
            // form_checkPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(414, 414);
            this.ControlBox = false;
            this.Controls.Add(this.btn_scanBarcode);
            this.Controls.Add(this.panel_checkPrice);
            this.Controls.Add(this.tb_productCode);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_category);
            this.Controls.Add(this.tb_productName);
            this.Controls.Add(this.tb_productID);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_productCode);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.lbl_productID);
            this.Controls.Add(this.panel_checkPriceHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_checkPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel_checkPriceHead.ResumeLayout(false);
            this.panel_checkPrice.ResumeLayout(false);
            this.panel_checkPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_checkPriceHead;
        private System.Windows.Forms.Label lbl_checkPrice;
        private System.Windows.Forms.Label lbl_productID;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Label lbl_productCode;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_closeCheckPrice;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.TextBox tb_productID;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.TextBox tb_category;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_productCode;
        private System.Windows.Forms.Panel panel_checkPrice;
        private System.Windows.Forms.Button btn_scanBarcode;
    }
}