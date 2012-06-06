using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SaleList
    {
        public virtual int id { get; set; }
        public virtual int salequantity { get; set; }
        public virtual int product_id { get; set; }
    }
}
