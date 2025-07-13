using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Antrenman.Models.Models;

namespace MVC_Antrenman.Areas.Muhasebe.Controllers
{
    [Area("Muhasebe")]
    public class OrderController : Controller
    {
        private readonly NorthwndContext _context;

        public OrderController(NorthwndContext context)
        {
            _context = context;
        }
        // GET: OrderController
        public IActionResult Index()
        {
          var  Orders = _context.Orders.ToList();
            return View(Orders);
        }

        // GET: OrderController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
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

        // GET: OrderController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
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
