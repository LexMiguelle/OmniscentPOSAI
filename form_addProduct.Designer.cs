namespace OmniscentPOSAI
{
    partial class form_addProduct
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
            this.lbl_addProducts = new System.Windows.Forms.Label();
            this.tb_productID = new System.Windows.Forms.TextBox();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.lbl_productID = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_productCode = new System.Windows.Forms.Label();
            this.tb_productCode = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_categoryPrefix = new System.Windows.Forms.TextBox();
            this.tb_restock = new System.Windows.Forms.TextBox();
            this.lbl_restock = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.panel_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_head
            // 
            this.panel_head.Controls.Add(this.lbl_addProducts);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(630, 75);
            this.panel_head.TabIndex = 4;
            // 
            // lbl_addProducts
            // 
            this.lbl_addProducts.AutoSize = true;
            this.lbl_addProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addProducts.ForeColor = System.Drawing.Color.White;
            this.lbl_addProducts.Location = new System.Drawing.Point(26, 19);
            this.lbl_addProducts.Name = "lbl_addProducts";
            this.lbl_addProducts.Size = new System.Drawing.Size(174, 31);
            this.lbl_addProducts.TabIndex = 0;
            this.lbl_addProducts.Text = "Add Product";
            // 
            // tb_productID
            // 
            this.tb_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_productID.Location = new System.Drawing.Point(190, 99);
            this.tb_productID.MaxLength = 4;
            this.tb_productID.Name = "tb_productID";
            this.tb_productID.Size = new System.Drawing.Size(74, 26);
            this.tb_productID.TabIndex = 1;
            this.tb_productID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_productID_KeyPress);
            // 
            // tb_productName
            // 
            this.tb_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_productName.Location = new System.Drawing.Point(143, 149);
            this.tb_productName.MaxLength = 50;
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(455, 26);
            this.tb_productName.TabIndex = 2;
            this.tb_productName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_productName_KeyPress);
            // 
            // lbl_productID
            // 
            this.lbl_productID.AutoSize = true;
            this.lbl_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productID.ForeColor = System.Drawing.Color.White;
            this.lbl_productID.Location = new System.Drawing.Point(24, 99);
            this.lbl_productID.Name = "lbl_productID";
            this.lbl_productID.Size = new System.Drawing.Size(113, 24);
            this.lbl_productID.TabIndex = 0;
            this.lbl_productID.Text = "Product ID:";
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.ForeColor = System.Drawing.Color.White;
            this.lbl_productName.Location = new System.Drawing.Point(49, 151);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(88, 24);
            this.lbl_productName.TabIndex = 0;
            this.lbl_productName.Text = "Product:";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.Color.White;
            this.lbl_category.Location = new System.Drawing.Point(38, 197);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(99, 24);
            this.lbl_category.TabIndex = 0;
            this.lbl_category.Text = "Category:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(73, 242);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(64, 24);
            this.lbl_price.TabIndex = 0;
            this.lbl_price.Text = "Price:";
            // 
            // lbl_productCode
            // 
            this.lbl_productCode.AutoSize = true;
            this.lbl_productCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productCode.ForeColor = System.Drawing.Color.White;
            this.lbl_productCode.Location = new System.Drawing.Point(270, 99);
            this.lbl_productCode.Name = "lbl_productCode";
            this.lbl_productCode.Size = new System.Drawing.Size(137, 24);
            this.lbl_productCode.TabIndex = 0;
            this.lbl_productCode.Text = "productCode:";
            // 
            // tb_productCode
            // 
            this.tb_productCode.Enabled = false;
            this.tb_productCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_productCode.Location = new System.Drawing.Point(448, 99);
            this.tb_productCode.Name = "tb_productCode";
            this.tb_productCode.ReadOnly = true;
            this.tb_productCode.Size = new System.Drawing.Size(150, 26);
            this.tb_productCode.TabIndex = 5;
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(143, 240);
            this.tb_price.MaxLength = 8;
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(121, 26);
            this.tb_price.TabIndex = 4;
            this.tb_price.TextChanged += new System.EventHandler(this.tb_price_TextChanged);
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // cb_category
            // 
            this.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(143, 193);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(455, 28);
            this.cb_category.TabIndex = 3;
            this.cb_category.TextChanged += new System.EventHandler(this.cb_category_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(353, 299);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 30);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(478, 299);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(120, 30);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_categoryPrefix
            // 
            this.tb_categoryPrefix.Enabled = false;
            this.tb_categoryPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_categoryPrefix.Location = new System.Drawing.Point(413, 99);
            this.tb_categoryPrefix.Name = "tb_categoryPrefix";
            this.tb_categoryPrefix.ReadOnly = true;
            this.tb_categoryPrefix.Size = new System.Drawing.Size(29, 26);
            this.tb_categoryPrefix.TabIndex = 5;
            // 
            // tb_restock
            // 
            this.tb_restock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_restock.Location = new System.Drawing.Point(448, 240);
            this.tb_restock.MaxLength = 8;
            this.tb_restock.Name = "tb_restock";
            this.tb_restock.Size = new System.Drawing.Size(150, 26);
            this.tb_restock.TabIndex = 4;
            this.tb_restock.TextChanged += new System.EventHandler(this.tb_price_TextChanged);
            this.tb_restock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // lbl_restock
            // 
            this.lbl_restock.AutoSize = true;
            this.lbl_restock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restock.ForeColor = System.Drawing.Color.White;
            this.lbl_restock.Location = new System.Drawing.Point(296, 240);
            this.lbl_restock.Name = "lbl_restock";
            this.lbl_restock.Size = new System.Drawing.Size(146, 24);
            this.lbl_restock.TabIndex = 0;
            this.lbl_restock.Text = "Restock Level:";
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(143, 99);
            this.tb_ID.MaxLength = 4;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(40, 26);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_productID_KeyPress);
            // 
            // form_addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(630, 350);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.lbl_productCode);
            this.Controls.Add(this.lbl_restock);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.lbl_productID);
            this.Controls.Add(this.tb_productCode);
            this.Controls.Add(this.tb_restock);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_productName);
            this.Controls.Add(this.tb_categoryPrefix);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.tb_productID);
            this.Controls.Add(this.panel_head);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_addProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_addProduct";
            this.Load += new System.EventHandler(this.form_addProduct_Load);
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label lbl_addProducts;
        private System.Windows.Forms.Label lbl_productID;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_productCode;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.TextBox tb_productID;
        public System.Windows.Forms.TextBox tb_productName;
        public System.Windows.Forms.TextBox tb_productCode;
        public System.Windows.Forms.TextBox tb_price;
        public System.Windows.Forms.ComboBox cb_category;
        public System.Windows.Forms.TextBox tb_categoryPrefix;
        public System.Windows.Forms.TextBox tb_restock;
        private System.Windows.Forms.Label lbl_restock;
        public System.Windows.Forms.TextBox tb_ID;
    }
}