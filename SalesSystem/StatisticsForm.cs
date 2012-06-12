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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DbAccessor accessor = DbAccessor.Instance;
                Product product = accessor.GetProductById(Int32.Parse(search.Text));
                if (product == null)
                    MessageBox.Show("没有此Id", "错误", MessageBoxButtons.OK);
                else
                {
                    name.Text = product.name;
                    price.Text = product.price.ToString();
                    stock.Text = product.stock.ToString();
                    sale_quantity.Text = product.sale_quantity.ToString();
                    amount.Text = product.amount.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("输入错误Id", "错误", MessageBoxButtons.OK);
            }
        }

     
    }
}
