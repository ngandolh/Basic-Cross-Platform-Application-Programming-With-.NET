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
            lbProductID = new System.Windows.Forms.Label();
            txtProductID = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            lbProductName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtUnitStock = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtCategoryID = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnCreate = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(58, 57);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(75, 20);
            lbProductID.TabIndex = 0;
            lbProductID.Text = "ProductID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(218, 57);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(263, 27);
            txtProductID.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(218, 103);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(263, 27);
            txtProductName.TabIndex = 2;
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new System.Drawing.Point(58, 103);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(100, 20);
            lbProductName.TabIndex = 3;
            lbProductName.Text = "ProductName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(52, 166);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 20);
            label1.TabIndex = 4;
            label1.Text = "Unit in Stock";
            // 
            // txtUnitStock
            // 
            txtUnitStock.Location = new System.Drawing.Point(218, 159);
            txtUnitStock.Name = "txtUnitStock";
            txtUnitStock.Size = new System.Drawing.Size(263, 27);
            txtUnitStock.TabIndex = 5;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(218, 220);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(263, 27);
            txtUnitPrice.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(60, 223);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "Unit Price";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new System.Drawing.Point(218, 275);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new System.Drawing.Size(263, 27);
            txtCategoryID.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(60, 282);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 20);
            label3.TabIndex = 9;
            label3.Text = "Category ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(503, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(453, 362);
            dataGridView1.TabIndex = 10;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(37, 363);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 29);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(155, 363);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(275, 363);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(387, 363);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmProductManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(980, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnCreate);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(txtCategoryID);
            Controls.Add(label2);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtUnitStock);
            Controls.Add(label1);
            Controls.Add(lbProductName);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(lbProductID);
            Name = "frmProductManagement";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitStock;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
