namespace PRN211PE_FALL22_StudentFullName_
{
    partial class ManagementForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvListCusAccount = new System.Windows.Forms.DataGridView();
            this.customerAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCusAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListCusAccount
            // 
            this.dgvListCusAccount.AutoGenerateColumns = false;
            this.dgvListCusAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCusAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractIdDataGridViewTextBoxColumn,
            this.contractCodeDataGridViewTextBoxColumn,
            this.contractNameDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.carIdDataGridViewTextBoxColumn});
            this.dgvListCusAccount.DataSource = this.contractBindingSource;
            this.dgvListCusAccount.Location = new System.Drawing.Point(63, 30);
            this.dgvListCusAccount.MultiSelect = false;
            this.dgvListCusAccount.Name = "dgvListCusAccount";
            this.dgvListCusAccount.RowHeadersWidth = 51;
            this.dgvListCusAccount.RowTemplate.Height = 29;
            this.dgvListCusAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCusAccount.Size = new System.Drawing.Size(681, 282);
            this.dgvListCusAccount.TabIndex = 0;
            this.dgvListCusAccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCusAccount_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 409);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 44);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(341, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(608, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 44);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "CLose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(341, 337);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 44);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(152, 346);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(138, 27);
            this.txtSearch.TabIndex = 6;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataSource = typeof(CarContracts_StudentName_LIB.Models.Contract);
            // 
            // contractIdDataGridViewTextBoxColumn
            // 
            this.contractIdDataGridViewTextBoxColumn.DataPropertyName = "ContractId";
            this.contractIdDataGridViewTextBoxColumn.HeaderText = "ContractId";
            this.contractIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contractIdDataGridViewTextBoxColumn.Name = "contractIdDataGridViewTextBoxColumn";
            this.contractIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // contractCodeDataGridViewTextBoxColumn
            // 
            this.contractCodeDataGridViewTextBoxColumn.DataPropertyName = "ContractCode";
            this.contractCodeDataGridViewTextBoxColumn.HeaderText = "ContractCode";
            this.contractCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contractCodeDataGridViewTextBoxColumn.Name = "contractCodeDataGridViewTextBoxColumn";
            this.contractCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // contractNameDataGridViewTextBoxColumn
            // 
            this.contractNameDataGridViewTextBoxColumn.DataPropertyName = "ContractName";
            this.contractNameDataGridViewTextBoxColumn.HeaderText = "ContractName";
            this.contractNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contractNameDataGridViewTextBoxColumn.Name = "contractNameDataGridViewTextBoxColumn";
            this.contractNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            this.carIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvListCusAccount);
            this.Name = "ManagementForm";
            this.Text = "ManagementForm";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCusAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvListCusAccount;
        private DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn openDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regionNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private BindingSource customerAccountBindingSource;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClose;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn contractIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contractCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contractNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private BindingSource contractBindingSource;
    }
}