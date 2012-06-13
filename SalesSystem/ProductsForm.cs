using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using System.Collections;
namespace SalesSystem
{
    public partial class ProductsForm : Form
    {
        DbAccessor accessor = DbAccessor.Instance;
        Product product;
        ArrayList product_names = new ArrayList();
        public ProductsForm()
        {
            InitializeComponent();
        }

        
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            AddDataToListBox();
        }

        private void AddDataToListBox()
        {
            foreach (Product product in accessor.GetAllProduct())
            {
                listBox1.Items.Add(product.name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accessor.DeleteProduct(product);
            listBox1.Items.Remove(this.listBox1.SelectedItem);
            MessageBox.Show("删除成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product = accessor.GetProductByName(this.listBox1.SelectedItem.ToString());
            name.Text = product.name;
            price.Text = product.price.ToString();
            stock.Text = product.stock.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            product.name = name.Text;
            product.price = Double.Parse(price.Text);
            product.stock = Int32.Parse(stock.Text);
            accessor.UpdateProduct(product);
            listBox1.Items.Clear();
            AddDataToListBox();
            MessageBox.Show("更新成功");
        }



   

     
    }
}
