using Microsoft.AspNetCore.Mvc;

namespace ToDo.Controllers
{
    public class FinancasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
