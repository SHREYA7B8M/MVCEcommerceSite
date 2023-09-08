using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhaseEnd2.Models;

namespace PhaseEnd2.Data
{
    public class PhaseEnd2DbContext : DbContext
    {
        public PhaseEnd2DbContext (DbContextOptions<PhaseEnd2DbContext> options)
            : base(options)
        {
        }

        public DbSet<PhaseEnd2.Models.Order> Order { get; set; } = default!;

        public DbSet<PhaseEnd2.Models.OrderDetail>? OrderDetail { get; set; }

        public DbSet<PhaseEnd2.Models.Product>? Product { get; set; }
    }
}
