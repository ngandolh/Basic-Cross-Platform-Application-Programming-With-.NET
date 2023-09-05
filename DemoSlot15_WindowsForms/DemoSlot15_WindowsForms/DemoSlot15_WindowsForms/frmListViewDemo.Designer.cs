
namespace DemoSlot15_WindowsForms
{
    partial class frmListViewDemo
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
            lvData = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rdDetails = new System.Windows.Forms.RadioButton();
            rdLargeIcon = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            txtID = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lvData
            // 
            lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvData.Dock = System.Windows.Forms.DockStyle.Bottom;
            lvData.HideSelection = false;
            lvData.Location = new System.Drawing.Point(0, 175);
            lvData.Margin = new System.Windows.Forms.Padding(2);
            lvData.Name = "lvData";
            lvData.Size = new System.Drawing.Size(586, 164);
            lvData.TabIndex = 0;
            lvData.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Address";
            columnHeader3.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdDetails);
            groupBox1.Controls.Add(rdLargeIcon);
            groupBox1.Location = new System.Drawing.Point(412, 10);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(165, 95);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "View Option";
            // 
            // rdDetails
            // 
            rdDetails.AutoSize = true;
            rdDetails.Location = new System.Drawing.Point(38, 60);
            rdDetails.Margin = new System.Windows.Forms.Padding(2);
            rdDetails.Name = "rdDetails";
            rdDetails.Size = new System.Drawing.Size(76, 24);
            rdDetails.TabIndex = 0;
            rdDetails.Text = "Details";
            rdDetails.UseVisualStyleBackColor = true;
            rdDetails.CheckedChanged += rdDetails_CheckedChanged;
            // 
            // rdLargeIcon
            // 
            rdLargeIcon.AutoSize = true;
            rdLargeIcon.Checked = true;
            rdLargeIcon.Location = new System.Drawing.Point(38, 32);
            rdLargeIcon.Margin = new System.Windows.Forms.Padding(2);
            rdLargeIcon.Name = "rdLargeIcon";
            rdLargeIcon.Size = new System.Drawing.Size(99, 24);
            rdLargeIcon.TabIndex = 0;
            rdLargeIcon.TabStop = true;
            rdLargeIcon.Text = "Large Icon";
            rdLargeIcon.UseVisualStyleBackColor = true;
            rdLargeIcon.CheckedChanged += rdLargeIcon_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Location = new System.Drawing.Point(10, 10);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(398, 151);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Employee Information";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.66368F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.33633F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtAddress, 1, 2);
            tableLayoutPanel1.Controls.Add(txtID, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtName, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(18, 24);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            tableLayoutPanel1.Size = new System.Drawing.Size(357, 120);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(2, 0);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtAddress
            // 
            txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            txtAddress.Location = new System.Drawing.Point(90, 62);
            txtAddress.Margin = new System.Windows.Forms.Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(265, 27);
            txtAddress.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            txtID.Location = new System.Drawing.Point(90, 2);
            txtID.Margin = new System.Windows.Forms.Padding(2);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(265, 27);
            txtID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(2, 60);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // txtName
            // 
            txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            txtName.Location = new System.Drawing.Point(90, 32);
            txtName.Margin = new System.Windows.Forms.Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(265, 27);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(2, 30);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(412, 110);
            btnAdd.Margin = new System.Windows.Forms.Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(165, 51);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmListViewDemo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(586, 339);
            Controls.Add(groupBox2);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(lvData);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "frmListViewDemo";
            Text = "frmListViewDemo";
            Load += frmListViewDemo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDetails;
        private System.Windows.Forms.RadioButton rdLargeIcon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}