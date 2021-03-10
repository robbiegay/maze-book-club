using Microsoft.AspNetCore.Mvc;
using RobbiesMazes.Data.Algorithms;
using RobbiesMazes.Data.Models;
using RobbiesMazes.Data.Services;
using System.Collections.Generic;

namespace RobbiesMazes.Web.Controllers
{
    public class MazeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Mazes";

            return View();
        }

        public IActionResult Grid()
        {
            ViewData["Title"] = "Grid Maze";
            ViewData["Message"] = ""
                + "<p>A plain, 4x4 grid. Shows the default state of the Maze Builder - before any North or East walls are carved away.</p>";

            // Start timer
            var mazeTimer = new AlgorithmTimer();
            mazeTimer.Start();
            // Build maze
            var Model = new Maze(4, 4);
            // Stop timer and add time value to model
            mazeTimer.Stop();
            Model.TimeToGenerateTicks = mazeTimer.ElapsedTimeTicks();
            Model.Solution = new List<Direction>();

            return View("Maze", Model);
        }

        public IActionResult BinaryTree()
        {
            ViewData["Title"] = "Binary Tree Maze";
            ViewData["Message"] = ""
                + "<p>Below is my chapter 1 implementation of the 'Binary Tree' maze building algorithm. The algorithm follows these rules:</p>"
                + "<ol><li>Start in the bottom left cell. Visit each cell only once - traversing each row left to right before moving to the row above and starting again at the left most cell.</li>"
                + "<li>If the cell visited is the top right cell, do nothing.</li>"
                + "<li>If the cell visited is in the far-right row, carve North.</li>"
                + "<li>If the cell visited is in the top row, carve East.</li>"
                + "<li>For all other cells, a true/false value is generated randomly (coin flip) to determine if you carve North or East.</li></ol>"
                + "<p>The binary tree maze building algorithm has a bias towards mazes with long corridors on the top and right sides. "
                + "If starting in the bottom left cell, the solution to the maze trends in a northeastern direction. This bias disappears if starting in the top right.</p>"
                + "<p>This algorithm produces a 'perfect maze' - where each cell can be reached by only one route. There are no loops or intersecting paths.</p>"
                + "<p>Since each cell is visited only once, this maze building algorithm has a time complexity of O(n) - linear time.</p>"
                + "<p>The maze is dynamically generated. Refresh the page to generate a new maze.</p>";

            // Start timer
            var mazeTimer = new AlgorithmTimer();
            mazeTimer.Start();
            // Build maze
            var mazeBuilder = new BinaryTree();
            var Model = mazeBuilder.BuildMaze(12, 12);
            // Stop timer and add time value to model
            mazeTimer.Stop();
            Model.TimeToGenerateTicks = mazeTimer.ElapsedTimeTicks();

            // Start timer
            var solutionTimer = new AlgorithmTimer();
            solutionTimer.Start();
            // Solve maze
            var mazeSolver = new MazeSolver();
            Model.Solution = mazeSolver.Solve(Model);
            // Stop timer and add time value to model
            solutionTimer.Stop();
            Model.TimeToSolveTicks = solutionTimer.ElapsedTimeTicks();

            return View("Maze", Model);
        }

        public IActionResult Sidewinder()
        {
            ViewData["Title"] = "Sidewinder Maze";
            ViewData["Message"] = ""
                + "<p>Below is my chapter 1 implementation of the 'Sidewinder' maze building algorithm. The algorithm follows these rules:</p>"
                + "<ol><li>Start in the bottom left cell. Visit each cell only once - traversing each row left to right before moving to the row above and starting again at the left most cell.</li>"
                + "<li>If the cell visited is the top right cell, do nothing.</li>"
                + "<li>If the cell visited is in the top row, carve East.</li>"
                + "<li>For all other cells, a true/false value is generated randomly (coin flip). Like the Binary Tree algorithm, one side of the coin carves East. "
                + "If the coin lands on the other side OR if the cell is in the far-right row, the algorithm will look back on the consecutive East running cells and pick one cell at random to carve North.</li></ol>"
                + "<p>The sidewinder maze building algorithm has less bias than the binary tree maze building algorithm. "
                + "There is no longer a straight, northern passage on the right edge of the maze. Both the binary tree and sidewinder algorithms do have a bias involving a straight eastern row along to top row.</p>"
                + "<p>This algorithm produces a 'perfect maze' - where each cell can be reached by only one route. There are no loops or intersecting paths.</p>"
                + "<p>Since each cell is visited only once, this maze building algorithm has a time complexity of O(n) - linear time.</p>"
                + "<p>The maze is dynamically generated. Refresh the page to generate a new maze.</p>";

            // Start timer
            var mazeTimer = new AlgorithmTimer();
            mazeTimer.Start();
            // Build maze
            var mazeBuilder = new Sidewinder();
            var Model = mazeBuilder.BuildMaze(12, 12);
            // Stop timer and add time value to model
            mazeTimer.Stop();
            Model.TimeToGenerateTicks = mazeTimer.ElapsedTimeTicks();

            // Start timer
            var solutionTimer = new AlgorithmTimer();
            solutionTimer.Start();
            // Solve maze
            var mazeSolver = new MazeSolver();
            Model.Solution = mazeSolver.Solve(Model);
            // Stop timer and add time value to model
            solutionTimer.Stop();
            Model.TimeToSolveTicks = solutionTimer.ElapsedTimeTicks();

            return View("Maze", Model);
        }
    }
}
