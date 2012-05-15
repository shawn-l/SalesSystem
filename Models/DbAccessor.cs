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

        public void CreateProduct(Product product, int productId)
        {
            session.Save(product, productId);
            session.Flush();
        }
        public Product GetProductById(int productId)
        {
            return session.Get<Product>(productId);
        }
    }
}
