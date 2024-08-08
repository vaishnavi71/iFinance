using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("raw_material")]
    public class RawMaterial
    {
        [Key]
        [Column("MaterialID", TypeName = "int")]
        public int MaterialID { get; set; }

        public String MaterialName{ get; set; }

        public float MaterialStandardCost { get; set; }

        public string UnitOfMeasure { get; set; }

        public ICollection<Uses> Uses { get; set; }

        public ICollection<Supplies> Supplies { get; set; }
        public ICollection<VendorRawMaterial> VendorRawMaterials { get; set; }
        public ICollection<ProductRawMaterial> ProductRawMaterials { get; set; }
    }
}
