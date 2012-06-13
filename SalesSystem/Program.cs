using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SalesSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ProductForm());
            //Application.Run(new SupplierForm());
           // Application.Run(new PurchaseListForm());
            Application.Run(new MainForm());
        }
    }
}
