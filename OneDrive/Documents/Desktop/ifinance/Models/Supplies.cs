using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("supplies")]
    public class Supplies
    {
        [Key]
        public int Id { get; set; }

        [Column("VendorlID", TypeName = "bigint")]
        public long VendorlID { get; set; }

        [Column("MaterialID", TypeName = "int")]
        public int MaterialID { get; set; }

        public float SupplyUnitPrice { get; set; }

        public RawMaterial RawMaterial { get; set; }
        public Vendor Vendor { get; set; } 

    }
}
