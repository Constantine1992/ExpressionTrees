namespace SortTables
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
            this.textBox_Me = new System.Windows.Forms.TextBox();
            this.textBox_ForMe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Rec_Count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Me
            // 
            this.textBox_Me.Location = new System.Drawing.Point(213, 72);
            this.textBox_Me.Name = "textBox_Me";
            this.textBox_Me.Size = new System.Drawing.Size(122, 20);
            this.textBox_Me.TabIndex = 0;
            // 
            // textBox_ForMe
            // 
            this.textBox_ForMe.Location = new System.Drawing.Point(213, 98);
            this.textBox_ForMe.Name = "textBox_ForMe";
            this.textBox_ForMe.Size = new System.Drawing.Size(122, 20);
            this.textBox_ForMe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "me";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "forMe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Rec_Count
            // 
            this.textBox_Rec_Count.Location = new System.Drawing.Point(213, 28);
            this.textBox_Rec_Count.Name = "textBox_Rec_Count";
            this.textBox_Rec_Count.Size = new System.Drawing.Size(122, 20);
            this.textBox_Rec_Count.TabIndex = 5;
            this.textBox_Rec_Count.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 262);
            this.Controls.Add(this.textBox_Rec_Count);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ForMe);
            this.Controls.Add(this.textBox_Me);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Me;
        private System.Windows.Forms.TextBox textBox_ForMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Rec_Count;
    }
}

