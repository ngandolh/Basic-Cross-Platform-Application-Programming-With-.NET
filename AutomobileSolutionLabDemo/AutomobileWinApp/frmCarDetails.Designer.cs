
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.cboManufacturer = new System.Windows.Forms.ComboBox();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbReleaseYear = new System.Windows.Forms.Label();
            this.lbCarID = new System.Windows.Forms.Label();
            this.lbCarName = new System.Windows.Forms.Label();
            this.txtReleaseYear = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(164, 300);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 36);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(336, 300);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 36);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(164, 189);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Mask = "000000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(289, 31);
            this.txtPrice.TabIndex = 42;
            this.txtPrice.Text = "0";
            // 
            // cboManufacturer
            // 
            this.cboManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManufacturer.FormattingEnabled = true;
            this.cboManufacturer.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Chevrolet",
            "Ford",
            "Honda",
            "Hyundai",
            "Isuzu",
            "Kia",
            "Suzuki",
            "Toyota"});
            this.cboManufacturer.Location = new System.Drawing.Point(164, 136);
            this.cboManufacturer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboManufacturer.Name = "cboManufacturer";
            this.cboManufacturer.Size = new System.Drawing.Size(289, 33);
            this.cboManufacturer.Sorted = true;
            this.cboManufacturer.TabIndex = 41;
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(164, 39);
            this.txtCarID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(289, 31);
            this.txtCarID.TabIndex = 37;
            //this.txtCarID.TextChanged += new System.EventHandler(this.txtCarID_TextChanged);
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(164, 88);
            this.txtCarName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(289, 31);
            this.txtCarName.TabIndex = 39;
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(38, 142);
            this.lbManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(117, 25);
            this.lbManufacturer.TabIndex = 31;
            this.lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(35, 192);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(49, 25);
            this.lbPrice.TabIndex = 34;
            this.lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            this.lbReleaseYear.AutoSize = true;
            this.lbReleaseYear.Location = new System.Drawing.Point(35, 241);
            this.lbReleaseYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReleaseYear.Name = "lbReleaseYear";
            this.lbReleaseYear.Size = new System.Drawing.Size(118, 25);
            this.lbReleaseYear.TabIndex = 35;
            this.lbReleaseYear.Text = "Released Year";
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(38, 45);
            this.lbCarID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(61, 25);
            this.lbCarID.TabIndex = 32;
            this.lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(38, 94);
            this.lbCarName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(90, 25);
            this.lbCarName.TabIndex = 36;
            this.lbCarName.Text = "Car Name";
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(164, 238);
            this.txtReleaseYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReleaseYear.Mask = "0000";
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(289, 31);
            this.txtReleaseYear.TabIndex = 42;
            this.txtReleaseYear.Text = "0";
            // 
            // frmCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 355);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cboManufacturer);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbReleaseYear);
            this.Controls.Add(this.lbCarID);
            this.Controls.Add(this.lbCarName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCarDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarDetails";
            this.Load += new System.EventHandler(this.frmCarDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.MaskedTextBox txtReleaseYear;
    }
}