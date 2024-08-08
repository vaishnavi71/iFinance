using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("produced_in")]
    public class ProducedIn
    {
        [Column("WorkCenterId", TypeName = "bigint")]
        public long WorkCenterId { get; set; }

        [Column("ProductID", TypeName = "bigint")]
        public long ProductID { get; set; }

        public WorkCenter WorkCenter { get; set; }

        public Product Product { get; set; }
    }
}
