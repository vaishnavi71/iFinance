namespace S5G11_PVFAPP.Models
{
    public class EmployeeSkillViewModel
    {
        public long EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public Employee SupervisorId { get; set; }
        public Skills SelectedSkill { get; set; }
        public string SkillName { get; set; }
    }
}
