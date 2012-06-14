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
using NHibernate.Exceptions;
namespace SalesSystem
{
    public partial class ProductsForm : Form
    {
        DbAccessor accessor = DbAccessor.Instance;
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
            try
            {
                Product product = accessor.GetProductByName(this.listBox1.SelectedItem.ToString());
                accessor.DeleteProduct(product);
                listBox1.Items.Remove(this.listBox1.SelectedItem);
                MessageBox.Show("删除成功");
                name.Text = "";
                price.Text = "";
                stock.Text = "";
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("还没选中商品");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = accessor.GetProductByName(this.listBox1.SelectedItem.ToString());
                name.Text = product.name;
                price.Text = product.price.ToString();
                stock.Text = product.stock.ToString();
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("还没选择商品");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text == "")
                    throw new FormatException();
                Product product = accessor.GetProductByName(this.listBox1.SelectedItem.ToString());
                product.name = name.Text;
                product.price = Double.Parse(price.Text);
                product.stock = Int32.Parse(stock.Text);
                accessor.UpdateProduct(product);
                listBox1.Items.Clear();
                AddDataToListBox();
                MessageBox.Show("更新成功");
            }
            catch (FormatException)
            {
                MessageBox.Show("输入的字段格式有误");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("还未选择商品");
            }
            catch (GenericADOException)
            {
                MessageBox.Show("存在同名商品");
            }
        }




   

     
    }
}
