using Microsoft.EntityFrameworkCore;
using ProtectedAreas.Models;

namespace ProtectedAreas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<ProtectedArea> ProtectedAreas { get; set; }
        public DbSet<ObsoleteName> ObsoleteNames{ get; set; }
        public DbSet<InternationalStatus> InternationalStatuses{ get; set; }
        public DbSet<Liquidation> Liquidations { get; set; }
    }
}