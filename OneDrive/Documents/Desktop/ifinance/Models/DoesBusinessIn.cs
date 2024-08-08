using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("does_business_in")]
    public class DoesBusinessIn : DbContext
    {
        [Column("TerritoryID", TypeName = "bigint")]
        public long TerritoryID { get; set; }

        [Required]
        [Column("CustomerID", TypeName = "bigint")]
        public long CustomerID { get; set; }

        public ICollection<SalesTerritoryBusiness> SalesTerritoryBusinesses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoesBusinessIn>()
                .HasKey(di => new { di.TerritoryID, di.CustomerID });
        }
    }
}
