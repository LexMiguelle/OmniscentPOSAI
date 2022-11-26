namespace OmniscentPOSAI
{
    partial class form_updateCategory
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
            this.lbl_updateCategory = new System.Windows.Forms.Label();
            this.panel_head = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_updateCategory = new System.Windows.Forms.TextBox();
            this.lbl_categoryName = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.panel_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_updateCategory
            // 
            this.lbl_updateCategory.AutoSize = true;
            this.lbl_updateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updateCategory.ForeColor = System.Drawing.Color.White;
            this.lbl_updateCategory.Location = new System.Drawing.Point(26, 19);
            this.lbl_updateCategory.Name = "lbl_updateCategory";
            this.lbl_updateCategory.Size = new System.Drawing.Size(235, 31);
            this.lbl_updateCategory.TabIndex = 0;
            this.lbl_updateCategory.Text = "Update Category";
            // 
            // panel_head
            // 
            this.panel_head.Controls.Add(this.lbl_updateCategory);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(720, 75);
            this.panel_head.TabIndex = 7;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(451, 161);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 25);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(568, 161);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 25);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_updateCategory
            // 
            this.tb_updateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_updateCategory.Location = new System.Drawing.Point(316, 113);
            this.tb_updateCategory.Name = "tb_updateCategory";
            this.tb_updateCategory.Size = new System.Drawing.Size(352, 26);
            this.tb_updateCategory.TabIndex = 9;
            // 
            // lbl_categoryName
            // 
            this.lbl_categoryName.AutoSize = true;
            this.lbl_categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoryName.ForeColor = System.Drawing.Color.White;
            this.lbl_categoryName.Location = new System.Drawing.Point(86, 108);
            this.lbl_categoryName.Name = "lbl_categoryName";
            this.lbl_categoryName.Size = new System.Drawing.Size(226, 31);
            this.lbl_categoryName.TabIndex = 8;
            this.lbl_categoryName.Text = "Category Name:";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.White;
            this.lbl_ID.Location = new System.Drawing.Point(88, 161);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 20);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "#";
            // 
            // form_updateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(720, 230);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_updateCategory);
            this.Controls.Add(this.lbl_categoryName);
            this.Controls.Add(this.panel_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_updateCategory";
            this.Text = "form_addCategory";
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_updateCategory;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_categoryName;
        public System.Windows.Forms.TextBox tb_updateCategory;
        public System.Windows.Forms.Label lbl_ID;
    }
}