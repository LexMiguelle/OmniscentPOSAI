
namespace OmniscentPOSAI
{
    partial class module_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(module_admin));
            this.panel_head = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.btn_records = new System.Windows.Forms.Button();
            this.btn_stocks = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_categories = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panel_activity = new System.Windows.Forms.Panel();
            this.panel_head.SuspendLayout();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_head
            // 
            this.panel_head.Controls.Add(this.btn_close);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(1364, 30);
            this.panel_head.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1334, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.Black;
            this.panel_menu.Controls.Add(this.lbl_role);
            this.panel_menu.Controls.Add(this.lbl_name);
            this.panel_menu.Controls.Add(this.btn_logout);
            this.panel_menu.Controls.Add(this.btn_users);
            this.panel_menu.Controls.Add(this.btn_sales);
            this.panel_menu.Controls.Add(this.btn_records);
            this.panel_menu.Controls.Add(this.btn_stocks);
            this.panel_menu.Controls.Add(this.btn_products);
            this.panel_menu.Controls.Add(this.btn_categories);
            this.panel_menu.Controls.Add(this.btn_dashboard);
            this.panel_menu.Controls.Add(this.pb_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 30);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(300, 736);
            this.panel_menu.TabIndex = 1;
            // 
            // lbl_role
            // 
            this.lbl_role.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_role.AutoSize = true;
            this.lbl_role.BackColor = System.Drawing.Color.Transparent;
            this.lbl_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.Color.White;
            this.lbl_role.Location = new System.Drawing.Point(122, 275);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(51, 20);
            this.lbl_role.TabIndex = 2;
            this.lbl_role.Text = "@role";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(65, 244);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(170, 31);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "@username";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(0, 676);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(300, 60);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_users
            // 
            this.btn_users.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.ForeColor = System.Drawing.Color.White;
            this.btn_users.Location = new System.Drawing.Point(0, 594);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(300, 40);
            this.btn_users.TabIndex = 1;
            this.btn_users.Text = "Users";
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.ForeColor = System.Drawing.Color.White;
            this.btn_sales.Location = new System.Drawing.Point(0, 502);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(300, 40);
            this.btn_sales.TabIndex = 1;
            this.btn_sales.Text = "Sales";
            this.btn_sales.UseVisualStyleBackColor = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_records
            // 
            this.btn_records.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_records.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_records.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_records.ForeColor = System.Drawing.Color.White;
            this.btn_records.Location = new System.Drawing.Point(0, 548);
            this.btn_records.Name = "btn_records";
            this.btn_records.Size = new System.Drawing.Size(300, 40);
            this.btn_records.TabIndex = 1;
            this.btn_records.Text = "Records";
            this.btn_records.UseVisualStyleBackColor = true;
            this.btn_records.Click += new System.EventHandler(this.btn_records_Click);
            // 
            // btn_stocks
            // 
            this.btn_stocks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stocks.ForeColor = System.Drawing.Color.White;
            this.btn_stocks.Location = new System.Drawing.Point(0, 456);
            this.btn_stocks.Name = "btn_stocks";
            this.btn_stocks.Size = new System.Drawing.Size(300, 40);
            this.btn_stocks.TabIndex = 1;
            this.btn_stocks.Text = "Stocks";
            this.btn_stocks.UseVisualStyleBackColor = true;
            this.btn_stocks.Click += new System.EventHandler(this.btn_stocks_Click);
            // 
            // btn_products
            // 
            this.btn_products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_products.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_products.ForeColor = System.Drawing.Color.White;
            this.btn_products.Location = new System.Drawing.Point(0, 410);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(300, 40);
            this.btn_products.TabIndex = 1;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_categories
            // 
            this.btn_categories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_categories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categories.ForeColor = System.Drawing.Color.White;
            this.btn_categories.Location = new System.Drawing.Point(0, 364);
            this.btn_categories.Name = "btn_categories";
            this.btn_categories.Size = new System.Drawing.Size(300, 40);
            this.btn_categories.TabIndex = 1;
            this.btn_categories.Text = "Categories";
            this.btn_categories.UseVisualStyleBackColor = true;
            this.btn_categories.Click += new System.EventHandler(this.btn_categories_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 318);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(300, 40);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(53, 32);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(200, 200);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // panel_activity
            // 
            this.panel_activity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_activity.Location = new System.Drawing.Point(300, 30);
            this.panel_activity.Name = "panel_activity";
            this.panel_activity.Size = new System.Drawing.Size(1064, 736);
            this.panel_activity.TabIndex = 2;
            // 
            // module_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1364, 766);
            this.ControlBox = false;
            this.Controls.Add(this.panel_activity);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "module_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_head.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.Button btn_logout;
        public System.Windows.Forms.Button btn_stocks;
        public System.Windows.Forms.Button btn_products;
        public System.Windows.Forms.Button btn_categories;
        public System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Panel panel_activity;
        public System.Windows.Forms.Button btn_users;
        public System.Windows.Forms.Button btn_sales;
        public System.Windows.Forms.Button btn_records;
    }
}