using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertProductForm insert_product = new InsertProductForm();
            insert_product.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductsForm statistic = new ProductsForm();
            statistic.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsertSupplierForm insert_supplier = new InsertSupplierForm();
            insert_supplier.Show();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            PurchaseForm purchase = new PurchaseForm();
            purchase.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SuppliersForm suppliers = new SuppliersForm();
            suppliers.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaleForm sale = new SaleForm();
            sale.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaleDetialForm saledetial = new SaleDetialForm();
            saledetial.Show();
        }
    }
}
