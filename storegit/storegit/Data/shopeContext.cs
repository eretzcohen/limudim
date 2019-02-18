using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using storegit.Models;

namespace storegit.Models
{
    public class shopeContext : DbContext
    {
        public shopeContext(DbContextOptions<shopeContext> options)
            : base(options)
        {
        }
        public DbSet<storegit.Models.NewOrder> NewOrder { get; set; }

        public DbSet<storegit.Models.NewProduct> NewProduct { get; set; }

        public DbSet<storegit.Models.NewUser> NewUser { get; set; }

        public DbSet<storegit.Models.ProductOrder> ProductOrder { get; set; }

        public DbSet<storegit.Models.Product> Product { get; set; }

        public DbSet<storegit.Models.Order> Order { get; set; }

        public DbSet<storegit.Models.Customer> Customer { get; set; }

        public DbSet<storegit.Models.Customer> OrderAndProduct { get; set; }
    }
}
