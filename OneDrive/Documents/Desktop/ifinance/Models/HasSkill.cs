using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("has_skill")]
    public class HasSkill : DbContext
    {
        public long SkillID { get; set; }

        public long EmployeeID { get; set; }

        [ForeignKey(nameof(SkillID))]
        public Skills Skill { get; set; }

        [ForeignKey(nameof(EmployeeID))]
        public Employee Employee { get; set; }

        protected bool Equals(HasSkill other)
        {
            return SkillID == other.SkillID && EmployeeID == other.EmployeeID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SkillID, EmployeeID);
        }

    }
}
