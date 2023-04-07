namespace EF_Project.Forms
{
    partial class WarehouseForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.warhouseAddress = new System.Windows.Forms.TextBox();
            this.website = new System.Windows.Forms.Label();
            this.updateWarehouse = new System.Windows.Forms.Button();
            this.deleteWarehouse = new System.Windows.Forms.Button();
            this.addWarehouse = new System.Windows.Forms.Button();
            this.warehouseName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.warhouseID = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.warhouseResPerson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.warhouses = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 235);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1523, 420);
            this.dataGridView1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 46;
            // 
            // warhouseAddress
            // 
            this.warhouseAddress.Location = new System.Drawing.Point(711, 124);
            this.warhouseAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.warhouseAddress.Multiline = true;
            this.warhouseAddress.Name = "warhouseAddress";
            this.warhouseAddress.Size = new System.Drawing.Size(379, 43);
            this.warhouseAddress.TabIndex = 45;
            // 
            // website
            // 
            this.website.AutoSize = true;
            this.website.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.website.Location = new System.Drawing.Point(705, 91);
            this.website.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(102, 29);
            this.website.TabIndex = 44;
            this.website.Text = "Address";
            // 
            // updateWarehouse
            // 
            this.updateWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateWarehouse.Location = new System.Drawing.Point(557, 184);
            this.updateWarehouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateWarehouse.Name = "updateWarehouse";
            this.updateWarehouse.Size = new System.Drawing.Size(104, 36);
            this.updateWarehouse.TabIndex = 37;
            this.updateWarehouse.Text = "Update";
            this.updateWarehouse.UseVisualStyleBackColor = true;
            this.updateWarehouse.Click += new System.EventHandler(this.updateWarehouse_Click);
            // 
            // deleteWarehouse
            // 
            this.deleteWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteWarehouse.Location = new System.Drawing.Point(697, 184);
            this.deleteWarehouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteWarehouse.Name = "deleteWarehouse";
            this.deleteWarehouse.Size = new System.Drawing.Size(110, 36);
            this.deleteWarehouse.TabIndex = 36;
            this.deleteWarehouse.Text = "Delete";
            this.deleteWarehouse.UseVisualStyleBackColor = true;
            this.deleteWarehouse.Click += new System.EventHandler(this.deleteWarehouse_Click);
            // 
            // addWarehouse
            // 
            this.addWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWarehouse.Location = new System.Drawing.Point(397, 184);
            this.addWarehouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addWarehouse.Name = "addWarehouse";
            this.addWarehouse.Size = new System.Drawing.Size(125, 36);
            this.addWarehouse.TabIndex = 35;
            this.addWarehouse.Text = "Add";
            this.addWarehouse.UseVisualStyleBackColor = true;
            this.addWarehouse.Click += new System.EventHandler(this.addWarehouse_Click);
            // 
            // warehouseName
            // 
            this.warehouseName.Location = new System.Drawing.Point(207, 124);
            this.warehouseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.warehouseName.Multiline = true;
            this.warehouseName.Name = "warehouseName";
            this.warehouseName.Size = new System.Drawing.Size(479, 43);
            this.warehouseName.TabIndex = 32;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(201, 91);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(78, 29);
            this.name.TabIndex = 31;
            this.name.Text = "Name";
            // 
            // warhouseID
            // 
            this.warhouseID.Location = new System.Drawing.Point(35, 124);
            this.warhouseID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.warhouseID.Multiline = true;
            this.warhouseID.Name = "warhouseID";
            this.warhouseID.Size = new System.Drawing.Size(141, 43);
            this.warhouseID.TabIndex = 30;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(29, 91);
            this.id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(36, 29);
            this.id.TabIndex = 29;
            this.id.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1455, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 49;
            // 
            // warhouseResPerson
            // 
            this.warhouseResPerson.Location = new System.Drawing.Point(1112, 124);
            this.warhouseResPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.warhouseResPerson.Multiline = true;
            this.warhouseResPerson.Name = "warhouseResPerson";
            this.warhouseResPerson.Size = new System.Drawing.Size(379, 43);
            this.warhouseResPerson.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1107, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "Responsible Person";
            // 
            // warhouses
            // 
            this.warhouses.FormattingEnabled = true;
            this.warhouses.Location = new System.Drawing.Point(34, 191);
            this.warhouses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.warhouses.Name = "warhouses";
            this.warhouses.Size = new System.Drawing.Size(294, 24);
            this.warhouses.TabIndex = 50;
            this.warhouses.SelectedIndexChanged += new System.EventHandler(this.warhouses_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "Warehouse";
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 670);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.warhouses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warhouseResPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.warhouseAddress);
            this.Controls.Add(this.website);
            this.Controls.Add(this.updateWarehouse);
            this.Controls.Add(this.deleteWarehouse);
            this.Controls.Add(this.addWarehouse);
            this.Controls.Add(this.warehouseName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.warhouseID);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WarehouseForm";
            this.Text = "Warehouse Manage";
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox warhouseAddress;
        private System.Windows.Forms.Label website;
        private System.Windows.Forms.Button updateWarehouse;
        private System.Windows.Forms.Button deleteWarehouse;
        private System.Windows.Forms.Button addWarehouse;
        private System.Windows.Forms.TextBox warehouseName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox warhouseID;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox warhouseResPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox warhouses;
        private System.Windows.Forms.Label label3;
    }
}