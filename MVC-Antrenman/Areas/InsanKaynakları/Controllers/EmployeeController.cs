using Microsoft.AspNetCore.Mvc;
using MVC_Antrenman.Models.Models;
using MVC_Antrenman.Repositories.Abstracts;
using MVC_Antrenman.Repositories.Concretes;
namespace MVC_Antrenman.Areas.InsanKaynakları.Controllers
{
    [Area("InsanKaynakları")]
    public class EmployeeController : Controller
    {
        private readonly NorthwndContext _context;

        public EmployeeController(NorthwndContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            var Model = _context.Employees.ToList();
            return View(Model);
        }

        public IActionResult CreateEmployee()
        {
            
            return View();
        }
    }
}
