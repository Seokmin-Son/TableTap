using Microsoft.AspNetCore.Mvc;

namespace TableTap.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
