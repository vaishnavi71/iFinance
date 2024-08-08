using Microsoft.AspNetCore.Mvc;
using S5G11_PVFAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace S5G11_PVFAPP.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDBContext _context;

        public EmployeeController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var employees = await _context.Employees.ToListAsync();
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public async Task<IActionResult> Create(EmployeeSkillViewModel employeeSkillViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var employee = new Employee
        //        {
        //            EmployeeName = employeeSkillViewModel.EmployeeName,
        //            EmployeeAddress = employeeSkillViewModel.EmployeeAddress,
        //            //SupervisorId = employeeSkillViewModel.SupervisorId
        //        };

        //        _context.Add(employee);

        //        //if (employeeSkillViewModel.SelectedSkill != null)
        //        //{
        //        //    var hasSkill = new HasSkill
        //        //    {
        //        //        Employee = employee,
        //        //        Skill = await _context.Skills.FindAsync(employeeSkillViewModel.SelectedSkill)
        //        //    };

        //        //    _context.Add(hasSkill);
        //        //}

        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    return View(employeeSkillViewModel);
        //}

        public async Task<IActionResult> Edit(long id)
        {
            var employee = await _context.Employees.FindAsync(id);
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee employees)
        {
            _context.Employees.Update(employees);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(long id)
        {
            var employee = await _context.Employees.FindAsync(id);
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Employee employee)
        {
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
