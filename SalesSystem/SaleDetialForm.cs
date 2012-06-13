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
    public partial class SaleDetialForm : Form
    {
        DbAccessor accessor = DbAccessor.Instance;
        public SaleDetialForm()
        {
            InitializeComponent();
        }

        private void SaleDetialForm_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            int quantity = 0;
            double amount = 0.0;
            listView1.Columns.Clear();
            listView1.Items.Clear();
            this.listView1.GridLines = true;
            this.listView1.View = View.Details;
            this.listView1.Scrollable = true;
            listView1.Columns.Add("售价");
            listView1.Columns.Add("卖出数量");
            listView1.Columns.Add("总价");

            Product product= accessor.GetProductByName(this.listBox1.SelectedItem.ToString());
            foreach (SaleList sale in accessor.GetSaleListsByProductId(product.id))
            {
                ListViewItem li = new ListViewItem();
                li.SubItems[0].Text = sale.sale_price.ToString();
                li.SubItems.Add(sale.sale_quantity.ToString());
                Double sale_amount = sale.sale_price * sale.sale_quantity;
                amount += sale_amount;
                quantity += sale.sale_quantity;
                li.SubItems.Add(sale_amount.ToString());
                listView1.Items.Add(li);
            }
            sales_quantity.Text = quantity.ToString();
            sales_amount.Text = amount.ToString();
        }



    }
}
