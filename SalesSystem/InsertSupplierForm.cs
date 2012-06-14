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
    public partial class InsertSupplierForm : Form
    {
        public InsertSupplierForm()
        {
            InitializeComponent();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
           
            DbAccessor accessor = DbAccessor.Instance;
            try
            {
                if (SupplierNameText.Text == "")
                    throw new FormatException();
                Supplier supplier = new Supplier
                {
                    name = SupplierNameText.Text,
                };
                accessor.CreateSupplier(supplier);
                MessageBox.Show("添加成功");
            }
            catch (FormatException) 
            {
                MessageBox.Show("输入格式有误");
            }
            catch (GenericADOException)
            {
                MessageBox.Show("存在同名的供应商，不能插入");
            }
        }
    }
}
