using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Models;
namespace SalesSystem
{
    public partial class SaleForm : Form
    {
        DbAccessor accessor = DbAccessor.Instance;
        public SaleForm()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
           
            Product product = accessor.GetProductByName(productListBox.SelectedItem.ToString());
            SaleList sale = new SaleList
            {
                product_id = product.id,
                sale_quantity = Int32.Parse(quantity.Text),
                sale_price = product.price
            };
            accessor.CreateSaleList(sale);
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            ArrayList productNames = new ArrayList();
            foreach (Product product in accessor.GetAllProduct())
                productNames.Add(product.name);
            productListBox.DataSource = productNames;
        }
    }
}
