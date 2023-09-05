namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            txtCarID = new System.Windows.Forms.TextBox();
            lbCarID = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            lbManufacturer = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            lbReleaseYear = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtCarName = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.MaskedTextBox();
            txtReleaseYear = new System.Windows.Forms.MaskedTextBox();
            cboManufacturer = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(255, 88);
            txtCarID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(290, 27);
            txtCarID.TabIndex = 0;
            txtCarID.TextChanged += textBox1_TextChanged;
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCarID.Location = new System.Drawing.Point(62, 88);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(53, 20);
            lbCarID.TabIndex = 4;
            lbCarID.Text = "CarID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCarName.Location = new System.Drawing.Point(62, 141);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(80, 20);
            lbCarName.TabIndex = 5;
            lbCarName.Text = "CarName";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbManufacturer.Location = new System.Drawing.Point(62, 208);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(108, 20);
            lbManufacturer.TabIndex = 6;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPrice.Location = new System.Drawing.Point(62, 259);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(48, 20);
            lbPrice.TabIndex = 7;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbReleaseYear.Location = new System.Drawing.Point(67, 318);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new System.Drawing.Size(118, 20);
            lbReleaseYear.TabIndex = 8;
            lbReleaseYear.Text = "Released Year";
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(255, 371);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(104, 44);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(440, 369);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(104, 49);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(255, 141);
            txtCarName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(290, 27);
            txtCarName.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(254, 256);
            txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(290, 27);
            txtPrice.TabIndex = 15;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(254, 304);
            txtReleaseYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtReleaseYear.Mask = "000000000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(290, 27);
            txtReleaseYear.TabIndex = 16;
            txtReleaseYear.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new System.Drawing.Point(255, 194);
            cboManufacturer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new System.Drawing.Size(289, 28);
            cboManufacturer.TabIndex = 17;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(592, 562);
            Controls.Add(cboManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Controls.Add(txtCarID);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmCarDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtReleaseYear;
        private System.Windows.Forms.ComboBox cboManufacturer;
    }
}