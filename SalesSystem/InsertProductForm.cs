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
                name = name.Text,
                price = Double.Parse(price.Text),
                stock = Int32.Parse(stock.Text)
            };
            DbAccessor accessor = DbAccessor.Instance;
            accessor.CreateProduct(product);
            MessageBox.Show("插入成功");
        }

  

     
   
   
    }
}
