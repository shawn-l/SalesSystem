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
using NHibernate.Exceptions;
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
                if (name.Text == "")
                    throw new FormatException();
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
            catch (GenericADOException)
            {
                MessageBox.Show("存在同名商品，不能插入");
            }
        }

    }
}
