namespace DemoWinForm
{
    partial class Form1
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
            BtnName = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            Next = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            listDegree = new System.Windows.Forms.ListBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // BtnName
            // 
            BtnName.AutoSize = true;
            BtnName.Location = new System.Drawing.Point(100, 114);
            BtnName.Name = "BtnName";
            BtnName.Size = new System.Drawing.Size(163, 20);
            BtnName.TabIndex = 0;
            BtnName.Text = "Please enter your name";
            BtnName.Click += BtnName_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(286, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(435, 117);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnName_Click;
            // 
            // Next
            // 
            Next.Location = new System.Drawing.Point(694, 409);
            Next.Name = "Next";
            Next.Size = new System.Drawing.Size(94, 29);
            Next.TabIndex = 6;
            Next.Text = "Next";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(286, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(286, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(286, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(125, 27);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // listDegree
            // 
            listDegree.FormattingEnabled = true;
            listDegree.ItemHeight = 20;
            listDegree.Items.AddRange(new object[] { "BSc", "Ms", "PhD" });
            listDegree.Location = new System.Drawing.Point(584, 12);
            listDegree.Name = "listDegree";
            listDegree.Size = new System.Drawing.Size(150, 104);
            listDegree.TabIndex = 7;
            listDegree.SelectedIndexChanged += listDegree_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "BSc", "Ms", "PhD" });
            comboBox2.Location = new System.Drawing.Point(583, 138);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(151, 28);
            comboBox2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(listDegree);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(Next);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(BtnName);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label BtnName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox listDegree;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
