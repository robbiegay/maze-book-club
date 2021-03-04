using System.Web.Mvc;

namespace Maze_Creator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";
            ViewBag.Message = "Robbie's Mazes";

            return View();
        }
    }
}