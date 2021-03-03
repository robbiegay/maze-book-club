using Maze_Creator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Creator.Interfaces
{
    interface MazeBuilder
    {
        Maze BuildMaze(int length, int width);
    }
}
