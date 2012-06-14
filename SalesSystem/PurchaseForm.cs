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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
            DbAccessor accessor = DbAccessor.Instance;
            ArrayList productNames = new ArrayList();
            ArrayList supplierNames = new ArrayList();
            foreach (Product product in accessor.GetAllProduct())
                productNames.Add(product.name);
            foreach (Supplier supplier in accessor.GetAllSupplier())
                supplierNames.Add(supplier.name);
            productListBox.DataSource = productNames;
            supplierListBox.DataSource = supplierNames;
        }

        private void purchaseInsert_Click(object sender, EventArgs e)
        {
            DbAccessor accessor = DbAccessor.Instance;
            Product product = accessor.GetProductByName(productListBox.SelectedItem.ToString());
            Supplier supplier = accessor.GetSupplierByName(supplierListBox.SelectedItem.ToString());
            try
            {
                PurchaseList purchase_list = new PurchaseList
                {
                    price = Double.Parse(purchasePrice.Text),
                    quantity = Int32.Parse(purchaseQuantity.Text),
                    product_id = product.id,
                    supplier_id = supplier.id
                };
                accessor.CreatePurchaseList(purchase_list);
                MessageBox.Show("添加成功");
            }
            catch(FormatException) {
                MessageBox.Show("输入的字段格式有误");
            }
        }
    }
}
