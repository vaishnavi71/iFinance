using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("works_in")]
    public class WorksIn
    {
        [ForeignKey("Employee")]
        [Column("EmployeeID", TypeName = "bigint")]
        public long EmployeeID { get; set; }

        [ForeignKey("WorkCenter")]
        [Column("WorkCenterID", TypeName = "bigint")]
        public long WorkCenterID { get; set; }

        public Employee Employee { get; set; }

        public WorkCenter WorkCenter { get; set; }

    }
}
