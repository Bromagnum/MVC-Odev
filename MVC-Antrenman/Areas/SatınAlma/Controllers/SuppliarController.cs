using Microsoft.AspNetCore.Mvc;
using MVC_Antrenman.Models.Models;

namespace MVC_Antrenman.Areas.SatınAlma.Controllers
{
    [Area("SatınAlma")]
    public class SuppliarController : Controller
    {
        private readonly NorthwndContext _context;
        public SuppliarController(NorthwndContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Model = _context.Suppliers.ToList();
            return View(Model);
        }
    }
}
