using Microsoft.AspNetCore.Mvc;
using S5G11_PVFAPP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace S5G11_PVFAPP.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDBContext _context;

        public OrderController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _context.Order.ToListAsync();
            return View(orders);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Customers = await _context.Customers.Select(c => new SelectListItem
            {
                Value = c.CustomerId.ToString(),
                Text = c.CustomerName
            }).ToListAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
            _context.Order.Add(order);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
            //if (ModelState.IsValid)
            //{
            //    _context.Order.Add(order);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction("Index");
            //}
            //ViewBag.Customers = await _context.Customers.ToListAsync();
            //return View(order);
        }

        public async Task<IActionResult> Edit(long id)
        {
            var order = await _context.Order.FindAsync(id);
            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Order order)
        {
            _context.Order.Update(order);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(long id)
        {
            var order = await _context.Order.FindAsync(id);
            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Order WorkCenters)
        {
            _context.Order.Remove(WorkCenters);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
