using Microsoft.EntityFrameworkCore;
using DJATI_EAM.Shared.StoredProcedures;

namespace DJATI_EAM.Model
{
    public partial class DJATIEAMDBContext : DbContext
    {
        public DJATIEAMDBContext(DbContextOptions<DJATIEAMDBContext> options) : base(options) { }

        public DbSet<xpAssetTree>? xpAssetTrees { get; set; }
        public DbSet<xpAssetGroup>? xpAssetGroups { get; set; }
        public DbSet<xpAssetCategory>? xpAssetCategories { get; set; }
        public DbSet<xpAssetClassification>? xpAssetClassifications { get; set; }
        public DbSet<xpAssetBrand>? xpAssetBrands { get; set; }
        public DbSet<xpAsset>? xpAssets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) { return; }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<xpAssetTree>().HasNoKey();
            modelBuilder.Entity<xpAssetGroup>().HasNoKey();
            modelBuilder.Entity<xpAssetCategory>().HasNoKey();
            modelBuilder.Entity<xpAssetClassification>().HasNoKey();
            modelBuilder.Entity<xpAssetBrand>().HasNoKey();
            modelBuilder.Entity<xpAsset>().HasNoKey();

            modelBuilder.Entity<xpAsset>().Property(e => e.Price).HasPrecision(12, 0);
            modelBuilder.Entity<xpAsset>().Property(e => e.Resale_Price).HasPrecision(12, 0);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
