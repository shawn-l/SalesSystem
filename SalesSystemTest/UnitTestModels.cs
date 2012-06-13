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
            Product product = new Product { name = "name", price = 3.5, stock = 100, sale_quantity = 0, amount = 0.0};
            accessor.CreateProduct(product);
            Product dbProduct = accessor.GetProductByName(product.name);
            
            Assert.AreEqual(product.name, dbProduct.name);
            Assert.AreEqual(product.price, dbProduct.price);
            Assert.AreEqual(product.stock, dbProduct.stock);

            product.name = "change_name";
            accessor.UpdateProduct(product);
            dbProduct = accessor.GetProductByName(product.name);
            Assert.AreEqual(dbProduct.name, product.name);

            accessor.DeleteProduct(product);
        }
        [TestMethod]
        public void TestCRUDAboutSupplierModel()
        {
     
            DbAccessor accessor = DbAccessor.Instance;
            Supplier supplier= new Supplier { name = "test_supplier" };
            accessor.CreateSupplier(supplier);

            Supplier dbSupplier = accessor.GetSupplierByName(supplier.name);

            Assert.AreEqual(supplier.name, dbSupplier.name);

            supplier.name = "change_name";
            accessor.UpdateSupplier(supplier);
            dbSupplier = accessor.GetSupplierByName(supplier.name);
            Assert.AreEqual(supplier.name,  dbSupplier.name);

            accessor.DeleteSupplier(supplier);     
        }
        [TestMethod]
        public void TestCRUDAboutPurchaseListModel() {
            DbAccessor accessor = DbAccessor.Instance;
            
            Product product = new Product {  name = "test_prodcut", price = 3.5, stock = 100 };
            accessor.CreateProduct(product);
            
            Supplier supplier = new Supplier { name = "test_supplier" };
            accessor.CreateSupplier(supplier);
           
            PurchaseList purchase = new PurchaseList { quantity = 100, price = 10.5, product_id=product.id, supplier_id = supplier.id };
            accessor.CreatePurchaseList(purchase);

            PurchaseList dbPurchase_list = accessor.GetPurchaseListsBySupplierId(supplier.id)[0];
            Product dbProduct = accessor.GetProductByName(product.name);

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

            Product product = new Product { name = "test_name", price = 3.5, stock = 100, sale_quantity = 0, amount = 0.0 };
            accessor.CreateProduct(product);

            SaleList sale = new SaleList {sale_quantity = 5, product_id = product.id,  sale_price = product.price };
            accessor.CreateSaleList(sale);

            SaleList dbSale_list = accessor.GetSaleListsByProductId(product.id)[0];
            Product dbProduct = accessor.GetProductByName(product.name);

            Assert.AreEqual(5, dbSale_list.sale_quantity);
            Assert.AreEqual(5, dbProduct.sale_quantity);
            Assert.AreEqual(dbSale_list.sale_quantity * dbProduct.price, dbProduct.amount);
            Assert.AreEqual(dbProduct.id, dbSale_list.product_id);

            Assert.AreEqual(95, dbProduct.stock);

            accessor.DeleteProduct(product);
        }
        [TestMethod]
        public void TestGetPurchaseListForSupplier()
        {
            DbAccessor accessor = DbAccessor.Instance;

            Product product = new Product { name = "test_name", price = 3.5, stock = 100, sale_quantity = 0, amount = 0.0 };
            Product another_product = new Product { name = "another_name", price = 3.5, stock = 100, sale_quantity = 0, amount = 0.0 };
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
    }
}
