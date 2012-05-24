using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Purchase_List
    {
        public virtual int id { get; set; }
        public virtual int quantity { get; set; }
        public virtual double price { get; set; }
        public virtual int product_id { get; set; }
        public virtual int supplier_id { get; set; }
    }
}
