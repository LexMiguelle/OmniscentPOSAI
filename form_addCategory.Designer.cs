namespace OmniscentPOSAI
{
    partial class form_addCategory
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
            this.lbl_addCategory = new System.Windows.Forms.Label();
            this.panel_head = new System.Windows.Forms.Panel();
            this.lbl_categoryName = new System.Windows.Forms.Label();
            this.tb_addCategory = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_addCategory
            // 
            this.lbl_addCategory.AutoSize = true;
            this.lbl_addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addCategory.ForeColor = System.Drawing.Color.White;
            this.lbl_addCategory.Location = new System.Drawing.Point(26, 19);
            this.lbl_addCategory.Name = "lbl_addCategory";
            this.lbl_addCategory.Size = new System.Drawing.Size(192, 31);
            this.lbl_addCategory.TabIndex = 0;
            this.lbl_addCategory.Text = "Add Category";
            // 
            // panel_head
            // 
            this.panel_head.Controls.Add(this.lbl_addCategory);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(720, 75);
            this.panel_head.TabIndex = 3;
            // 
            // lbl_categoryName
            // 
            this.lbl_categoryName.AutoSize = true;
            this.lbl_categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoryName.ForeColor = System.Drawing.Color.White;
            this.lbl_categoryName.Location = new System.Drawing.Point(88, 111);
            this.lbl_categoryName.Name = "lbl_categoryName";
            this.lbl_categoryName.Size = new System.Drawing.Size(226, 31);
            this.lbl_categoryName.TabIndex = 0;
            this.lbl_categoryName.Text = "Category Name:";
            // 
            // tb_addCategory
            // 
            this.tb_addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_addCategory.Location = new System.Drawing.Point(318, 116);
            this.tb_addCategory.Name = "tb_addCategory";
            this.tb_addCategory.Size = new System.Drawing.Size(352, 26);
            this.tb_addCategory.TabIndex = 4;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(570, 164);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 25);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(453, 164);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 25);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // form_addCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(720, 230);
            this.ControlBox = false;
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_addCategory);
            this.Controls.Add(this.panel_head);
            this.Controls.Add(this.lbl_categoryName);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_addCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_addCategory";
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_addCategory;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label lbl_categoryName;
        private System.Windows.Forms.TextBox tb_addCategory;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
    }
}