using ExpressionLection.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressionLection.UI
{
    public partial class SortTableOwner : Form
    {
        public SortTableOwner()
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
            #region сортировка Enumerable
            List<Product> products = productBindingSource.DataSource as List<Product>;
            string name = GridProduct.Columns[e.ColumnIndex].DataPropertyName;
            products = products.OrderBy(name).ToList();
            productBindingSource.DataSource = products;

#endregion

#region сортировка IQueryable 
           /* IQueryable<Product> products = ((IEnumerable<Product>)productBindingSource.DataSource).AsQueryable();
            string name = GridProduct.Columns[e.ColumnIndex].DataPropertyName;
            products = products.OrderBy(name);
            productBindingSource.DataSource = products;*/
#endregion
        }
    }
}
