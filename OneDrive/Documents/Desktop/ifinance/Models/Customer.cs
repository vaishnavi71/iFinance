using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        [Column("CustomerId",TypeName = "bigint")]
        public long CustomerId { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string CustomerAddress { get; set; }

        public string? CutomerPostalCode { get; set; }

        public ICollection<SalesTerritory> SalesTerritories { get; set; }
        public ICollection<DoesBusinessIn> DoesBusinessIns { get; set; }
    }
}
