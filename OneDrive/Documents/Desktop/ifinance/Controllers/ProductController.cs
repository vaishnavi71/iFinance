using Microsoft.AspNetCore.Mvc;
using S5G11_PVFAPP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace S5G11_PVFAPP.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDBContext _context;

        public ProductController(AppDBContext context)
        {
            _context = context;
        }   

        public async Task<IActionResult> Index()
        {
            var WorkCenters = await _context.Products.ToListAsync();
            return View(WorkCenters);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product WorkCenters)
        {
            _context.Products.Add(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");   
        }

        public async Task<IActionResult> Edit(long id)
        {
            var WorkCenters = await _context.Products.FindAsync(id);
            return View(WorkCenters);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product WorkCenters)
        {
            _context.Products.Update(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(long id)
        {
            var WorkCenters = await _context.Products.FindAsync(id);
            return View(WorkCenters);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Product WorkCenters)
        {
            _context.Products.Remove(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
