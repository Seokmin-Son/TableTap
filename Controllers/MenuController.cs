using Microsoft.AspNetCore.Mvc;

namespace TableTap.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
