using GeekBurger.StoreCatalog.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurger.StoreCatalog.Infra.Interfaces
{
    public interface IDbContext
    {
        DbSet<ProductionArea> ProductionsAreas { get; set; }
        void OnModelCreating(ModelBuilder modelBuilder);
        void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
    }
}
