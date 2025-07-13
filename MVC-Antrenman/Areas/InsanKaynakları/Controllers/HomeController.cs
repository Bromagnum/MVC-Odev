using Microsoft.AspNetCore.Mvc;
using MVC_Antrenman.Models.Models;

namespace MVC_Antrenman.Areas.InsanKaynakları.Controllers
{
    [Area("InsanKaynakları")]
    public class HomeController : Controller
    {
        private readonly NorthwndContext _context;

        public HomeController(NorthwndContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Model = _context.Employees.ToList();
            return View(Model);
        }
    }
}
