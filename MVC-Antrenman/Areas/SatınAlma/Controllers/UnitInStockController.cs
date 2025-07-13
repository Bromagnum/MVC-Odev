using Microsoft.AspNetCore.Mvc;
using MVC_Antrenman.Models.Models;

namespace MVC_Antrenman.Areas.SatınAlma.Controllers
{
    [Area("SatınAlma")]
    public class UnitInStockController : Controller
    {
        private readonly NorthwndContext _context;
        public UnitInStockController(NorthwndContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Model = _context.Products.ToList();
            return View(Model);
        }
    }
}
