using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using System.Text.RegularExpressions;

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
            try
            {
                Product product = new Product
                {
                    name = name.Text,
                    price = Double.Parse(price.Text)
                };
                DbAccessor accessor = DbAccessor.Instance;
                accessor.CreateProduct(product);
                MessageBox.Show("插入成功");
            }
            catch (FormatException)
            {
                MessageBox.Show("输入的字段格式有误");
            }
        }

    }
}
