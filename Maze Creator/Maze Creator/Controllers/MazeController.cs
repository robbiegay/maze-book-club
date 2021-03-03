using Maze_Creator.Algorithms;
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

        public ActionResult Grid()
        {
            ViewBag.Title = "Grid Maze";
            ViewBag.Message = ""
                + "<p>A plain, 4x4 grid. Shows the default state of the Maze Builder - before any North or East walls are carved away.</p>";

            var Model = new Maze(4, 4);

            return View("Maze", Model);
        }

        public ActionResult BinaryTree()
        {
            ViewBag.Title = "Binary Tree Maze";
            ViewBag.Message = ""
                + "<p>Below is my chapter 1 implementation of the 'Binary Tree' maze building algorithm. The algorithm follows these rules:</p>"
                + "<ol><li>Start in the bottom left cell. Visit each cell only once - traversing each row left to right before moving to the row above and starting again at the left most cell.</li>"
                + "<li>If the cell visited is the top right cell, do nothing.</li>"
                + "<li>If the cell visited is in the far-right row, carve North.</li?"
                + "<li>If the cell visited is in the top row, carve East.</li>"
                + "<li>For all other cells, a true/false value is generated randomly (coin flip) to determine if you carve North or East.</li></ol>"
                + "<p>The binary tree maze building algorithm has a bias towards mazes with long corridors on the top and right sides. "
                + "If starting in the bottom left cell, the solution to the maze trends in a northeastern direction. This bias disappears if starting in the top right.</p>"
                + "<p>This algorithm produces a 'perfect maze' - where each cell can be reached by only one route. There are no loop or intersecting paths.</p>"
                + "<p>Since each cell is visited only once, this maze building algorithm has a time complexity of O(n) - constant time.</p>"
                + "<p>The maze is dynamically generated. Refresh the page to load a new page.<p>";

            var mazeBuilder = new BinaryTree();
            var Model = mazeBuilder.BuildMaze(12, 12);

            return View("Maze", Model);
        }

        public ActionResult Sidewinder()
        {
            var mazeBuilder = new BinaryTree();
            var Model = mazeBuilder.BuildMaze(2, 2);

            return View("Maze", Model);
        }
    }
}