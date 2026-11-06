using Microsoft.AspNetCore.Mvc;

namespace TableTap.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
