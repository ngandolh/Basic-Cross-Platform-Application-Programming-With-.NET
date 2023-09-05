namespace ProjectManagementWinApp_TRANTHIKIMNGAN
{
    partial class frmProjectManagement
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
            lbProjectID = new System.Windows.Forms.Label();
            lbProjectName = new System.Windows.Forms.Label();
            lbEstimatedStartDate = new System.Windows.Forms.Label();
            lbEstimatedEndDate = new System.Windows.Forms.Label();
            lbProjectDescription = new System.Windows.Forms.Label();
            lbProjectAddress = new System.Windows.Forms.Label();
            lbProjectCity = new System.Windows.Forms.Label();
            txtProjectID = new System.Windows.Forms.TextBox();
            txtProjectName = new System.Windows.Forms.TextBox();
            txtProjectDescription = new System.Windows.Forms.TextBox();
            txtProjectAddress = new System.Windows.Forms.TextBox();
            txtProjectCity = new System.Windows.Forms.TextBox();
            txtEstimatedStartDate = new System.Windows.Forms.MaskedTextBox();
            txtEstimatedEndDate = new System.Windows.Forms.MaskedTextBox();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dgvProjectList = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvProjectList).BeginInit();
            SuspendLayout();
            // 
            // lbProjectID
            // 
            lbProjectID.AutoSize = true;
            lbProjectID.Location = new System.Drawing.Point(38, 34);
            lbProjectID.Name = "lbProjectID";
            lbProjectID.Size = new System.Drawing.Size(70, 20);
            lbProjectID.TabIndex = 0;
            lbProjectID.Text = "ProjectID";
            // 
            // lbProjectName
            // 
            lbProjectName.AutoSize = true;
            lbProjectName.Location = new System.Drawing.Point(40, 76);
            lbProjectName.Name = "lbProjectName";
            lbProjectName.Size = new System.Drawing.Size(101, 20);
            lbProjectName.TabIndex = 1;
            lbProjectName.Text = "ProjectNames";
            // 
            // lbEstimatedStartDate
            // 
            lbEstimatedStartDate.AutoSize = true;
            lbEstimatedStartDate.Location = new System.Drawing.Point(40, 126);
            lbEstimatedStartDate.Name = "lbEstimatedStartDate";
            lbEstimatedStartDate.Size = new System.Drawing.Size(138, 20);
            lbEstimatedStartDate.TabIndex = 2;
            lbEstimatedStartDate.Text = "EstimatedStartDate";
            // 
            // lbEstimatedEndDate
            // 
            lbEstimatedEndDate.AutoSize = true;
            lbEstimatedEndDate.Location = new System.Drawing.Point(439, 122);
            lbEstimatedEndDate.Name = "lbEstimatedEndDate";
            lbEstimatedEndDate.Size = new System.Drawing.Size(132, 20);
            lbEstimatedEndDate.TabIndex = 3;
            lbEstimatedEndDate.Text = "EstimatedEndDate";
            // 
            // lbProjectDescription
            // 
            lbProjectDescription.AutoSize = true;
            lbProjectDescription.Location = new System.Drawing.Point(38, 178);
            lbProjectDescription.Name = "lbProjectDescription";
            lbProjectDescription.Size = new System.Drawing.Size(131, 20);
            lbProjectDescription.TabIndex = 4;
            lbProjectDescription.Text = "ProjectDescription";
            // 
            // lbProjectAddress
            // 
            lbProjectAddress.AutoSize = true;
            lbProjectAddress.Location = new System.Drawing.Point(439, 34);
            lbProjectAddress.Name = "lbProjectAddress";
            lbProjectAddress.Size = new System.Drawing.Size(108, 20);
            lbProjectAddress.TabIndex = 5;
            lbProjectAddress.Text = "ProjectAddress";
            // 
            // lbProjectCity
            // 
            lbProjectCity.AutoSize = true;
            lbProjectCity.Location = new System.Drawing.Point(439, 83);
            lbProjectCity.Name = "lbProjectCity";
            lbProjectCity.Size = new System.Drawing.Size(80, 20);
            lbProjectCity.TabIndex = 6;
            lbProjectCity.Text = "ProjectCity";
            // 
            // txtProjectID
            // 
            txtProjectID.Location = new System.Drawing.Point(191, 31);
            txtProjectID.Name = "txtProjectID";
            txtProjectID.Size = new System.Drawing.Size(221, 27);
            txtProjectID.TabIndex = 7;
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new System.Drawing.Point(191, 76);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new System.Drawing.Size(221, 27);
            txtProjectName.TabIndex = 8;
            // 
            // txtProjectDescription
            // 
            txtProjectDescription.Location = new System.Drawing.Point(191, 178);
            txtProjectDescription.Name = "txtProjectDescription";
            txtProjectDescription.Size = new System.Drawing.Size(221, 27);
            txtProjectDescription.TabIndex = 9;
            // 
            // txtProjectAddress
            // 
            txtProjectAddress.Location = new System.Drawing.Point(588, 27);
            txtProjectAddress.Name = "txtProjectAddress";
            txtProjectAddress.Size = new System.Drawing.Size(173, 27);
            txtProjectAddress.TabIndex = 10;
            // 
            // txtProjectCity
            // 
            txtProjectCity.Location = new System.Drawing.Point(588, 73);
            txtProjectCity.Name = "txtProjectCity";
            txtProjectCity.Size = new System.Drawing.Size(173, 27);
            txtProjectCity.TabIndex = 11;
            // 
            // txtEstimatedStartDate
            // 
            txtEstimatedStartDate.Location = new System.Drawing.Point(191, 119);
            txtEstimatedStartDate.Mask = "00/00/0000";
            txtEstimatedStartDate.Name = "txtEstimatedStartDate";
            txtEstimatedStartDate.Size = new System.Drawing.Size(125, 27);
            txtEstimatedStartDate.TabIndex = 12;
            txtEstimatedStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtEstimatedEndDate
            // 
            txtEstimatedEndDate.Location = new System.Drawing.Point(588, 123);
            txtEstimatedEndDate.Mask = "00/00/0000";
            txtEstimatedEndDate.Name = "txtEstimatedEndDate";
            txtEstimatedEndDate.Size = new System.Drawing.Size(125, 27);
            txtEstimatedEndDate.TabIndex = 13;
            txtEstimatedEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(166, 211);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(367, 211);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(94, 29);
            btnNew.TabIndex = 15;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(619, 211);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvProjectList
            // 
            dgvProjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjectList.Location = new System.Drawing.Point(38, 246);
            dgvProjectList.Name = "dgvProjectList";
            dgvProjectList.ReadOnly = true;
            dgvProjectList.RowHeadersWidth = 51;
            dgvProjectList.RowTemplate.Height = 29;
            dgvProjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProjectList.Size = new System.Drawing.Size(723, 145);
            dgvProjectList.TabIndex = 17;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(367, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmProjectManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(dgvProjectList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtEstimatedEndDate);
            Controls.Add(txtEstimatedStartDate);
            Controls.Add(txtProjectCity);
            Controls.Add(txtProjectAddress);
            Controls.Add(txtProjectDescription);
            Controls.Add(txtProjectName);
            Controls.Add(txtProjectID);
            Controls.Add(lbProjectCity);
            Controls.Add(lbProjectAddress);
            Controls.Add(lbProjectDescription);
            Controls.Add(lbEstimatedEndDate);
            Controls.Add(lbEstimatedStartDate);
            Controls.Add(lbProjectName);
            Controls.Add(lbProjectID);
            Name = "frmProjectManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmProjectManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProjectList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbProjectID;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.Label lbEstimatedStartDate;
        private System.Windows.Forms.Label lbEstimatedEndDate;
        private System.Windows.Forms.Label lbProjectDescription;
        private System.Windows.Forms.Label lbProjectAddress;
        private System.Windows.Forms.Label lbProjectCity;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.TextBox txtProjectAddress;
        private System.Windows.Forms.TextBox txtProjectCity;
        private System.Windows.Forms.MaskedTextBox txtEstimatedStartDate;
        private System.Windows.Forms.MaskedTextBox txtEstimatedEndDate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvProjectList;
        private System.Windows.Forms.Button btnClose;
    }
}
