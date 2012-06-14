using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SaleList
    {
        public virtual int id { get; set; }
        public virtual int sale_quantity { get; set; }
        public virtual double sale_price { get; set; }
        public virtual int product_id { get; set; }
        public virtual double purchase_price { get; set; }
    }
}
