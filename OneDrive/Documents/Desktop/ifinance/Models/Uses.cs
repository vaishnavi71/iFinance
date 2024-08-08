using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("uses")]
    public class Uses
    {
        [ForeignKey("Material")]
        [Column("MaterialID", TypeName = "int")]
        public int MaterialID { get; set; }

        [ForeignKey("Product")]
        [Column("ProductID", TypeName = "bigint")]
        public long ProductID { get; set; }

        public RawMaterial Material { get; set; }
        public Product Product { get; set; }
    }

}
