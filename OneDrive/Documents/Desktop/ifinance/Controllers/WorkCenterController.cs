using Microsoft.AspNetCore.Mvc;
using S5G11_PVFAPP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace S5G11_PVFAPP.Controllers
{
    public class WorkCentersController : Controller
    {
        private readonly AppDBContext _context;

        public WorkCentersController(AppDBContext context)
        {
            _context = context;
        }   

        public async Task<IActionResult> Index()
        {
            var WorkCenters = await _context.WorkCenters.ToListAsync();
            return View(WorkCenters);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(WorkCenter WorkCenters)
        {
            _context.WorkCenters.Add(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");   
        }

        public async Task<IActionResult> Edit(long id)
        {
            var WorkCenters = await _context.WorkCenters.FindAsync(id);
            return View(WorkCenters);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(WorkCenter WorkCenters)
        {
            _context.WorkCenters.Update(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(long id)
        {
            var WorkCenters = await _context.WorkCenters.FindAsync(id);
            return View(WorkCenters);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(WorkCenter WorkCenters)
        {
            _context.WorkCenters.Remove(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
