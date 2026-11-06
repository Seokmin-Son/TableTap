using Microsoft.AspNetCore.Mvc;

namespace TableTap.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
