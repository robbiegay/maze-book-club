using Maze_Creator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Maze_Creator.Controllers
{
    public class MazeController : Controller
    {
        // GET: Maze
        public ActionResult Index()
        {
            ViewBag.Title = "Mazes";

            return View();
        }

        public ActionResult GridMaze()
        {
            ViewBag.Title = "Grid Maze";
            ViewBag.Message = "A plain, 4x4 grid. Shows the default state of the Maze Builder - before any North or East walls are carved away.";

            var Model = new Maze(4, 4);

            return View("Maze", Model);
        }

        public ActionResult BinaryTreeMaze()
        {
            ViewBag.Title = "Binary Tree Maze";
            ViewBag.Message = "My chapter 1 implementation of the 'Binary Tree' maze building algorithm. The algorithm follow these rules: 1. It starts in the bottom left cell, it moves left to right, then proceeds to the next row. Each cell is visited only once (O(n) - Constant Time). 2. If the cell visited is the top right cell, do nothing. 3. If the cell visited is in the far right row, the only option is to carve North. 4. If the cell visited is in the top row, the only option is the carve East. 5. For all other cells, a coin flip occurs to determine if you should carve North or East.";

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

            return View("Maze", Model);
        }
    }
}