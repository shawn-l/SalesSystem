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
        DbAccessor accessor;
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
        [TestInitialize()]
        public void SetUp() 
        {
            accessor = DbAccessor.Instance;
        }
        [TestMethod]
        public void TestCRUDAboutProudctModel()
        {

            Product product = new Product { name = "name", price = 3.5};

            accessor.CreateProduct(product);
            Product dbProduct = accessor.GetProductByName(product.name);

            Assert.AreEqual(product.name, dbProduct.name);
            Assert.AreEqual(product.price, dbProduct.price);
            Assert.AreEqual(0, dbProduct.stock);
            Assert.AreEqual(0.0, dbProduct.purchase_price);

            product.name = "change_name";
            accessor.UpdateProduct(product);
            dbProduct = accessor.GetProductByName(product.name);
            Assert.AreEqual(dbProduct.name, product.name);

            accessor.DeleteProduct(product);
        }
        [TestMethod]
        public void TestCRUDAboutSupplierModel()
        {
            Supplier supplier = new Supplier { name = "test_supplier" };
            accessor.CreateSupplier(supplier);

            Supplier dbSupplier = accessor.GetSupplierByName(supplier.name);

            Assert.AreEqual(supplier.name, dbSupplier.name);

            supplier.name = "change_name";
            accessor.UpdateSupplier(supplier);
            dbSupplier = accessor.GetSupplierByName(supplier.name);
            Assert.AreEqual(supplier.name, dbSupplier.name);

            accessor.DeleteSupplier(supplier);
        }
        [TestMethod]
        public void TestCRUDAboutPurchaseListModel()
        {
            Product product = new Product { name = "test_prodcut", price = 3.5 };
            accessor.CreateProduct(product);

            Supplier supplier = new Supplier { name = "test_supplier" };
            accessor.CreateSupplier(supplier);

            PurchaseList purchase = new PurchaseList { quantity = 100, price = 10.5, product_id = product.id, supplier_id = supplier.id };
            accessor.CreatePurchaseList(purchase);

            PurchaseList dbPurchase_list = accessor.GetPurchaseListsBySupplierId(supplier.id)[0];
            Product dbProduct = accessor.GetProductByName(product.name);

            Assert.AreEqual(100, dbPurchase_list.quantity);
            Assert.AreEqual(10.5, dbPurchase_list.price);
            Assert.AreEqual(supplier.id, dbPurchase_list.supplier_id);

            Assert.AreEqual(100, dbProduct.stock);
            Assert.AreEqual(10.5, dbProduct.purchase_price);

            accessor.DeleteProduct(product);
            accessor.DeleteSupplier(supplier);

        }
        [TestMethod]
        public void TestCRUDAbouSaleModel()
        {
            Product product = new Product { name = "test_name", price = 3.5, stock = 100, purchase_price = 2.5 };
            accessor.CreateProduct(product);

            SaleList sale = new SaleList { sale_quantity = 5, product_id = product.id, sale_price = product.price, purchase_price = product.purchase_price };
            accessor.CreateSaleList(sale);

            SaleList dbSale_list = accessor.GetSaleListsByProductId(product.id)[0];
            Product dbProduct = accessor.GetProductByName(product.name);

            Assert.AreEqual(5, dbSale_list.sale_quantity);
            Assert.AreEqual(dbProduct.id, dbSale_list.product_id);
            Assert.AreEqual(dbProduct.purchase_price, dbSale_list.purchase_price);

            Assert.AreEqual(95, dbProduct.stock);

            accessor.DeleteProduct(product);
        }
        [TestMethod]
        public void TestGetPurchaseListForSupplier()
        {
            Product product = new Product { name = "test_name", price = 3.5, stock = 100 };
            Product another_product = new Product { name = "another_name", price = 3.5, stock = 100 };
            accessor.CreateProduct(product);
            accessor.CreateProduct(another_product);

            Supplier supplier = new Supplier { name = "test_supplier" };
            accessor.CreateSupplier(supplier);

            PurchaseList purchase = new PurchaseList { quantity = 100, price = 10.5, product_id = product.id, supplier_id = supplier.id };
            PurchaseList another_purchase = new PurchaseList { quantity = 50, price = 10.5, product_id = another_product.id, supplier_id = supplier.id };
            accessor.CreatePurchaseList(purchase);
            accessor.CreatePurchaseList(another_purchase);

            Assert.AreEqual(2, accessor.GetPurchaseListsBySupplierId(supplier.id).Count);

            accessor.DeleteProduct(product);
            accessor.DeleteProduct(another_product);
            accessor.DeleteSupplier(supplier);
        }
        [TestMethod]
        public void TestNotEnoughtProductToSale()
        {
            Product product = new Product { name = "text_product", price = 2.5, stock = 30, purchase_price = 2 };
            accessor.CreateProduct(product);
            SaleList sale = new SaleList { product_id = product.id, sale_price = product.price, purchase_price = product.purchase_price, sale_quantity = 40 };
            accessor.CreateSaleList(sale);

            Product dbProduct = accessor.GetProductById(product.id);
            SaleList dbSale = accessor.GetSaleListsByProductId(product.id)[0];

            Assert.AreEqual(0, dbProduct.stock);
            Assert.AreEqual(30, dbSale.sale_quantity);

            accessor.DeleteProduct(product);
        }
 
    }
}
