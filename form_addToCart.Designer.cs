namespace OmniscentPOSAI
{
    partial class form_addToCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_addToCartHead = new System.Windows.Forms.Panel();
            this.btn_closeAddToCart = new System.Windows.Forms.Button();
            this.lbl_addToCart = new System.Windows.Forms.Label();
            this.panel_addToCart = new System.Windows.Forms.Panel();
            this.tb_searchProductList = new System.Windows.Forms.TextBox();
            this.tb_searchBox = new System.Windows.Forms.TextBox();
            this.dgv_productList = new System.Windows.Forms.DataGridView();
            this.productList_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productList_productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productList_productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productList_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productList_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productList_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productList_add = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_addToCartHead.SuspendLayout();
            this.panel_addToCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_addToCartHead
            // 
            this.panel_addToCartHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_addToCartHead.Controls.Add(this.btn_closeAddToCart);
            this.panel_addToCartHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_addToCartHead.Location = new System.Drawing.Point(0, 0);
            this.panel_addToCartHead.Name = "panel_addToCartHead";
            this.panel_addToCartHead.Size = new System.Drawing.Size(960, 30);
            this.panel_addToCartHead.TabIndex = 2;
            // 
            // btn_closeAddToCart
            // 
            this.btn_closeAddToCart.BackColor = System.Drawing.Color.Red;
            this.btn_closeAddToCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeAddToCart.ForeColor = System.Drawing.Color.White;
            this.btn_closeAddToCart.Location = new System.Drawing.Point(930, 0);
            this.btn_closeAddToCart.Name = "btn_closeAddToCart";
            this.btn_closeAddToCart.Size = new System.Drawing.Size(28, 28);
            this.btn_closeAddToCart.TabIndex = 5;
            this.btn_closeAddToCart.Text = "X";
            this.btn_closeAddToCart.UseVisualStyleBackColor = false;
            this.btn_closeAddToCart.Click += new System.EventHandler(this.btn_closeAddToCart_Click);
            // 
            // lbl_addToCart
            // 
            this.lbl_addToCart.AutoSize = true;
            this.lbl_addToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addToCart.ForeColor = System.Drawing.Color.White;
            this.lbl_addToCart.Location = new System.Drawing.Point(22, 20);
            this.lbl_addToCart.Name = "lbl_addToCart";
            this.lbl_addToCart.Size = new System.Drawing.Size(162, 31);
            this.lbl_addToCart.TabIndex = 4;
            this.lbl_addToCart.Text = "Add to Cart";
            // 
            // panel_addToCart
            // 
            this.panel_addToCart.Controls.Add(this.tb_searchProductList);
            this.panel_addToCart.Controls.Add(this.tb_searchBox);
            this.panel_addToCart.Controls.Add(this.lbl_addToCart);
            this.panel_addToCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_addToCart.Location = new System.Drawing.Point(0, 30);
            this.panel_addToCart.Name = "panel_addToCart";
            this.panel_addToCart.Size = new System.Drawing.Size(960, 75);
            this.panel_addToCart.TabIndex = 9;
            // 
            // tb_searchProductList
            // 
            this.tb_searchProductList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_searchProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchProductList.Location = new System.Drawing.Point(628, 23);
            this.tb_searchProductList.Name = "tb_searchProductList";
            this.tb_searchProductList.Size = new System.Drawing.Size(300, 26);
            this.tb_searchProductList.TabIndex = 6;
            this.tb_searchProductList.TextChanged += new System.EventHandler(this.tb_searchProductList_TextChanged);
            // 
            // tb_searchBox
            // 
            this.tb_searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchBox.Location = new System.Drawing.Point(628, 20);
            this.tb_searchBox.Name = "tb_searchBox";
            this.tb_searchBox.Size = new System.Drawing.Size(0, 29);
            this.tb_searchBox.TabIndex = 5;
            // 
            // dgv_productList
            // 
            this.dgv_productList.AllowUserToAddRows = false;
            this.dgv_productList.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_productList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_productList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_productList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productList.ColumnHeadersHeight = 25;
            this.dgv_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productList_num,
            this.productList_productID,
            this.productList_productName,
            this.productList_category,
            this.productList_quantity,
            this.productList_price,
            this.productList_add});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_productList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_productList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_productList.EnableHeadersVisualStyles = false;
            this.dgv_productList.GridColor = System.Drawing.Color.Black;
            this.dgv_productList.Location = new System.Drawing.Point(0, 105);
            this.dgv_productList.MultiSelect = false;
            this.dgv_productList.Name = "dgv_productList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_productList.RowHeadersVisible = false;
            this.dgv_productList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productList.Size = new System.Drawing.Size(960, 327);
            this.dgv_productList.TabIndex = 10;
            this.dgv_productList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productList_CellContentClick);
            // 
            // productList_num
            // 
            this.productList_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productList_num.HeaderText = "#";
            this.productList_num.MinimumWidth = 25;
            this.productList_num.Name = "productList_num";
            this.productList_num.ReadOnly = true;
            this.productList_num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productList_num.Width = 25;
            // 
            // productList_productID
            // 
            this.productList_productID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productList_productID.HeaderText = "PRODUCT ID";
            this.productList_productID.Name = "productList_productID";
            this.productList_productID.ReadOnly = true;
            this.productList_productID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productList_productID.Width = 97;
            // 
            // productList_productName
            // 
            this.productList_productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productList_productName.HeaderText = "PRODUCT";
            this.productList_productName.Name = "productList_productName";
            this.productList_productName.ReadOnly = true;
            this.productList_productName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productList_category
            // 
            this.productList_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productList_category.HeaderText = "CATEGORY";
            this.productList_category.Name = "productList_category";
            this.productList_category.ReadOnly = true;
            this.productList_category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productList_category.Width = 89;
            // 
            // productList_quantity
            // 
            this.productList_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productList_quantity.HeaderText = "QUANTITY";
            this.productList_quantity.Name = "productList_quantity";
            this.productList_quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productList_quantity.Width = 85;
            // 
            // productList_price
            // 
            this.productList_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productList_price.HeaderText = "PRICE";
            this.productList_price.Name = "productList_price";
            this.productList_price.ReadOnly = true;
            this.productList_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productList_price.Width = 62;
            // 
            // productList_add
            // 
            this.productList_add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productList_add.HeaderText = "";
            this.productList_add.MinimumWidth = 25;
            this.productList_add.Name = "productList_add";
            this.productList_add.ReadOnly = true;
            this.productList_add.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.productList_add.Width = 25;
            // 
            // form_addToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(960, 432);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_productList);
            this.Controls.Add(this.panel_addToCart);
            this.Controls.Add(this.panel_addToCartHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_addToCart";
            this.panel_addToCartHead.ResumeLayout(false);
            this.panel_addToCart.ResumeLayout(false);
            this.panel_addToCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_addToCartHead;
        private System.Windows.Forms.Button btn_closeAddToCart;
        private System.Windows.Forms.Label lbl_addToCart;
        private System.Windows.Forms.Panel panel_addToCart;
        private System.Windows.Forms.TextBox tb_searchBox;
        public System.Windows.Forms.DataGridView dgv_productList;
        public System.Windows.Forms.TextBox tb_searchProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn productList_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn productList_productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productList_productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productList_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn productList_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productList_price;
        private System.Windows.Forms.DataGridViewImageColumn productList_add;
    }
}