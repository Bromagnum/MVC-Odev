using Microsoft.AspNetCore.Mvc;

namespace MVC_Antrenman.Areas.SatınAlma.Controllers
{
    [Area("SatınAlma")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
