using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Antrenman.Models;
using MVC_Antrenman.Models.Models;

namespace MVC_Antrenman.Controllers
{
    public class HomeController : Controller
    {

        private readonly NorthwndContext _context;

        public HomeController(NorthwndContext context)
        {
            _context = context;


        }

       

        public IActionResult Index()
        {
           ViewBag.Products = _context.Products.ToList();
            //ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
