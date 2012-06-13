using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;

namespace Models
{
    public class DbAccessor
    {
        private ISession session;
        private static DbAccessor instance = null;
        private DbAccessor()
        {
            session = (new Configuration()).Configure().BuildSessionFactory().OpenSession();
        }
       
        public static DbAccessor Instance 
        {
            get {
                if (  instance == null )
                    instance = new DbAccessor();
                return instance;
            }
        }

        public void CreateProduct(Product product)
        {
            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.Save(product);
                    session.Flush();
                    tx.Commit();
                }
                catch (HibernateException)
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public void CreateSupplier(Supplier supplier)
        {
            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.Save(supplier);
                    session.Flush();
                    tx.Commit();
                }
                catch (HibernateException)
                {
                    tx.Rollback();
                    throw;
                }
            }
        }
        public void CreatePurchaseList(PurchaseList purchase_list)
        {
            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.Save(purchase_list);

                    Product product = session.Get<Product>(purchase_list.product_id);
                    product.stock += purchase_list.quantity;
                    session.Update(product);

                    session.Flush();
                    tx.Commit();
                }
                catch (HibernateException)
                {
                    tx.Rollback();
                    throw;
                }
            }
        }
        public void CreateSaleList(SaleList sale_list)
        {
            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.Save(sale_list);

                    Product product = session.Get<Product>(sale_list.product_id);
                    product.stock -= sale_list.sale_quantity;
                    product.sale_quantity += sale_list.sale_quantity;
                    product.amount += sale_list.sale_price * sale_list.sale_quantity;
                    session.Update(product);

                    session.Flush();
                    tx.Commit();
                }
                catch (HibernateException)
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public Product GetProductById(int productId)
        {
            return session.Get<Product>(productId);
        }
        public Product GetProductByName(string name)
        {
            return   session.CreateCriteria(typeof(Product)).Add(Restrictions.Eq("name", name)).List<Product>()[0];
        }
        public IList<Product> GetAllProduct()
        {
            return session.CreateQuery("from Product").List<Product>();
        }
        public Supplier GetSupplierByName(string name)
        {
            return session.CreateCriteria(typeof(Supplier)).Add(Restrictions.Eq("name", name)).List<Supplier>()[0];
        }
        public IList<Supplier> GetAllSupplier()
        {
            return session.CreateQuery("from Supplier").List<Supplier>();
        }
        public IList<PurchaseList> GetPurchaseListsBySupplierId(int supplier_id)
        {
            return session.CreateCriteria(typeof(PurchaseList)).Add(Restrictions.Eq("supplier_id", supplier_id)).List<PurchaseList>();
        }
        public IList<SaleList> GetSaleListsByProductId(int product_id)
        {
            return session.CreateCriteria(typeof(SaleList)).Add(Restrictions.Eq("product_id", product_id)).List<SaleList>();
        }
        public void UpdateProduct(Product product)
        {
            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.Update(product);
                    session.Flush();
                    tx.Commit();
                }
                catch (HibernateException)
                {
                    tx.Rollback();
                    throw;
                }
            }
        }
        public void UpdateSupplier(Supplier supplier)
        {
            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.Update(supplier);
                    session.Flush();
                    tx.Commit();
                }
                catch (HibernateException)
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public void DeleteProduct(Product product)
        {
            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.Delete(product);
                    session.Flush();
                    tx.Commit();
                }
                catch (HibernateException)
                {
                    tx.Rollback();
                    throw;
                }
            }
        }
        public void DeleteSupplier(Supplier supplier)
        {
            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.Delete(supplier);
                    session.Flush();
                    tx.Commit();
                }
                catch (HibernateException)
                {
                    tx.Rollback();
                    throw;
                }
            }
        }
        public void DeletePurchaseList(PurchaseList purchase_list)
        {
            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.Delete(purchase_list);
                    session.Flush();
                    tx.Commit();
                }
                catch (HibernateException)
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        public void DeleteSale(SaleList sale_list)
        {
            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.Delete(sale_list);
                    session.Flush();
                    tx.Commit();
                }
                catch (HibernateException)
                {
                    tx.Rollback();
                    throw;
                }
            }
        }




    }
}
