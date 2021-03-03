using Maze_Creator.Interfaces;
using Maze_Creator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maze_Creator.Algorithms
{
    public class BinaryTree : MazeBuilder
    {
        public Maze BuildMaze(int length, int width)
        {
            var maze = new Maze(length, width);
            var rand = new Random();

            for (int i = 0; i < maze.Length; i++)
            {
                for (int j = 0; j < maze.Width; j++)
                {
                    bool flipCoin = rand.NextDouble() >= 0.5;

                    if (j == maze.Width - 1 && i == maze.Length - 1)
                    {
                        continue;
                    }
                    else if (j == maze.Width - 1)
                    {
                        maze.Grid[i][j].North = false;
                    }
                    else if (i == maze.Length - 1)
                    {
                        maze.Grid[i][j].East = false;
                    }
                    else if (flipCoin)
                    {
                        maze.Grid[i][j].North = false;
                    }
                    else if (!flipCoin)
                    {
                        maze.Grid[i][j].East = false;
                    }
                }
            }

            return maze;
        }
    }
}