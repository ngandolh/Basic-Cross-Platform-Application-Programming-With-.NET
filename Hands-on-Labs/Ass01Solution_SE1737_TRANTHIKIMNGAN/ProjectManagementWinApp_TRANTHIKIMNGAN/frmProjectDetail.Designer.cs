namespace ProjectManagementWinApp_TRANTHIKIMNGAN
{
    partial class frmProjectDetail
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
            lbProjectID = new System.Windows.Forms.Label();
            lbProjectName = new System.Windows.Forms.Label();
            lbProjectAddress = new System.Windows.Forms.Label();
            lbProjectCity = new System.Windows.Forms.Label();
            lbProjectDescription = new System.Windows.Forms.Label();
            lbEstimatedStartDate = new System.Windows.Forms.Label();
            lbEstimatedEndDate = new System.Windows.Forms.Label();
            txtProjectID = new System.Windows.Forms.TextBox();
            txtProjectName = new System.Windows.Forms.TextBox();
            txtProjectAddress = new System.Windows.Forms.TextBox();
            txtProjectCity = new System.Windows.Forms.TextBox();
            txtProjectDescription = new System.Windows.Forms.TextBox();
            dtEstimatedStartDate = new System.Windows.Forms.DateTimePicker();
            dtEstimatedEndDate = new System.Windows.Forms.DateTimePicker();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbProjectID
            // 
            lbProjectID.AutoSize = true;
            lbProjectID.Location = new System.Drawing.Point(55, 45);
            lbProjectID.Name = "lbProjectID";
            lbProjectID.Size = new System.Drawing.Size(70, 20);
            lbProjectID.TabIndex = 0;
            lbProjectID.Text = "ProjectID";
            // 
            // lbProjectName
            // 
            lbProjectName.AutoSize = true;
            lbProjectName.Location = new System.Drawing.Point(53, 91);
            lbProjectName.Name = "lbProjectName";
            lbProjectName.Size = new System.Drawing.Size(95, 20);
            lbProjectName.TabIndex = 1;
            lbProjectName.Text = "ProjectName";
            // 
            // lbProjectAddress
            // 
            lbProjectAddress.AutoSize = true;
            lbProjectAddress.Location = new System.Drawing.Point(53, 135);
            lbProjectAddress.Name = "lbProjectAddress";
            lbProjectAddress.Size = new System.Drawing.Size(108, 20);
            lbProjectAddress.TabIndex = 2;
            lbProjectAddress.Text = "ProjectAddress";
            // 
            // lbProjectCity
            // 
            lbProjectCity.AutoSize = true;
            lbProjectCity.Location = new System.Drawing.Point(377, 115);
            lbProjectCity.Name = "lbProjectCity";
            lbProjectCity.Size = new System.Drawing.Size(80, 20);
            lbProjectCity.TabIndex = 3;
            lbProjectCity.Text = "ProjectCity";
            // 
            // lbProjectDescription
            // 
            lbProjectDescription.AutoSize = true;
            lbProjectDescription.Location = new System.Drawing.Point(363, 162);
            lbProjectDescription.Name = "lbProjectDescription";
            lbProjectDescription.Size = new System.Drawing.Size(131, 20);
            lbProjectDescription.TabIndex = 4;
            lbProjectDescription.Text = "ProjectDescription";
            // 
            // lbEstimatedStartDate
            // 
            lbEstimatedStartDate.AutoSize = true;
            lbEstimatedStartDate.Location = new System.Drawing.Point(356, 35);
            lbEstimatedStartDate.Name = "lbEstimatedStartDate";
            lbEstimatedStartDate.Size = new System.Drawing.Size(138, 20);
            lbEstimatedStartDate.TabIndex = 5;
            lbEstimatedStartDate.Text = "EstimatedStartDate";
            // 
            // lbEstimatedEndDate
            // 
            lbEstimatedEndDate.AutoSize = true;
            lbEstimatedEndDate.Location = new System.Drawing.Point(360, 72);
            lbEstimatedEndDate.Name = "lbEstimatedEndDate";
            lbEstimatedEndDate.Size = new System.Drawing.Size(132, 20);
            lbEstimatedEndDate.TabIndex = 6;
            lbEstimatedEndDate.Text = "EstimatedEndDate";
            // 
            // txtProjectID
            // 
            txtProjectID.Location = new System.Drawing.Point(167, 43);
            txtProjectID.Name = "txtProjectID";
            txtProjectID.Size = new System.Drawing.Size(125, 27);
            txtProjectID.TabIndex = 7;
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new System.Drawing.Point(168, 86);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new System.Drawing.Size(125, 27);
            txtProjectName.TabIndex = 8;
            // 
            // txtProjectAddress
            // 
            txtProjectAddress.Location = new System.Drawing.Point(181, 138);
            txtProjectAddress.Name = "txtProjectAddress";
            txtProjectAddress.Size = new System.Drawing.Size(125, 27);
            txtProjectAddress.TabIndex = 9;
            // 
            // txtProjectCity
            // 
            txtProjectCity.Location = new System.Drawing.Point(529, 112);
            txtProjectCity.Name = "txtProjectCity";
            txtProjectCity.Size = new System.Drawing.Size(125, 27);
            txtProjectCity.TabIndex = 10;
            // 
            // txtProjectDescription
            // 
            txtProjectDescription.Location = new System.Drawing.Point(529, 162);
            txtProjectDescription.Name = "txtProjectDescription";
            txtProjectDescription.Size = new System.Drawing.Size(125, 27);
            txtProjectDescription.TabIndex = 11;
            // 
            // dtEstimatedStartDate
            // 
            dtEstimatedStartDate.Location = new System.Drawing.Point(529, 36);
            dtEstimatedStartDate.Name = "dtEstimatedStartDate";
            dtEstimatedStartDate.Size = new System.Drawing.Size(250, 27);
            dtEstimatedStartDate.TabIndex = 12;
            // 
            // dtEstimatedEndDate
            // 
            dtEstimatedEndDate.Location = new System.Drawing.Point(529, 72);
            dtEstimatedEndDate.Name = "dtEstimatedEndDate";
            dtEstimatedEndDate.Size = new System.Drawing.Size(250, 27);
            dtEstimatedEndDate.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(242, 216);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(444, 225);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmProjectDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(810, 298);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtEstimatedEndDate);
            Controls.Add(dtEstimatedStartDate);
            Controls.Add(txtProjectDescription);
            Controls.Add(txtProjectCity);
            Controls.Add(txtProjectAddress);
            Controls.Add(txtProjectName);
            Controls.Add(txtProjectID);
            Controls.Add(lbEstimatedEndDate);
            Controls.Add(lbEstimatedStartDate);
            Controls.Add(lbProjectDescription);
            Controls.Add(lbProjectCity);
            Controls.Add(lbProjectAddress);
            Controls.Add(lbProjectName);
            Controls.Add(lbProjectID);
            Name = "frmProjectDetail";
            Text = "frmProjectDetail";
            Load += frmProjectDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbProjectID;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.Label lbProjectAddress;
        private System.Windows.Forms.Label lbProjectCity;
        private System.Windows.Forms.Label lbProjectDescription;
        private System.Windows.Forms.Label lbEstimatedStartDate;
        private System.Windows.Forms.Label lbEstimatedEndDate;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectAddress;
        private System.Windows.Forms.TextBox txtProjectCity;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.DateTimePicker dtEstimatedStartDate;
        private System.Windows.Forms.DateTimePicker dtEstimatedEndDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}