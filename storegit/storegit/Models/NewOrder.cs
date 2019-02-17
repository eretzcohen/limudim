using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storegit.Models
{
    public class NewOrder
    {
        public int Id { get; set; }

        public string Data { get; set; }

        public ICollection<ProductOrder> Products { get; set; }

        public NewUser User { get; set; }
    }
}
