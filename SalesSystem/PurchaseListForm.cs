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
    public partial class PurchaseListForm : Form
    {
        public PurchaseListForm()
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
            int productId = productListBox.SelectedIndex + 1;
            int supplierId = supplierListBox.SelectedIndex + 1;
            int index = productListBox.SelectedIndex;
            PurchaseList purchase_list = new PurchaseList
            {
                id = Int32.Parse(purchaseId.Text),
                price = Double.Parse(purchasePrice.Text),
                quantity = Int32.Parse(purchaseQuantity.Text),
                product_id = productId,
                supplier_id = supplierId
            };
            accessor.CreatePurchaseList(purchase_list);
        }

       
    }
}
