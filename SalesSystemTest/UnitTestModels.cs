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
            Product product = new Product { id = 0, name = "汽水", price = 3.5, stock = 100, sale_quantity = 0, amount = 0.0};
            accessor.CreateProduct(product);
            Product dbProduct = accessor.GetProductById(product.id);
            
            Assert.AreEqual(product.id, dbProduct.id);
            Assert.AreEqual(product.name, dbProduct.name);
            Assert.AreEqual(product.price, dbProduct.price);
            Assert.AreEqual(product.stock, dbProduct.stock);

            product.name = "饼干";
            accessor.UpdateProduct(product);
            dbProduct = accessor.GetProductById(product.id);
            Assert.AreEqual(dbProduct.name, product.name);

            accessor.DeleteProduct(product);
            Assert.AreEqual(null, accessor.GetProductById(product.id));

            IList<Product> productList = accessor.GetAllProduct();
            Assert.AreEqual(3, productList.Count);
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
            Assert.AreEqual(3, supplierList.Count);
           
        }
        [TestMethod]
        public void TestCRUDAboutPurchaseListModel() {
            DbAccessor accessor = DbAccessor.Instance;
            
            Product product = new Product { id = 0, name = "汽水", price = 3.5, stock = 100 };
            accessor.CreateProduct(product);
            
            Supplier supplier = new Supplier { id = 0, name = "珠海汽水公司" };
            accessor.CreateSupplier(supplier);
           
            PurchaseList purchase = new PurchaseList { id = 0, quantity = 100, price = 10.5, product_id=product.id, supplier_id = supplier.id };
            accessor.CreatePurchaseList(purchase);

            PurchaseList dbPurchase_list = accessor.GetPurchaseListById(0);
            Product dbProduct = accessor.GetProductById(0);

            Assert.AreEqual(100, dbPurchase_list.quantity);
            Assert.AreEqual(10.5, dbPurchase_list.price);
            Assert.AreEqual(supplier.id, dbPurchase_list.supplier_id);

            Assert.AreEqual(200, dbProduct.stock);

            accessor.DeleteProduct(product);
            accessor.DeleteSupplier(supplier);
   
        }
        [TestMethod]
        public void TestCRUDAbouSaleModel()
        {
            DbAccessor accessor = DbAccessor.Instance;

            Product product = new Product { id = 0, name = "汽水", price = 3.5, stock = 100, sale_quantity = 0, amount = 0.0 };
            accessor.CreateProduct(product);

            SaleList sale = new SaleList { id = 0, salequantity = 5, product_id = product.id };
            accessor.CreateSaleList(sale);

            SaleList dbSale_list = accessor.GetSaleListById(0);
            Product dbProduct = accessor.GetProductById(0);

            Assert.AreEqual(5, dbSale_list.salequantity);
            Assert.AreEqual(5, dbProduct.sale_quantity);
            Assert.AreEqual(dbSale_list.salequantity * dbProduct.price, dbProduct.amount);
            Assert.AreEqual(dbProduct.id, dbSale_list.product_id);

            Assert.AreEqual(95, dbProduct.stock);

            accessor.DeleteProduct(product);
        }


    }
}
