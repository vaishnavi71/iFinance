using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("work_center")]
    public class WorkCenter
    {
        [Key]
        [Column("WorkCenterId", TypeName = "bigint")]
        public long WorkCenterId { get; set; }

        [Required]
        public string WorkCenterName { get; set; }

        public ICollection<ProducedIn> ProducedIns { get; set; }
    }
}
