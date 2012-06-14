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
            try
            {
                Product product = accessor.GetProductByName(productListBox.SelectedItem.ToString());

                if (product.stock == 0)
                {
                    MessageBox.Show("该商品没有库存");
                    return;
                }
                if (product.stock - Int32.Parse(quantity.Text) < 0)
                    MessageBox.Show("库存不足，只能销售" + product.stock + "件商品");
                SaleList sale = new SaleList
                {
                    product_id = product.id,
                    sale_quantity = Int32.Parse(quantity.Text),
                    sale_price = product.price,
                    purchase_price = product.purchase_price
                };
                accessor.CreateSaleList(sale);
                MessageBox.Show("添加成功");
            }
            catch (FormatException)
            {
                MessageBox.Show("输入的字段格式有误");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("还没选择对象");
            }
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
