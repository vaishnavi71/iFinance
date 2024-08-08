using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        [Column("ProductID", TypeName = "bigint")]
        public long ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductDescription { get; set; }

        [StringLength(50)]
        public string ProductFinish { get; set; }

        [Required]
        public decimal ProductStandardPrice { get; set; }

        public ProductLine? ProductLine { get; set; }

        public ICollection<ProducedIn> ProducedIns { get; set; }

        public ICollection<Uses> Uses { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; }
        public ICollection<ProductRawMaterial> ProductRawMaterials { get; set; }
    }
}
