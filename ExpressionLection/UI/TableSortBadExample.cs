using ExpressionLection.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ExpressionLection.UI
{
    public partial class TableSortBadExample : Form
    {
        public TableSortBadExample()
        {
            InitializeComponent();
            InitializeGrid(); 
        }
        private void InitializeGrid()
        {
            productBindingSource.DataSource = Product.GetProduct();
            GridProduct.ColumnHeaderMouseClick += GridProduct_ColumnHeaderMouseClick;
        }

        private void GridProduct_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             List<Product> products = productBindingSource.DataSource as List<Product>;
             string name = GridProduct.Columns[e.ColumnIndex].DataPropertyName;
             if(name == "Name")
                 products = products.OrderBy(n=>n.Name).ToList();
             if (name == "Company")
                 products = products.OrderBy(n => n.Company).ToList();;
             productBindingSource.DataSource = products;
        }

    }
}
