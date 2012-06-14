using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

namespace Models
{
    public class DbAccessor
    {
        private  ISession session;
        private static DbAccessor instance = null;
        private DbAccessor()
        {
            session = (new Configuration()).Configure().BuildSessionFactory().OpenSession();
        }

        public static DbAccessor Instance 
        {
            get
            {
                if (instance == null)
                    instance = new DbAccessor();
                return instance;
            }
        
        }

        public void CreateProduct(Product product)
        {
                try
                {
                    session.Save(product);
                    session.Flush();
                }
                catch (GenericADOException)
                {
                    session.Clear();
                    throw;
                }
        }

        public void CreateSupplier(Supplier supplier)
        {
                try
                {
                    session.Save(supplier);
                    session.Flush();
                }
                catch (GenericADOException)
                {
                    session.Clear();
                    throw;
                }
        }
        public void CreatePurchaseList(PurchaseList purchase_list)
        {
                try
                {
                    session.Save(purchase_list);

                    Product product = session.Get<Product>(purchase_list.product_id);
                    product.stock += purchase_list.quantity;
                    product.purchase_price = purchase_list.price;
                    session.Update(product);

                    session.Flush();
                }
                catch (HibernateException)
                {
                    session.Clear();
                    throw;
                }

        }
        public void CreateSaleList(SaleList sale_list)
        {
                try
                {
                    Product product = session.Get<Product>(sale_list.product_id);
                    int old_stock = product.stock;
                    product.stock -= sale_list.sale_quantity;
                    if (product.stock < 0)
                    {
                        product.stock = 0;
                        sale_list.sale_quantity = old_stock;
                    }
                    session.Save(sale_list);
                    session.Update(product);

                    session.Flush();
                }
                catch (HibernateException)
                {
                    session.Clear();
                    throw;
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
                try
                {
                    session.Update(product);
                    session.Flush();
                }
                catch (GenericADOException)
                {
                   session.Clear();
                    throw;
                }
        }
        public void UpdateSupplier(Supplier supplier)
        {
                try
                {
                    session.Update(supplier);
                    session.Flush();
                }
                catch (GenericADOException)
                {
                    session.Clear();
                    throw;
                }
        }

        public void DeleteProduct(Product product)
        {
                try
                {
                    session.Delete(product);
                    session.Flush();
                }
                catch (HibernateException)
                {
                   session.Clear();
                    throw;
                }
        }
        public void DeleteSupplier(Supplier supplier)
        {
                try
                {
                    session.Delete(supplier);
                    session.Flush();
                }
                catch (HibernateException)
                {
                   session.Clear();
                    throw;
                }
        }





    }
}
