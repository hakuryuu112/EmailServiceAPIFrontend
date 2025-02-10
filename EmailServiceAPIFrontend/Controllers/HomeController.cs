using EmailServiceAPIFrontend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmailServiceAPIFrontend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
