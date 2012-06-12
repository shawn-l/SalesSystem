using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Product
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual double price { get; set; }
        public virtual int stock { get; set; }
        public virtual int sale_quantity { get; set; }
        public virtual double amount { get; set; }
     
    }
}
