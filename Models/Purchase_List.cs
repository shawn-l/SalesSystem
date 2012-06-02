using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class PurchaseList
    {
        public virtual int id { get; set; }
        public virtual int quantity { get; set; }
        public virtual double price { get; set; }
      public virtual int product_id { get; set; }
       public virtual int supplier_id { get; set; }
     
    }
}
