using Maze_Creator.Data.Interfaces;
using Maze_Creator.Data.Models;
using System;

namespace Maze_Creator.Data.Algorithms
{
    public class Sidewinder : IMazeBuilder
    {
        public Maze BuildMaze(int length, int width)
        {
            var maze = new Maze(length, width);
            var rand = new Random();

            for (int i = 0; i < maze.Length; i++)
            {
                int runStart = 0;

                for (int j = 0; j < maze.Width; j++)
                {
                    bool flipCoin = rand.NextDouble() >= 0.5;

                    if (j == maze.Width - 1 && i == maze.Length - 1)
                    {
                        continue;
                    }
                    else if (i == maze.Length - 1)
                    {
                        maze.Grid[i][j].East = false;
                    }
                    else if (j == maze.Width - 1 || flipCoin)
                    {
                        int x = rand.Next(runStart, j + 1);
                        maze.Grid[i][x].North = false;
                        runStart = j + 1;
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