using Microsoft.AspNetCore.Mvc;

namespace TableTap.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
