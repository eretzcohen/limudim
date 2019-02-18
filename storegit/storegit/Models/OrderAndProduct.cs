using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace storegit.Models
{
    public class OrderAndProduct 
    {
        public int OrderAndProductid{ get; set; }

        public int OrderId { get; set; }
        public Order order { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}
