using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("product_line")]
    public class ProductLine
    {
        [Key]
        public long ProductLineID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductLineName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
