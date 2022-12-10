namespace OmniscentPOSAI
{
    partial class module_categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_categories = new System.Windows.Forms.DataGridView();
            this.categories_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categories_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriescategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categories_categoryPrefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categories_edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.categories_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_categories = new System.Windows.Forms.Label();
            this.panel_head = new System.Windows.Forms.Panel();
            this.btn_addCategory = new System.Windows.Forms.LinkLabel();
            this.lbl_catID = new System.Windows.Forms.Label();
            this.searchCategory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).BeginInit();
            this.panel_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_categories
            // 
            this.dgv_categories.AllowUserToAddRows = false;
            this.dgv_categories.AllowUserToDeleteRows = false;
            this.dgv_categories.AllowUserToResizeColumns = false;
            this.dgv_categories.AllowUserToResizeRows = false;
            this.dgv_categories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_categories.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_categories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_categories.ColumnHeadersHeight = 25;
            this.dgv_categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categories_num,
            this.categories_ID,
            this.categoriescategory,
            this.categories_categoryPrefix,
            this.categories_edit,
            this.categories_delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_categories.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_categories.EnableHeadersVisualStyles = false;
            this.dgv_categories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_categories.Location = new System.Drawing.Point(0, 75);
            this.dgv_categories.MultiSelect = false;
            this.dgv_categories.Name = "dgv_categories";
            this.dgv_categories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_categories.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_categories.RowHeadersVisible = false;
            this.dgv_categories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_categories.Size = new System.Drawing.Size(1064, 661);
            this.dgv_categories.TabIndex = 3;
            this.dgv_categories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_categories_CellContentClick);
            this.dgv_categories.SelectionChanged += new System.EventHandler(this.dgv_categories_SelectionChanged);
            // 
            // categories_num
            // 
            this.categories_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.categories_num.HeaderText = "#";
            this.categories_num.MinimumWidth = 25;
            this.categories_num.Name = "categories_num";
            this.categories_num.ReadOnly = true;
            this.categories_num.Width = 25;
            // 
            // categories_ID
            // 
            this.categories_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.categories_ID.FillWeight = 90.14085F;
            this.categories_ID.HeaderText = "ID";
            this.categories_ID.Name = "categories_ID";
            this.categories_ID.ReadOnly = true;
            this.categories_ID.Visible = false;
            this.categories_ID.Width = 43;
            // 
            // categoriescategory
            // 
            this.categoriescategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoriescategory.FillWeight = 90.14085F;
            this.categoriescategory.HeaderText = "CATEGORY";
            this.categoriescategory.Name = "categoriescategory";
            this.categoriescategory.ReadOnly = true;
            // 
            // categories_categoryPrefix
            // 
            this.categories_categoryPrefix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.categories_categoryPrefix.HeaderText = "PREFIX";
            this.categories_categoryPrefix.Name = "categories_categoryPrefix";
            this.categories_categoryPrefix.ReadOnly = true;
            this.categories_categoryPrefix.Width = 69;
            // 
            // categories_edit
            // 
            this.categories_edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.categories_edit.FillWeight = 169.0141F;
            this.categories_edit.HeaderText = "";
            this.categories_edit.Image = global::OmniscentPOSAI.Properties.Resources.edit_16;
            this.categories_edit.MinimumWidth = 30;
            this.categories_edit.Name = "categories_edit";
            this.categories_edit.ReadOnly = true;
            this.categories_edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categories_edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categories_edit.Width = 30;
            // 
            // categories_delete
            // 
            this.categories_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.categories_delete.HeaderText = "";
            this.categories_delete.Image = global::OmniscentPOSAI.Properties.Resources.trash_16;
            this.categories_delete.MinimumWidth = 30;
            this.categories_delete.Name = "categories_delete";
            this.categories_delete.ReadOnly = true;
            this.categories_delete.Width = 30;
            // 
            // lbl_categories
            // 
            this.lbl_categories.AutoSize = true;
            this.lbl_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categories.ForeColor = System.Drawing.Color.White;
            this.lbl_categories.Location = new System.Drawing.Point(26, 19);
            this.lbl_categories.Name = "lbl_categories";
            this.lbl_categories.Size = new System.Drawing.Size(156, 31);
            this.lbl_categories.TabIndex = 0;
            this.lbl_categories.Text = "Categories";
            // 
            // panel_head
            // 
            this.panel_head.Controls.Add(this.searchCategory);
            this.panel_head.Controls.Add(this.btn_addCategory);
            this.panel_head.Controls.Add(this.lbl_catID);
            this.panel_head.Controls.Add(this.lbl_categories);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(1064, 75);
            this.panel_head.TabIndex = 2;
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.AutoSize = true;
            this.btn_addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCategory.LinkColor = System.Drawing.Color.White;
            this.btn_addCategory.Location = new System.Drawing.Point(653, 25);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(114, 20);
            this.btn_addCategory.TabIndex = 1;
            this.btn_addCategory.TabStop = true;
            this.btn_addCategory.Text = "[Add Category]";
            this.btn_addCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_addCategory_LinkClicked);
            // 
            // lbl_catID
            // 
            this.lbl_catID.AutoSize = true;
            this.lbl_catID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_catID.ForeColor = System.Drawing.Color.White;
            this.lbl_catID.Location = new System.Drawing.Point(524, 19);
            this.lbl_catID.Name = "lbl_catID";
            this.lbl_catID.Size = new System.Drawing.Size(30, 31);
            this.lbl_catID.TabIndex = 0;
            this.lbl_catID.Text = "#";
            // 
            // searchCategory
            // 
            this.searchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCategory.Location = new System.Drawing.Point(785, 19);
            this.searchCategory.Name = "searchCategory";
            this.searchCategory.Size = new System.Drawing.Size(250, 29);
            this.searchCategory.TabIndex = 2;
            this.searchCategory.TextChanged += new System.EventHandler(this.searchCategory_TextChanged);
            // 
            // module_categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1064, 736);
            this.Controls.Add(this.dgv_categories);
            this.Controls.Add(this.panel_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "module_categories";
            this.Text = "module_categories";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).EndInit();
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_categories;
        private System.Windows.Forms.Label lbl_categories;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.LinkLabel btn_addCategory;
        private System.Windows.Forms.Label lbl_catID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categories_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn categories_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriescategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn categories_categoryPrefix;
        private System.Windows.Forms.DataGridViewImageColumn categories_edit;
        private System.Windows.Forms.DataGridViewImageColumn categories_delete;
        private System.Windows.Forms.TextBox searchCategory;
    }
}