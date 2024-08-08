using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("vendor")]
    public class Vendor
    {
        [Key]
        [Column("VendorlID", TypeName = "bigint")]
        public long VendorId { get; set; }

        public string VendorName { get; set; }

        public string VendorAddress { get; set; }

        public ICollection<Supplies> Supplies { get; set; }

        public ICollection<VendorRawMaterial> VendorRawMaterials { get; set; }
    }
}
