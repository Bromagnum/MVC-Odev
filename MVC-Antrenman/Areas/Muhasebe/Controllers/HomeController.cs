using Microsoft.AspNetCore.Mvc;

namespace MVC_Antrenman.Areas.Muhasebe.Controllers
{
    [Area("Muhasebe")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
