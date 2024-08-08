using Microsoft.AspNetCore.Mvc;
using S5G11_PVFAPP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace S5G11_PVFAPP.Controllers
{
    public class VendorController : Controller
    {
        private readonly AppDBContext _context;

        public VendorController(AppDBContext context)
        {
            _context = context;
        }   

        public async Task<IActionResult> Index()
        {
            var WorkCenters = await _context.Vendors.ToListAsync();
            return View(WorkCenters);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Vendor WorkCenters)
        {
            _context.Vendors.Add(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");   
        }

        public async Task<IActionResult> Edit(long id)
        {
            var WorkCenters = await _context.Vendors.FindAsync(id);
            return View(WorkCenters);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Vendor WorkCenters)
        {
            _context.Vendors.Update(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(long id)
        {
            var WorkCenters = await _context.Vendors.FindAsync(id);
            return View(WorkCenters);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Vendor WorkCenters)
        {
            _context.Vendors.Remove(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
