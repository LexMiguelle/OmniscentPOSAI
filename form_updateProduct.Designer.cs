namespace OmniscentPOSAI
{
    partial class form_updateProduct
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
            this.panel_head = new System.Windows.Forms.Panel();
            this.lbl_pcode = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_updateProduct = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.lbl_productCode = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_productID = new System.Windows.Forms.Label();
            this.tb_productCode = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.tb_productID = new System.Windows.Forms.TextBox();
            this.tb_categoryPrefix = new System.Windows.Forms.TextBox();
            this.lbl_productCodeID = new System.Windows.Forms.Label();
            this.lbl_productNameID = new System.Windows.Forms.Label();
            this.lbl_restock = new System.Windows.Forms.Label();
            this.tb_restock = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_pcodeLength = new System.Windows.Forms.Label();
            this.panel_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_head
            // 
            this.panel_head.Controls.Add(this.lbl_pcodeLength);
            this.panel_head.Controls.Add(this.lbl_pcode);
            this.panel_head.Controls.Add(this.lbl_ID);
            this.panel_head.Controls.Add(this.lbl_updateProduct);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(630, 75);
            this.panel_head.TabIndex = 4;
            // 
            // lbl_pcode
            // 
            this.lbl_pcode.AutoSize = true;
            this.lbl_pcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pcode.ForeColor = System.Drawing.Color.White;
            this.lbl_pcode.Location = new System.Drawing.Point(261, 40);
            this.lbl_pcode.Name = "lbl_pcode";
            this.lbl_pcode.Size = new System.Drawing.Size(30, 31);
            this.lbl_pcode.TabIndex = 0;
            this.lbl_pcode.Text = "#";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(261, 9);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(30, 31);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "#";
            // 
            // lbl_updateProduct
            // 
            this.lbl_updateProduct.AutoSize = true;
            this.lbl_updateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updateProduct.ForeColor = System.Drawing.Color.White;
            this.lbl_updateProduct.Location = new System.Drawing.Point(26, 19);
            this.lbl_updateProduct.Name = "lbl_updateProduct";
            this.lbl_updateProduct.Size = new System.Drawing.Size(217, 31);
            this.lbl_updateProduct.TabIndex = 0;
            this.lbl_updateProduct.Text = "Update Product";
            // 
            // btn_cancel
            // 
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(480, 298);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(120, 30);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(355, 298);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(120, 30);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cb_category
            // 
            this.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(145, 191);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(455, 28);
            this.cb_category.TabIndex = 17;
            this.cb_category.TextChanged += new System.EventHandler(this.cb_category_TextChanged);
            // 
            // lbl_productCode
            // 
            this.lbl_productCode.AutoSize = true;
            this.lbl_productCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productCode.ForeColor = System.Drawing.Color.White;
            this.lbl_productCode.Location = new System.Drawing.Point(297, 98);
            this.lbl_productCode.Name = "lbl_productCode";
            this.lbl_productCode.Size = new System.Drawing.Size(137, 24);
            this.lbl_productCode.TabIndex = 8;
            this.lbl_productCode.Text = "productCode:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(75, 237);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(64, 24);
            this.lbl_price.TabIndex = 9;
            this.lbl_price.Text = "Price:";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.Color.White;
            this.lbl_category.Location = new System.Drawing.Point(40, 195);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(99, 24);
            this.lbl_category.TabIndex = 10;
            this.lbl_category.Text = "Category:";
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.ForeColor = System.Drawing.Color.White;
            this.lbl_productName.Location = new System.Drawing.Point(51, 145);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(88, 24);
            this.lbl_productName.TabIndex = 11;
            this.lbl_productName.Text = "Product:";
            // 
            // lbl_productID
            // 
            this.lbl_productID.AutoSize = true;
            this.lbl_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productID.ForeColor = System.Drawing.Color.White;
            this.lbl_productID.Location = new System.Drawing.Point(26, 98);
            this.lbl_productID.Name = "lbl_productID";
            this.lbl_productID.Size = new System.Drawing.Size(113, 24);
            this.lbl_productID.TabIndex = 12;
            this.lbl_productID.Text = "Product ID:";
            // 
            // tb_productCode
            // 
            this.tb_productCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_productCode.Location = new System.Drawing.Point(481, 96);
            this.tb_productCode.Name = "tb_productCode";
            this.tb_productCode.Size = new System.Drawing.Size(119, 26);
            this.tb_productCode.TabIndex = 13;
            this.tb_productCode.TextChanged += new System.EventHandler(this.tb_productCode_TextChanged);
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(145, 235);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(121, 26);
            this.tb_price.TabIndex = 14;
            this.tb_price.TextChanged += new System.EventHandler(this.tb_price_TextChanged);
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // tb_productName
            // 
            this.tb_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_productName.Location = new System.Drawing.Point(145, 143);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(455, 26);
            this.tb_productName.TabIndex = 15;
            this.tb_productName.TextChanged += new System.EventHandler(this.tb_productName_TextChanged);
            this.tb_productName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_productName_KeyPress);
            // 
            // tb_productID
            // 
            this.tb_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_productID.Location = new System.Drawing.Point(201, 96);
            this.tb_productID.Name = "tb_productID";
            this.tb_productID.ReadOnly = true;
            this.tb_productID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_productID.Size = new System.Drawing.Size(90, 26);
            this.tb_productID.TabIndex = 16;
            this.tb_productID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_productID_KeyPress);
            // 
            // tb_categoryPrefix
            // 
            this.tb_categoryPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_categoryPrefix.Location = new System.Drawing.Point(440, 96);
            this.tb_categoryPrefix.Name = "tb_categoryPrefix";
            this.tb_categoryPrefix.ReadOnly = true;
            this.tb_categoryPrefix.Size = new System.Drawing.Size(35, 26);
            this.tb_categoryPrefix.TabIndex = 16;
            // 
            // lbl_productCodeID
            // 
            this.lbl_productCodeID.AutoSize = true;
            this.lbl_productCodeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productCodeID.ForeColor = System.Drawing.Color.White;
            this.lbl_productCodeID.Location = new System.Drawing.Point(441, 77);
            this.lbl_productCodeID.Name = "lbl_productCodeID";
            this.lbl_productCodeID.Size = new System.Drawing.Size(14, 16);
            this.lbl_productCodeID.TabIndex = 0;
            this.lbl_productCodeID.Text = "#";
            // 
            // lbl_productNameID
            // 
            this.lbl_productNameID.AutoSize = true;
            this.lbl_productNameID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productNameID.ForeColor = System.Drawing.Color.White;
            this.lbl_productNameID.Location = new System.Drawing.Point(142, 124);
            this.lbl_productNameID.Name = "lbl_productNameID";
            this.lbl_productNameID.Size = new System.Drawing.Size(14, 16);
            this.lbl_productNameID.TabIndex = 0;
            this.lbl_productNameID.Text = "#";
            // 
            // lbl_restock
            // 
            this.lbl_restock.AutoSize = true;
            this.lbl_restock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restock.ForeColor = System.Drawing.Color.White;
            this.lbl_restock.Location = new System.Drawing.Point(292, 235);
            this.lbl_restock.Name = "lbl_restock";
            this.lbl_restock.Size = new System.Drawing.Size(146, 24);
            this.lbl_restock.TabIndex = 20;
            this.lbl_restock.Text = "Restock Level:";
            // 
            // tb_restock
            // 
            this.tb_restock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_restock.Location = new System.Drawing.Point(444, 235);
            this.tb_restock.MaxLength = 8;
            this.tb_restock.Name = "tb_restock";
            this.tb_restock.Size = new System.Drawing.Size(150, 26);
            this.tb_restock.TabIndex = 21;
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(145, 96);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(50, 26);
            this.tb_ID.TabIndex = 16;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_productID_KeyPress);
            // 
            // lbl_pcodeLength
            // 
            this.lbl_pcodeLength.AutoSize = true;
            this.lbl_pcodeLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pcodeLength.ForeColor = System.Drawing.Color.White;
            this.lbl_pcodeLength.Location = new System.Drawing.Point(496, 19);
            this.lbl_pcodeLength.Name = "lbl_pcodeLength";
            this.lbl_pcodeLength.Size = new System.Drawing.Size(30, 31);
            this.lbl_pcodeLength.TabIndex = 0;
            this.lbl_pcodeLength.Text = "#";
            // 
            // form_updateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(630, 350);
            this.Controls.Add(this.lbl_restock);
            this.Controls.Add(this.tb_restock);
            this.Controls.Add(this.lbl_productNameID);
            this.Controls.Add(this.lbl_productCodeID);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.lbl_productCode);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.lbl_productID);
            this.Controls.Add(this.tb_productCode);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_productName);
            this.Controls.Add(this.tb_categoryPrefix);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_productID);
            this.Controls.Add(this.panel_head);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_updateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_updateProduct";
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label lbl_updateProduct;
        private System.Windows.Forms.Label lbl_productCode;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_productID;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.ComboBox cb_category;
        public System.Windows.Forms.TextBox tb_productCode;
        public System.Windows.Forms.TextBox tb_price;
        public System.Windows.Forms.TextBox tb_productName;
        public System.Windows.Forms.TextBox tb_productID;
        public System.Windows.Forms.TextBox tb_categoryPrefix;
        private System.Windows.Forms.Label lbl_productCodeID;
        private System.Windows.Forms.Label lbl_productNameID;
        public System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_restock;
        public System.Windows.Forms.TextBox tb_restock;
        public System.Windows.Forms.TextBox tb_ID;
        public System.Windows.Forms.Label lbl_pcode;
        public System.Windows.Forms.Label lbl_pcodeLength;
    }
}