using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RobbiesMazes.Data.Models;
using System.Diagnostics;

namespace RobbiesMazes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Robbie's Mazes";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
