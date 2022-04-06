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

        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderTransaction> OrderTransactions { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
    }
}
