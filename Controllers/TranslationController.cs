using Microsoft.AspNetCore.Mvc;

namespace TableTap.Controllers
{
    public class TranslationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
