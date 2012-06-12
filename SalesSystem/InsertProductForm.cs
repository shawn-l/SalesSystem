using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;

namespace SalesSystem
{
    public partial class InsertProductForm : Form
    {
        public InsertProductForm()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                id = Int32.Parse(insertId.Text),
                name = insertName.Text,
                price = Double.Parse(insertPrice.Text),
                stock = Int32.Parse(insertQuantity.Text)
            };
            DbAccessor accessor = DbAccessor.Instance;
            accessor.CreateProduct(product);
        }

        private void search_Click(object sender, EventArgs e)
        {
            int search_id = Int32.Parse(searchId.Text);
            DbAccessor accessor = DbAccessor.Instance;
            Product product = accessor.GetProductById(search_id);
            displayId.Text = product.id.ToString();
            displayName.Text = product.name.ToString();
            displayPrice.Text = product.price.ToString();
            displayQuantity.Text = product.stock.ToString();
        }

   
   
    }
}
