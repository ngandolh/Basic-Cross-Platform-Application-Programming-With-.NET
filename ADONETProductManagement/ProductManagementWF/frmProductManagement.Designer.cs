namespace ProductManagementWF
{
    partial class frmProductManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            lblUnitPrice = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cboCategory = new System.Windows.Forms.ComboBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtUnitsInStock = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            txtProductId = new System.Windows.Forms.TextBox();
            dgvProducts = new System.Windows.Forms.DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblUnitPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtUnitsInStock);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductId);
            groupBox1.Location = new System.Drawing.Point(2, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupBox1.Size = new System.Drawing.Size(393, 254);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Information";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(294, 217);
            btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(90, 27);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(199, 217);
            btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(90, 27);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new System.Drawing.Point(105, 217);
            btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(90, 27);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(10, 217);
            btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(90, 27);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(17, 179);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(88, 20);
            label5.TabIndex = 2;
            label5.Text = "Category ID";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new System.Drawing.Point(17, 137);
            lblUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new System.Drawing.Size(72, 20);
            lblUnitPrice.TabIndex = 2;
            lblUnitPrice.Text = "Unit Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(17, 102);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Units in Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 61);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 27);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Product ID";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new System.Drawing.Point(175, 173);
            cboCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new System.Drawing.Size(197, 28);
            cboCategory.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(175, 134);
            txtUnitPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(165, 27);
            txtUnitPrice.TabIndex = 0;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new System.Drawing.Point(175, 98);
            txtUnitsInStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new System.Drawing.Size(114, 27);
            txtUnitsInStock.TabIndex = 0;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(175, 61);
            txtProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(197, 27);
            txtProductName.TabIndex = 0;
            // 
            // txtProductId
            // 
            txtProductId.Enabled = false;
            txtProductId.Location = new System.Drawing.Point(175, 27);
            txtProductId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new System.Drawing.Size(114, 27);
            txtProductId.TabIndex = 0;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = System.Windows.Forms.DockStyle.Right;
            dgvProducts.Location = new System.Drawing.Point(411, 0);
            dgvProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.RowTemplate.Height = 33;
            dgvProducts.Size = new System.Drawing.Size(378, 265);
            dgvProducts.TabIndex = 4;
            // 
            // frmProductManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(789, 265);
            Controls.Add(groupBox1);
            Controls.Add(dgvProducts);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "frmProductManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PM";
            Load += frmProductManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}
