using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S5G11_PVFAPP.Models
{
    [Table("skill")]
    public class Skills
    {
        [Key]
        [Column("SkillID", TypeName = "bigint")]
        public long SkillID { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Skill_descr", TypeName = "nvarchar(50)")]
        public string SkillDescr { get; set; }


    }
}
