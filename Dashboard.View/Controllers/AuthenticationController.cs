using Microsoft.AspNetCore.Mvc;

namespace Dashboard.View.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
