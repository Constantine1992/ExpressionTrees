using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;
using ExpressionLection.UI;

namespace ExpressionLection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string GetFolder( string nameProject)
        { 
            string path = string.Empty;
            path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\ExpressionLection\\bin\\Debug\\", "");
            path = Path.Combine(path,nameProject,"bin","Debug",nameProject+".exe");
            return path;
        }
        private void Start(string path)
        {
            ProcessStartInfo pi = new ProcessStartInfo(path);
            Process.Start(pi);
        }

        private void BuildExpression_Click(object sender, EventArgs e)
        {
            string path = GetFolder("BuildExpression");
            Start(path);

        }

        private void FirstExample_Click(object sender, EventArgs e)
        {

        }

        private void Sorting_Click(object sender, EventArgs e)
        {
            TableSortBadExample form = new TableSortBadExample();
            form.Show();
        }

        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortTableOwner form = new SortTableOwner();
            form.Show();
        }
    }

}
