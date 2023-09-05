
namespace DemoSlot15_WindowsForms
{
    partial class frmTreeViewDemo
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
            this.tvData = new System.Windows.Forms.TreeView();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvData
            // 
            this.tvData.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvData.Location = new System.Drawing.Point(0, 0);
            this.tvData.Name = "tvData";
            this.tvData.Size = new System.Drawing.Size(272, 339);
            this.tvData.TabIndex = 0;
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(513, 138);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(112, 34);
            this.btnAddNode.TabIndex = 1;
            this.btnAddNode.Text = "Add Node";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // txtNodeName
            // 
            this.txtNodeName.Location = new System.Drawing.Point(357, 138);
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(150, 31);
            this.txtNodeName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // frmTreeViewDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNodeName);
            this.Controls.Add(this.btnAddNode);
            this.Controls.Add(this.tvData);
            this.Name = "frmTreeViewDemo";
            this.Text = "Tree View Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvData;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.TextBox txtNodeName;
        private System.Windows.Forms.Label label1;
    }
}

