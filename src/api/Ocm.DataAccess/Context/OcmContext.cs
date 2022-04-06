using Microsoft.EntityFrameworkCore;
using Ocm.Entities.Concrete;

namespace Ocm.DataAccess.Context
{
    public class OcmContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=OcmDb;Trusted_Connection=true");
        }

        public DbSet<Category> Customers { get; set; }
        public DbSet<OrderTransaction> Products { get; set; }
        public DbSet<Shipment> Categories { get; set; }
    }
}
