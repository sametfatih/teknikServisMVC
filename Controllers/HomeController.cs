using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace teknikServisMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}