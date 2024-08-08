using Microsoft.AspNetCore.Mvc;
using S5G11_PVFAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace S5G11_PVFAPP.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDBContext _context;

        public CustomerController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var customers = await _context.Customers.ToListAsync();
            return View(customers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(long id)
        {
            var customer = await _context.Customers.FindAsync(id);
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Customer customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(long id)
        {
            var customer = await _context.Customers.FindAsync(id);
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
