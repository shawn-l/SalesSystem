using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using NHibernate.Exceptions;
namespace SalesSystem
{
    public partial class SuppliersForm : Form
    {
        DbAccessor accessor = DbAccessor.Instance;
        public SuppliersForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Columns.Clear();
                listView1.Items.Clear();
                Supplier supplier = accessor.GetSupplierByName(this.listBox1.SelectedItem.ToString());
                name.Text = supplier.name;
                this.listView1.GridLines = true;
                this.listView1.View = View.Details;
                this.listView1.Scrollable = true;
                listView1.Columns.Add("进货商品", 60);
                listView1.Columns.Add("数量");
                listView1.Columns.Add("买入价格");

                foreach (PurchaseList purchase_list in accessor.GetPurchaseListsBySupplierId(supplier.id))
                {
                    ListViewItem li = new ListViewItem();
                    Product product = accessor.GetProductById(purchase_list.product_id);
                    li.SubItems[0].Text = product.name;
                    li.SubItems.Add(purchase_list.quantity.ToString());
                    li.SubItems.Add(purchase_list.price.ToString());
                    listView1.Items.Add(li);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("还没选择供货商");
            }
        }

        private void AddDataToListBox()
        {
            foreach (Supplier supplier in accessor.GetAllSupplier())
            {
                listBox1.Items.Add(supplier.name);
            }
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            AddDataToListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = accessor.GetSupplierByName(this.listBox1.SelectedItem.ToString());
                accessor.DeleteSupplier(supplier);
                listBox1.Items.Remove(this.listBox1.SelectedItem);
                MessageBox.Show("删除成功");
                name.Text = "";
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("还没选择供应商");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text == "")
                    throw new FormatException();
                Supplier supplier = accessor.GetSupplierByName(this.listBox1.SelectedItem.ToString());
                supplier.name = name.Text;
                accessor.UpdateSupplier(supplier);
                listBox1.Items.Clear();
                AddDataToListBox();
                MessageBox.Show("更新成功");
            }
            catch (FormatException)
            {
                MessageBox.Show("输入格式有误");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("还未选中供应商");
            }
            catch (GenericADOException)
            {
                MessageBox.Show("存在同名供应商，不能更新");
            }
        }
    }
}
