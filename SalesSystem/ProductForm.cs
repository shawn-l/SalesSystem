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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Int32.Parse(insertId.Text),
                Name = insertName.Text,
                Price = Double.Parse(insertPrice.Text),
                Quantity = Int32.Parse(insertQuantity.Text)
            };
            DbAccessor accessor = DbAccessor.Instance;
            accessor.CreateProduct(product);
        }

        private void search_Click(object sender, EventArgs e)
        {
            int search_id = Int32.Parse(searchId.Text);
            DbAccessor accessor = DbAccessor.Instance;
            Product product = accessor.GetProductById(search_id);
            displayId.Text = product.Id.ToString();
            displayName.Text = product.Name.ToString();
            displayPrice.Text = product.Price.ToString();
            displayQuantity.Text = product.Quantity.ToString();
        }

  
   
    }
}
