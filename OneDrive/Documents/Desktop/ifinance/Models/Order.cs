using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("order")]
    public class Order
    {
        [Key]
        public long OrderID { get; set; }
        public DateTime OrderDate { get; set; }

        [Column("CustomerId", TypeName = "bigint")]
        public long? CustomerId { get; set; }

        public Customer? Customer { get; set; }

    }
}
