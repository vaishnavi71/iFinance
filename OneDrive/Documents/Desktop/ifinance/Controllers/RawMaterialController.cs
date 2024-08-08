using Microsoft.AspNetCore.Mvc;
using S5G11_PVFAPP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace S5G11_PVFAPP.Controllers
{
    public class RawMaterialController : Controller
    {
        private readonly AppDBContext _context;

        public RawMaterialController(AppDBContext context)
        {
            _context = context;
        }   

        public async Task<IActionResult> Index()
        {
            var WorkCenters = await _context.RawMaterials.ToListAsync();
            return View(WorkCenters);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RawMaterial WorkCenters)
        {
            _context.RawMaterials.Add(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");   
        }

        public async Task<IActionResult> Edit(long id)
        {
            var WorkCenters = await _context.RawMaterials.FindAsync(id);
            return View(WorkCenters);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RawMaterial WorkCenters)
        {
            _context.RawMaterials.Update(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(long id)
        {
            var WorkCenters = await _context.RawMaterials.FindAsync(id);
            return View(WorkCenters);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(RawMaterial WorkCenters)
        {
            _context.RawMaterials.Remove(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
