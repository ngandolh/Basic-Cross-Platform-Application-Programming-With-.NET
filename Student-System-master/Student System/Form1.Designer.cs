namespace Student_System
{
    partial class Form1
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
            this.Add_Button = new System.Windows.Forms.Button();
            this.Display_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.SearchName_Button = new System.Windows.Forms.Button();
            this.SearchID_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.Phone_Box = new System.Windows.Forms.TextBox();
            this.Address_Box = new System.Windows.Forms.TextBox();
            this.Job_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.Display_list = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Add_Button.Location = new System.Drawing.Point(517, 21);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(157, 52);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "Add Student";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Display_Button
            // 
            this.Display_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Display_Button.Location = new System.Drawing.Point(517, 81);
            this.Display_Button.Name = "Display_Button";
            this.Display_Button.Size = new System.Drawing.Size(157, 52);
            this.Display_Button.TabIndex = 1;
            this.Display_Button.Text = "Display List";
            this.Display_Button.UseVisualStyleBackColor = false;
            this.Display_Button.Click += new System.EventHandler(this.Display_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Save_Button.Location = new System.Drawing.Point(517, 139);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(157, 52);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Save list to file ";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // SearchName_Button
            // 
            this.SearchName_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SearchName_Button.Location = new System.Drawing.Point(517, 264);
            this.SearchName_Button.Name = "SearchName_Button";
            this.SearchName_Button.Size = new System.Drawing.Size(157, 52);
            this.SearchName_Button.TabIndex = 3;
            this.SearchName_Button.Text = "Search by name";
            this.SearchName_Button.UseVisualStyleBackColor = false;
            this.SearchName_Button.Click += new System.EventHandler(this.SearchName_Button_Click);
            // 
            // SearchID_Button
            // 
            this.SearchID_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SearchID_Button.Location = new System.Drawing.Point(517, 337);
            this.SearchID_Button.Name = "SearchID_Button";
            this.SearchID_Button.Size = new System.Drawing.Size(157, 52);
            this.SearchID_Button.TabIndex = 4;
            this.SearchID_Button.Text = "Search by ID ";
            this.SearchID_Button.UseVisualStyleBackColor = false;
            this.SearchID_Button.Click += new System.EventHandler(this.SearchID_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Clear_Button.Location = new System.Drawing.Point(517, 410);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(157, 52);
            this.Clear_Button.TabIndex = 5;
            this.Clear_Button.Text = "Clear list";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Exit_Button.Location = new System.Drawing.Point(517, 485);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(157, 52);
            this.Exit_Button.TabIndex = 6;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(69, 21);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(162, 20);
            this.Name_Box.TabIndex = 10;
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(69, 63);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(162, 20);
            this.ID_Box.TabIndex = 11;
            // 
            // Phone_Box
            // 
            this.Phone_Box.Location = new System.Drawing.Point(69, 103);
            this.Phone_Box.Name = "Phone_Box";
            this.Phone_Box.Size = new System.Drawing.Size(162, 20);
            this.Phone_Box.TabIndex = 12;
            // 
            // Address_Box
            // 
            this.Address_Box.Location = new System.Drawing.Point(327, 28);
            this.Address_Box.Name = "Address_Box";
            this.Address_Box.Size = new System.Drawing.Size(162, 20);
            this.Address_Box.TabIndex = 13;
            this.Address_Box.TextChanged += new System.EventHandler(this.Address_Box_TextChanged);
            // 
            // Job_Box
            // 
            this.Job_Box.Location = new System.Drawing.Point(327, 78);
            this.Job_Box.Name = "Job_Box";
            this.Job_Box.Size = new System.Drawing.Size(162, 20);
            this.Job_Box.TabIndex = 14;
            this.Job_Box.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Job";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Phone";
            // 
            // Remove_Button
            // 
            this.Remove_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Remove_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Remove_Button.Location = new System.Drawing.Point(517, 197);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(157, 52);
            this.Remove_Button.TabIndex = 18;
            this.Remove_Button.Text = "Remove Student";
            this.Remove_Button.UseVisualStyleBackColor = false;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // Display_list
            // 
            this.Display_list.Location = new System.Drawing.Point(15, 153);
            this.Display_list.Name = "Display_list";
            this.Display_list.Size = new System.Drawing.Size(474, 384);
            this.Display_list.TabIndex = 19;
            this.Display_list.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(734, 549);
            this.Controls.Add(this.Display_list);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Job_Box);
            this.Controls.Add(this.Address_Box);
            this.Controls.Add(this.Phone_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.SearchID_Button);
            this.Controls.Add(this.SearchName_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Display_Button);
            this.Controls.Add(this.Add_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Display_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button SearchName_Button;
        private System.Windows.Forms.Button SearchID_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.TextBox Phone_Box;
        private System.Windows.Forms.TextBox Address_Box;
        private System.Windows.Forms.TextBox Job_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.RichTextBox Display_list;
    }
}

