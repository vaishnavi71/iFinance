using Microsoft.AspNetCore.Mvc;
using S5G11_PVFAPP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace S5G11_PVFAPP.Controllers
{
    public class SkillsController : Controller
    {
        private readonly AppDBContext _context;

        public SkillsController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var skills = await _context.Skills.ToListAsync();
            //ViewBag.Skills = skills != null ? new SelectList(skills, "SkillID", "SkillName") : null;
            return View(skills);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Skills skills)
        {
            _context.Skills.Add(skills);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");   
        }

        public async Task<IActionResult> Edit(long id)
        {
            var skills = await _context.Skills.FindAsync(id);
            return View(skills);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Skills skills)
        {
            _context.Skills.Update(skills);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(long id)
        {
            var skills = await _context.Skills.FindAsync(id);
            return View(skills);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Skills skills)
        {
            _context.Skills.Remove(skills);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
