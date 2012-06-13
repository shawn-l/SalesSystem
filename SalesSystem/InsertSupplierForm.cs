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
    public partial class InsertSupplierForm : Form
    {
        public InsertSupplierForm()
        {
            InitializeComponent();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier
            {
                name = SupplierNameText.Text,
            };
            DbAccessor accessor = DbAccessor.Instance;
            accessor.CreateSupplier(supplier);
            MessageBox.Show("添加成功");
        }
    }
}
