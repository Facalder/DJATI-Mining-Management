using Microsoft.EntityFrameworkCore;
using DJATI_EAM.Shared.StoredProcedures;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DJATI_EAM.Model
{
    public partial class EAMDBContext : DbContext
    {
        public EAMDBContext(DbContextOptions<EAMDBContext> options) : base(options) { }

        public DbSet<XpAssetTree>? xpAssetTrees { get; set; }
        public DbSet<XpAssetGroup>? xpAssetGroups { get; set; }
        public DbSet<XpAssetCategory>? xpAssetCategories { get; set; }
        public DbSet<XpAssetClassification>? xpAssetClassifications { get; set; }
        public DbSet<XpAssetBrand>? xpAssetBrands { get; set; }
        public DbSet<XpAsset>? xpAssets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) { return; }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<XpAssetTree>().HasNoKey();
            modelBuilder.Entity<XpAssetGroup>().HasNoKey();
            modelBuilder.Entity<XpAssetCategory>().HasNoKey();
            modelBuilder.Entity<XpAssetClassification>().HasNoKey();
            modelBuilder.Entity<XpAssetBrand>().HasNoKey();
            modelBuilder.Entity<XpAsset>().HasNoKey();

            modelBuilder.Entity<XpAsset>().Property(e => e.Price).HasPrecision(12, 0);
            modelBuilder.Entity<XpAsset>().Property(e => e.Resale_Price).HasPrecision(12, 0);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}