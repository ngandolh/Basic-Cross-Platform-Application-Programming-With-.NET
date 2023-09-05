namespace AutomobileWinAp
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
            lbCarID = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            lbManufacturer = new System.Windows.Forms.Label();
            txtCarID = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            txtManufacturer = new System.Windows.Forms.TextBox();
            lbPrice = new System.Windows.Forms.Label();
            lbReleaseYear = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            txtReleaseYear = new System.Windows.Forms.TextBox();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dgvCarList = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(28, 49);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(46, 20);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "CarID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(27, 103);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(71, 20);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "CarName";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new System.Drawing.Point(27, 162);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(97, 20);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(132, 49);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(289, 27);
            txtCarID.TabIndex = 3;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(132, 103);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(289, 27);
            txtCarName.TabIndex = 4;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new System.Drawing.Point(132, 155);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new System.Drawing.Size(289, 27);
            txtManufacturer.TabIndex = 5;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(447, 52);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(41, 20);
            lbPrice.TabIndex = 6;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new System.Drawing.Point(447, 111);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new System.Drawing.Size(101, 20);
            lbReleaseYear.TabIndex = 7;
            lbReleaseYear.Text = "Released Year";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(575, 57);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(213, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(575, 110);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(213, 27);
            txtReleaseYear.TabIndex = 9;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(150, 204);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(108, 29);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += button1_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(394, 204);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(125, 29);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(640, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(118, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new System.Drawing.Point(12, 255);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new System.Drawing.Size(776, 142);
            dgvCarList.TabIndex = 13;
            dgvCarList.CellContentClick += dgvCarList_CellContentClick;
            dgvCarList.CellDoubleClick += dgvCarList_CellDoubleClick;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(425, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Button btnClose;
    }
}