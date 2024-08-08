using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("order_line")]
    public class OrderLine
    {
        [Key]
        public long OrderLineID { get; set; }

        [Column("OrderID", TypeName = "bigint")]
        public long OrderID { get; set; }

        [Column("ProductID", TypeName = "bigint")]
        public long ProductID { get; set; }

        public int OrderedQuantity { get; set; }

        public Order Order { get; set; }

        public Product Product { get; set; }

    }
}
