using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace S5G11_PVFAPP.Models
{
    public class AppDBContext : IdentityDbContext<IdentityUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<DoesBusinessIn> DoesBusinesses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<HasSkill> HasSkills { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<ProducedIn> ProducedIns { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<SalesPerson> Sales { get; set; }
        public DbSet<SalesTerritory> SalesTerritories { get; set; }
        public DbSet<Uses> Uses { get; set; }
        public DbSet<WorksIn> Works { get; set; }
        public DbSet<WorkCenter> WorkCenters { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Supplies> Supplies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasKey(l => new { l.LoginProvider, l.ProviderKey });

            modelBuilder.Entity<SalesTerritoryBusiness>()
        .HasKey(stb => new { stb.TerritoryID, stb.BusinessID });

            modelBuilder.Entity<SalesTerritoryBusiness>()
                .HasOne(stb => stb.Territory)
                .WithMany(st => st.SalesTerritoryBusinesses)
                .HasForeignKey(stb => stb.TerritoryID);

            modelBuilder.Entity<SalesTerritoryBusiness>()
                .HasOne(stb => stb.Business)
                .WithMany(db => db.SalesTerritoryBusinesses)
                .HasForeignKey(stb => stb.BusinessID);

            modelBuilder.Entity<DoesBusinessIn>()
                .HasKey(di => new { di.TerritoryID, di.CustomerID });

            modelBuilder.Entity<DoesBusinessIn>()
                .HasMany(di => di.SalesTerritoryBusinesses)
                .WithOne(stb => stb.Business)
                .HasForeignKey(stb => new { stb.TerritoryID, stb.BusinessID });

            modelBuilder.Entity<HasSkill>()
                .HasKey(hs => new { hs.SkillID, hs.EmployeeID });

            modelBuilder.Entity<ProducedIn>()
                .HasKey(pi => new { pi.WorkCenterId, pi.ProductID });

            modelBuilder.Entity<Supplies>()
                .HasOne(s => s.RawMaterial)
                .WithMany(r => r.Supplies)
                .HasForeignKey(s => s.MaterialID);

            modelBuilder.Entity<Supplies>()
                .HasOne(s => s.Vendor)
                .WithMany(v => v.Supplies)
                .HasForeignKey(s => s.VendorlID);

            modelBuilder.Entity<RawMaterial>()
                .HasMany(r => r.Supplies)
                .WithOne(s => s.RawMaterial)
                .HasForeignKey(s => s.MaterialID);

            modelBuilder.Entity<Uses>()
                .HasKey(u => new { u.MaterialID, u.ProductID });

            modelBuilder.Entity<WorksIn>()
                .HasNoKey();

            modelBuilder.Entity<VendorRawMaterial>()
                .HasKey(vrm => new { vrm.VendorId, vrm.MaterialID });

            modelBuilder.Entity<VendorRawMaterial>()
                .HasOne(vrm => vrm.Vendor)
                .WithMany(v => v.VendorRawMaterials)
                .HasForeignKey(vrm => vrm.VendorId);

            modelBuilder.Entity<VendorRawMaterial>()
                .HasOne(vrm => vrm.RawMaterial)
                .WithMany(rm => rm.VendorRawMaterials)
                .HasForeignKey(vrm => vrm.MaterialID);

            modelBuilder.Entity<ProductRawMaterial>()
                .HasKey(prm => new { prm.ProductId, prm.MaterialID });

            modelBuilder.Entity<ProductRawMaterial>()
                .HasOne(prm => prm.Product)
                .WithMany(p => p.ProductRawMaterials)
                .HasForeignKey(prm => prm.ProductId);

            modelBuilder.Entity<ProductRawMaterial>()
                .HasOne(prm => prm.RawMaterial)
                .WithMany(rm => rm.ProductRawMaterials)
                .HasForeignKey(prm => prm.MaterialID);
        }
    }
}

