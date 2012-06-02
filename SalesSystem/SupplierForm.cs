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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier
            {
                id = Int32.Parse(SupplierIdText.Text),
                name = SupplierNameText.Text,
            };
            DbAccessor accessor = DbAccessor.Instance;
            accessor.CreateSupplier(supplier);
        }

        private void search_Click(object sender, EventArgs e)
        {
            int search_id = Int32.Parse(searchIdText.Text);
            DbAccessor accessor = DbAccessor.Instance;
            Supplier supplier = accessor.GetSupplierById(search_id);
            displayId.Text = supplier.id.ToString();
            displayName.Text = supplier.name.ToString();
        }

    

    }
}
