namespace ProductManagementWindowsForms
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
            dgvProducts = new System.Windows.Forms.DataGridView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnDelete = new System.Windows.Forms.Button();
            cboCategory = new System.Windows.Forms.ComboBox();
            btnUpdate = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            txtProductId = new System.Windows.Forms.TextBox();
            btnCreate = new System.Windows.Forms.Button();
            txtProductName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtUnitsInStock = new System.Windows.Forms.TextBox();
            lblUnitPrice = new System.Windows.Forms.Label();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = System.Windows.Forms.DockStyle.Right;
            dgvProducts.Location = new System.Drawing.Point(420, 0);
            dgvProducts.Margin = new System.Windows.Forms.Padding(2);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.RowTemplate.Height = 33;
            dgvProducts.Size = new System.Drawing.Size(314, 284);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtProductId);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtUnitsInStock);
            groupBox1.Controls.Add(lblUnitPrice);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(412, 284);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product information";
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(302, 218);
            btnDelete.Margin = new System.Windows.Forms.Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(90, 27);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new System.Drawing.Point(184, 174);
            cboCategory.Margin = new System.Windows.Forms.Padding(2);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new System.Drawing.Size(209, 28);
            cboCategory.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(208, 218);
            btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(90, 27);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 62);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 20);
            label2.TabIndex = 13;
            label2.Text = "Product Name";
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new System.Drawing.Point(114, 218);
            btnSave.Margin = new System.Windows.Forms.Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(90, 27);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtProductId
            // 
            txtProductId.Enabled = false;
            txtProductId.Location = new System.Drawing.Point(184, 28);
            txtProductId.Margin = new System.Windows.Forms.Padding(2);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new System.Drawing.Size(114, 27);
            txtProductId.TabIndex = 9;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(19, 218);
            btnCreate.Margin = new System.Windows.Forms.Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(90, 27);
            btnCreate.TabIndex = 16;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(184, 62);
            txtProductName.Margin = new System.Windows.Forms.Padding(2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(209, 27);
            txtProductName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(26, 174);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(88, 20);
            label5.TabIndex = 10;
            label5.Text = "Category ID";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new System.Drawing.Point(184, 98);
            txtUnitsInStock.Margin = new System.Windows.Forms.Padding(2);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new System.Drawing.Size(209, 27);
            txtUnitsInStock.TabIndex = 7;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new System.Drawing.Point(26, 138);
            lblUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new System.Drawing.Size(72, 20);
            lblUnitPrice.TabIndex = 11;
            lblUnitPrice.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(184, 135);
            txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(209, 27);
            txtUnitPrice.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 103);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 20);
            label3.TabIndex = 12;
            label3.Text = "Units in Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 28);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 20);
            label1.TabIndex = 14;
            label1.Text = "Product ID";
            // 
            // frmProductManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(734, 284);
            Controls.Add(groupBox1);
            Controls.Add(dgvProducts);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmProductManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Product Management";
            Load += frmProductManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
