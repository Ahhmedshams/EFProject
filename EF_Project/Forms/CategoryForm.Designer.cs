namespace EF_Project.Forms
{
    partial class CategoryForm
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
            this.code = new System.Windows.Forms.Label();
            this.categoryCode = new System.Windows.Forms.TextBox();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.categoryUnit = new System.Windows.Forms.TextBox();
            this.unit = new System.Windows.Forms.Label();
            this.addCategory = new System.Windows.Forms.Button();
            this.deleteCategory = new System.Windows.Forms.Button();
            this.updateCategory = new System.Windows.Forms.Button();
            this.categories = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryPeriod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.Location = new System.Drawing.Point(38, 149);
            this.code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(72, 29);
            this.code.TabIndex = 0;
            this.code.Text = "Code";
            // 
            // categoryCode
            // 
            this.categoryCode.Location = new System.Drawing.Point(43, 192);
            this.categoryCode.Margin = new System.Windows.Forms.Padding(4);
            this.categoryCode.Multiline = true;
            this.categoryCode.Name = "categoryCode";
            this.categoryCode.Size = new System.Drawing.Size(340, 43);
            this.categoryCode.TabIndex = 1;
            this.categoryCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(413, 192);
            this.categoryName.Margin = new System.Windows.Forms.Padding(4);
            this.categoryName.Multiline = true;
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(338, 43);
            this.categoryName.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(525, 149);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(78, 29);
            this.name.TabIndex = 2;
            this.name.Text = "Name";
            // 
            // categoryUnit
            // 
            this.categoryUnit.Location = new System.Drawing.Point(774, 192);
            this.categoryUnit.Margin = new System.Windows.Forms.Padding(4);
            this.categoryUnit.Multiline = true;
            this.categoryUnit.Name = "categoryUnit";
            this.categoryUnit.Size = new System.Drawing.Size(337, 43);
            this.categoryUnit.TabIndex = 5;
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit.Location = new System.Drawing.Point(897, 149);
            this.unit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(55, 29);
            this.unit.TabIndex = 4;
            this.unit.Text = "Unit";
            // 
            // addCategory
            // 
            this.addCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory.Location = new System.Drawing.Point(1137, 302);
            this.addCategory.Margin = new System.Windows.Forms.Padding(4);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(145, 26);
            this.addCategory.TabIndex = 7;
            this.addCategory.Text = "Add";
            this.addCategory.UseVisualStyleBackColor = true;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // deleteCategory
            // 
            this.deleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCategory.Location = new System.Drawing.Point(1137, 413);
            this.deleteCategory.Margin = new System.Windows.Forms.Padding(4);
            this.deleteCategory.Name = "deleteCategory";
            this.deleteCategory.Size = new System.Drawing.Size(145, 26);
            this.deleteCategory.TabIndex = 8;
            this.deleteCategory.Text = "Delete";
            this.deleteCategory.UseVisualStyleBackColor = true;
            this.deleteCategory.Click += new System.EventHandler(this.deleteCategory_Click);
            // 
            // updateCategory
            // 
            this.updateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCategory.Location = new System.Drawing.Point(1137, 358);
            this.updateCategory.Margin = new System.Windows.Forms.Padding(4);
            this.updateCategory.Name = "updateCategory";
            this.updateCategory.Size = new System.Drawing.Size(145, 26);
            this.updateCategory.TabIndex = 9;
            this.updateCategory.Text = "Update";
            this.updateCategory.UseVisualStyleBackColor = true;
            this.updateCategory.Click += new System.EventHandler(this.updateCategory_Click);
            // 
            // categories
            // 
            this.categories.FormattingEnabled = true;
            this.categories.Location = new System.Drawing.Point(902, 27);
            this.categories.Margin = new System.Windows.Forms.Padding(4);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(472, 24);
            this.categories.TabIndex = 10;
            this.categories.SelectedIndexChanged += new System.EventHandler(this.categories_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 268);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 386);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1171, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Expired After (Month)";
            // 
            // categoryPeriod
            // 
            this.categoryPeriod.Location = new System.Drawing.Point(1137, 192);
            this.categoryPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.categoryPeriod.Multiline = true;
            this.categoryPeriod.Name = "categoryPeriod";
            this.categoryPeriod.Size = new System.Drawing.Size(339, 43);
            this.categoryPeriod.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 670);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categories);
            this.Controls.Add(this.updateCategory);
            this.Controls.Add(this.deleteCategory);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.categoryPeriod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryUnit);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.categoryCode);
            this.Controls.Add(this.code);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoryForm";
            this.Text = "Category Manage";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label code;
        private System.Windows.Forms.TextBox categoryCode;
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox categoryUnit;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.Button deleteCategory;
        private System.Windows.Forms.Button updateCategory;
        private System.Windows.Forms.ComboBox categories;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryPeriod;
        private System.Windows.Forms.Label label2;
    }
}