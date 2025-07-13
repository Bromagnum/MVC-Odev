using Microsoft.AspNetCore.Mvc;
using MVC_Antrenman.Models.Models;

namespace MVC_Antrenman.Areas.Muhasebe.Controllers
{
    [Area("Muhasebe")]
    public class SalesByCategoryController : Controller
    {
        private readonly NorthwndContext _context;
        public SalesByCategoryController(NorthwndContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Model = _context.SalesByCategories.ToList();
            return View(Model);
        }
    }
}
