using Microsoft.AspNetCore.Mvc;
using MVC_Antrenman.Models.Models;

namespace MVC_Antrenman.Areas.SatınAlma.Controllers
{
    [Area("SatınAlma")]
    public class AllCategoryController : Controller
    {
        private readonly NorthwndContext _context;
        public AllCategoryController(NorthwndContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Model = _context.Categories.ToList();
            return View(Model);
        }
    }
}
