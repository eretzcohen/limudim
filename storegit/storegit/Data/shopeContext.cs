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
    }
}
