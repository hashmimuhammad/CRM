using Microsoft.AspNetCore.Mvc;

namespace Dashboard.View.Controllers
{
    public class AnalyticsController : Controller
    {
        public IActionResult Analytics()
        {
            return View();
        }
    }
}
