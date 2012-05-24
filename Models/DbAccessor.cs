using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;

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

        public void Create(Object product)
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

        public Product GetProductById(int productId)
        {
            return session.Get<Product>(productId);
        }
        public Supplier GetSupplierById(int supplierId)
        {
            return session.Get<Supplier>(supplierId);
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
    }
}
