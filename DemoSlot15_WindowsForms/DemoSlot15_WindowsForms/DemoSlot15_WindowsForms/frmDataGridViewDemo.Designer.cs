
namespace DemoSlot15_WindowsForms
{
    partial class frmDataGridViewDemo
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProducts.Location = new System.Drawing.Point(0, 108);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 33;
            this.dgvProducts.Size = new System.Drawing.Size(800, 342);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(50, 58);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(259, 34);
            this.btnTable.TabIndex = 1;
            this.btnTable.Text = "Binding with DataTable";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(326, 58);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(219, 34);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Binding with List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // frmDataGridViewDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.dgvProducts);
            this.Name = "frmDataGridViewDemo";
            this.Text = "frmDataGridViewDemo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnList;
    }
}