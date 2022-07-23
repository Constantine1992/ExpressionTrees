namespace ExpressionLection
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FirstExample = new System.Windows.Forms.ToolStripMenuItem();
            this.dddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildExpression = new System.Windows.Forms.ToolStripMenuItem();
            this.Sorting = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FirstExample});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1008, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // FirstExample
            // 
            this.FirstExample.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dddToolStripMenuItem,
            this.BuildExpression,
            this.Sorting,
            this.сортировкаToolStripMenuItem});
            this.FirstExample.Name = "FirstExample";
            this.FirstExample.Size = new System.Drawing.Size(73, 20);
            this.FirstExample.Text = "Примеры";
            this.FirstExample.Click += new System.EventHandler(this.FirstExample_Click);
            // 
            // dddToolStripMenuItem
            // 
            this.dddToolStripMenuItem.Name = "dddToolStripMenuItem";
            this.dddToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.dddToolStripMenuItem.Text = "Простой пример дерева выражений";
            // 
            // BuildExpression
            // 
            this.BuildExpression.Name = "BuildExpression";
            this.BuildExpression.Size = new System.Drawing.Size(275, 22);
            this.BuildExpression.Text = "Построение дерева выражений";
            this.BuildExpression.Click += new System.EventHandler(this.BuildExpression_Click);
            // 
            // Sorting
            // 
            this.Sorting.Name = "Sorting";
            this.Sorting.Size = new System.Drawing.Size(275, 22);
            this.Sorting.Text = "Сортировка Плохой пример";
            this.Sorting.Click += new System.EventHandler(this.Sorting_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            this.сортировкаToolStripMenuItem.Click += new System.EventHandler(this.сортировкаToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 59);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Примеры для демонстрации";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FirstExample;
        private System.Windows.Forms.ToolStripMenuItem BuildExpression;
        private System.Windows.Forms.ToolStripMenuItem dddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sorting;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
    }
}

