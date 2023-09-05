
namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            txtPrice = new System.Windows.Forms.TextBox();
            btnLoad = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            txtCarID = new System.Windows.Forms.TextBox();
            txtManufacturer = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            lbManufacturer = new System.Windows.Forms.Label();
            dgvCarList = new System.Windows.Forms.DataGridView();
            lbPrice = new System.Windows.Forms.Label();
            lbReleaseYear = new System.Windows.Forms.Label();
            lbCarID = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            txtReleaseYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(447, 35);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(203, 27);
            txtPrice.TabIndex = 38;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(121, 156);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 36;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(465, 156);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(293, 156);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(94, 29);
            btnNew.TabIndex = 34;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(122, 35);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(203, 27);
            txtCarID.TabIndex = 29;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new System.Drawing.Point(122, 113);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new System.Drawing.Size(203, 27);
            txtManufacturer.TabIndex = 30;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(122, 74);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(203, 27);
            txtCarName.TabIndex = 32;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new System.Drawing.Point(21, 114);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(97, 20);
            lbManufacturer.TabIndex = 23;
            lbManufacturer.Text = "Manufacturer";
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new System.Drawing.Point(7, 194);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new System.Drawing.Size(683, 188);
            dgvCarList.TabIndex = 28;
            dgvCarList.CellContentClick += dgvCarList_CellContentClick;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(344, 36);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(41, 20);
            lbPrice.TabIndex = 25;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new System.Drawing.Point(343, 77);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new System.Drawing.Size(101, 20);
            lbReleaseYear.TabIndex = 24;
            lbReleaseYear.Text = "Released Year";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(21, 36);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(50, 20);
            lbCarID.TabIndex = 22;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(21, 77);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(75, 20);
            lbCarName.TabIndex = 27;
            lbCarName.Text = "Car Name";
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(293, 389);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(447, 74);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(203, 27);
            txtReleaseYear.TabIndex = 31;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(697, 427);
            Controls.Add(txtPrice);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(txtCarID);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(lbManufacturer);
            Controls.Add(dgvCarList);
            Controls.Add(lbPrice);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbCarID);
            Controls.Add(lbCarName);
            Controls.Add(btnClose);
            Name = "frmCarManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtReleaseYear;
    }
}