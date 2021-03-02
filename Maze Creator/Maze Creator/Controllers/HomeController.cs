using Maze_Creator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Maze_Creator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Model = new Maze(4, 4);

            return View(Model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Robbie's Mazes";

            return View();
        }
    }
}