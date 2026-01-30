using Microsoft.AspNetCore.Mvc;

namespace Dashboard.View.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult SalesReports()
        {
            return View();
        }
    }
}
