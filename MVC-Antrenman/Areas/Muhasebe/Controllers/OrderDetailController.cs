using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Antrenman.Models.Models;

namespace MVC_Antrenman.Areas.Muhasebe.Controllers
{
    [Area("Muhasebe")]
    public class OrderDetailController : Controller
    {
        
        private readonly NorthwndContext _context;

        public OrderDetailController(NorthwndContext context)
        {
            _context = context;
        }
        // GET: OrderDetailController
        public IActionResult Index()
        {
            var Model = _context.OrderDetails.ToList();

            return View(Model);
        }

        // GET: OrderDetailController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderDetailController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderDetailController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderDetailController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderDetailController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderDetailController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderDetailController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
