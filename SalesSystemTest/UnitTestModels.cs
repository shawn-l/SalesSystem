using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
namespace SalesSystemTest
{
    /// <summary>
    /// UnitTest1 的摘要说明
    /// </summary>
    [TestClass]
    public class UnitTestModels
    {
        public UnitTestModels()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性:
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestCRUDAboutProudctModel()
        {
            //
            // TODO: 在此处添加测试逻辑
            //
            DbAccessor accessor = DbAccessor.Instance;
            Product product = new Product { Id = 0, Name = "汽水", Price = 3.5, Quantity = 100 };
            accessor.Create(product);
            Product dbProduct = accessor.GetProductById(product.Id);
            
            Assert.AreEqual(product.Id, dbProduct.Id);
            Assert.AreEqual(product.Name, dbProduct.Name);
            Assert.AreEqual(product.Price, dbProduct.Price);
            Assert.AreEqual(product.Quantity, dbProduct.Quantity);

            product.Name = "饼干";
            accessor.UpdateProduct(product);
            dbProduct = accessor.GetProductById(product.Id);
            Assert.AreEqual(dbProduct.Name, product.Name);

            accessor.DeleteProduct(product);
            Assert.AreEqual(null, accessor.GetProductById(product.Id));
        }
        [TestMethod]
        public void TestCRUDAboutSupplierModel()
        {
            //
            // TODO: 在此处添加测试逻辑
            //
            DbAccessor accessor = DbAccessor.Instance;
            Supplier supplier= new Supplier { name = "珠海汽水公司" };
            accessor.Create(supplier);
         
           
        }
        [TestMethod]
        public void TestCRUDAboutPurchaseListModel() {
            DbAccessor accessor = DbAccessor.Instance;
            Product product = accessor.GetProductById(2);
            Supplier supplier = accessor.GetSupplierById(7);
            Purchase_List purchase = new Purchase_List { quantity = 100, price = 10.5, product_id = product.Id, supplier_id = supplier.id };
            accessor.Create(purchase);
        }

    }
}
