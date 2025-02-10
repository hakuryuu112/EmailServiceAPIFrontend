using Microsoft.AspNetCore.Mvc;

namespace EmailServiceAPIFrontend.Controllers
{
    public class KPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
