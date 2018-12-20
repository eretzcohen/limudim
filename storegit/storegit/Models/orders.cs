using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storegit.Models
{
    public class orders
    {
        public int id { get; set; }

        public string data{ get; set; }
        public Users Users { get; set; }
        public ICollection<Products> products { get; set; }

    }
}
