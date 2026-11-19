using Microsoft.AspNetCore.Mvc;
using TableTap.Models;

namespace TableTap.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ModelState.AddModelError("", "Account verification is not connected yet.");
            return View(model);
        }

    }
}
