using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace storegit.Models
{
    public class ProductOrder
    {
        public int id { get; set; }
        [Display(Name = "Order")]

        
        public int OrderId { get; set; }
        public NewOrder Order { get; set; }

        [Display(Name = "Product")]

        public int ProductId { get; set; }

        public NewProduct Product  { get; set; }



    }
}
