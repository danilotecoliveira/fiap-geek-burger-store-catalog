using GeekBurger.StoreCatalog.Contract;
using Microsoft.EntityFrameworkCore;

namespace GeekBurger.StoreCatalog.Infra.Repositories
{
    public class StoreCatalogDbContext : DbContext
    {
        public StoreCatalogDbContext(DbContextOptions<StoreCatalogDbContext> options)
            : base (options)
        {

        }

        public DbSet<ProductionArea> ProductionsAreas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductionArea>().ToTable("ProductionsAreas");
            modelBuilder.Entity<ProductionArea>().HasKey(x => x.ProductionAreaId);
            modelBuilder.Entity<ProductionArea>().Property(x => x.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<ProductionArea>().Property(x => x.Status).IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"");
            }
        }
    }
}
