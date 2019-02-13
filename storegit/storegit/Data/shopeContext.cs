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
        public shopeContext (DbContextOptions<shopeContext> options)
            : base(options)
        {
        }

        public DbSet<storegit.Models.Users> Users { get; set; }

        public DbSet<storegit.Models.Adress> Adress { get; set; }

        public DbSet<storegit.Models.Products> Products { get; set; }
        
        public DbSet<storegit.Models.orders> orders { get; set; }
        
        public DbSet<storegit.Models.NewOrder> NewOrder { get; set; }
        
        public DbSet<storegit.Models.NewProduct> NewProduct { get; set; }
        
        public DbSet<storegit.Models.NewUser> NewUser { get; set; }
        
        public DbSet<storegit.Models.ProductOrder> ProductOrder { get; set; }
    }
}
