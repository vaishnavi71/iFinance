using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        [Column("EmployeeId", TypeName = "bigint")]
        public long EmployeeId { get; set; }

        [Column("SupervisorId", TypeName = "bigint")]
        public Employee? SupervisorId { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string EmployeeAddress { get; set; }

        public ICollection<HasSkill> HasSkills { get; set; }
    }
}
