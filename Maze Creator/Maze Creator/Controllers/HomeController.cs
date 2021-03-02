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
            var rand = new Random();

            for (int i = 0; i < Model.Length; i++)
            {
                for (int j = 0; j < Model.Width; j++)
                {
                    
                    bool flipCoin = rand.NextDouble() >= 0.5;

                    if (j == Model.Width - 1 && i == Model.Length - 1)
                    {
                        continue;
                    }
                    else if (j == Model.Width - 1)
                    {
                        Model.Grid[i][j].North = false;
                    }
                    else if (i == Model.Length - 1)
                    {
                        Model.Grid[i][j].East = false;
                    }
                    else if (flipCoin)
                    {
                        Model.Grid[i][j].North = false;
                    }
                    else if (!flipCoin)
                    {
                        Model.Grid[i][j].East = false;
                    }
                }
            }

            return View(Model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Robbie's Mazes";

            return View();
        }
    }
}