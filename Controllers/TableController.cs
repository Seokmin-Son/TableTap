using Microsoft.AspNetCore.Mvc;

namespace TableTap.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
