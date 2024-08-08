using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("sales_terrotory")]
    public class SalesTerritory
    {
        [Key]
        [Column("TerrotoryID", TypeName = "bigint")]
        public long TerrotoryID { get; set; }

        [Required]
        public string TerrotoryName { get; set; }

        public SalesPerson salesPerson { get; set; }

        public ICollection<SalesTerritoryBusiness> SalesTerritoryBusinesses { get; set; }
    }
}
