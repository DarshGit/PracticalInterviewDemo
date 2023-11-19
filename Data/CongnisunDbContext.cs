using CognisunPractical.Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace CognisunPractical.Data
{
    public class CongnisunDbContext : DbContext
    {
        public CongnisunDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ProductMaster> ProductMasters { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<TaxMaster> TaxMaster { get; set; }


    }
}
