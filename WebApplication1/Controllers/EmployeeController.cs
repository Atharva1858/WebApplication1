using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly MvcDemo context;

        public EmployeeController(MvcDemo context) 
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result = context.Employees.ToList();
            return View(result);
        }
    }
}
