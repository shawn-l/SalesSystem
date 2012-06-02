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

            DbAccessor accessor = DbAccessor.Instance;
            Product product = new Product { Id = 0, Name = "汽水", Price = 3.5, Quantity = 100 };
            accessor.CreateProduct(product);
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

            IList<Product> productList = accessor.GetAllProduct();
            Assert.AreEqual(1, productList.Count);
        }
        [TestMethod]
        public void TestCRUDAboutSupplierModel()
        {
     
            DbAccessor accessor = DbAccessor.Instance;
            Supplier supplier= new Supplier { id = 0, name = "珠海汽水公司" };
            accessor.CreateSupplier(supplier);

            Supplier dbSupplier = accessor.GetSupplierById(supplier.id);

            Assert.AreEqual(0, dbSupplier.id);
            Assert.AreEqual("珠海汽水公司", dbSupplier.name);

            supplier.name = "中山汽水公司";
            accessor.UpdateSupplier(supplier);
            dbSupplier = accessor.GetSupplierById(supplier.id);
            Assert.AreEqual("中山汽水公司",  dbSupplier.name);

            accessor.DeleteSupplier(supplier);
            Assert.AreEqual(null, accessor.GetSupplierById(supplier.id));

            IList<Supplier> supplierList = accessor.GetAllSupplier();
            Assert.AreEqual(1, supplierList.Count);
           
        }
        [TestMethod]
        public void TestCRUDAboutPurchaseListModel() {
            DbAccessor accessor = DbAccessor.Instance;
            
            Product product = new Product { Id = 0, Name = "汽水", Price = 3.5, Quantity = 100 };
            accessor.CreateProduct(product);
            
            Supplier supplier = new Supplier { id = 0, name = "珠海汽水公司" };
            accessor.CreateSupplier(supplier);
           
            PurchaseList purchase = new PurchaseList { id = 0, quantity = 100, price = 10.5, product_id=product.Id, supplier_id = supplier.id };
            accessor.CreatePurchaseList(purchase);

            PurchaseList dbPurchase_list = accessor.GetPurchaseListById(0);
            Product dbProduct = accessor.GetProductById(0);

            Assert.AreEqual(100, dbPurchase_list.quantity);
            Assert.AreEqual(10.5, dbPurchase_list.price);
            Assert.AreEqual(supplier.id, dbPurchase_list.supplier_id);

            Assert.AreEqual(200, dbProduct.Quantity);

            accessor.DeleteProduct(product);
            accessor.DeleteSupplier(supplier);
   
        }

    }
}
