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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_categories = new System.Windows.Forms.DataGridView();
            this.col_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_categories = new System.Windows.Forms.Label();
            this.panel_head = new System.Windows.Forms.Panel();
            this.btn_addCategory = new System.Windows.Forms.LinkLabel();
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
            this.dgv_categories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_categories.ColumnHeadersHeight = 25;
            this.dgv_categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_no,
            this.col_ID,
            this.col_category,
            this.col_edit,
            this.col_delete});
            this.dgv_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_categories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_categories.Location = new System.Drawing.Point(0, 75);
            this.dgv_categories.Name = "dgv_categories";
            this.dgv_categories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_categories.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_categories.RowHeadersVisible = false;
            this.dgv_categories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_categories.Size = new System.Drawing.Size(1064, 661);
            this.dgv_categories.TabIndex = 3;
            this.dgv_categories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_categories_CellContentClick);
            // 
            // col_no
            // 
            this.col_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_no.HeaderText = "#";
            this.col_no.MinimumWidth = 25;
            this.col_no.Name = "col_no";
            this.col_no.Width = 25;
            // 
            // col_ID
            // 
            this.col_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_ID.FillWeight = 90.14085F;
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.Visible = false;
            this.col_ID.Width = 43;
            // 
            // col_category
            // 
            this.col_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_category.FillWeight = 90.14085F;
            this.col_category.HeaderText = "Category";
            this.col_category.Name = "col_category";
            // 
            // col_edit
            // 
            this.col_edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_edit.FillWeight = 169.0141F;
            this.col_edit.HeaderText = "";
            this.col_edit.MinimumWidth = 30;
            this.col_edit.Name = "col_edit";
            this.col_edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_edit.Width = 30;
            // 
            // col_delete
            // 
            this.col_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_delete.HeaderText = "";
            this.col_delete.MinimumWidth = 30;
            this.col_delete.Name = "col_delete";
            this.col_delete.Width = 30;
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
            this.panel_head.Controls.Add(this.btn_addCategory);
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
            this.btn_addCategory.Location = new System.Drawing.Point(885, 29);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(114, 20);
            this.btn_addCategory.TabIndex = 1;
            this.btn_addCategory.TabStop = true;
            this.btn_addCategory.Text = "[Add Category]";
            this.btn_addCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_addCategory_LinkClicked);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn col_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category;
        private System.Windows.Forms.DataGridViewImageColumn col_edit;
        private System.Windows.Forms.DataGridViewImageColumn col_delete;
        private System.Windows.Forms.Label lbl_categories;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.LinkLabel btn_addCategory;
    }
}