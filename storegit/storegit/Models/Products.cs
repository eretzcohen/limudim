using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storegit.Models
{
    public class Products
    {
        public int id { get; set; }
        public string color { get; set; }
        public int price { get; set; }
        public Type_of_jewelry Type_of_jewelry { get; set; }

    }
}
