using Microsoft.AspNetCore.Mvc;
using S5G11_PVFAPP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace S5G11_PVFAPP.Controllers
{
    public class SalesPersonController : Controller
    {
        private readonly AppDBContext _context;

        public SalesPersonController(AppDBContext context)
        {
            _context = context;
        }   

        public async Task<IActionResult> Index()
        {
            var WorkCenters = await _context.Sales.ToListAsync();
            return View(WorkCenters);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SalesPerson WorkCenters)
        {
            _context.Sales.Add(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");   
        }

        public async Task<IActionResult> Edit(int id)
        {
            var WorkCenters = await _context.Sales.FindAsync(id);
            return View(WorkCenters);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SalesPerson WorkCenters)
        {
            _context.Sales.Update(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var WorkCenters = await _context.Sales.FindAsync(id);
            return View(WorkCenters);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(SalesPerson WorkCenters)
        {
            _context.Sales.Remove(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
