using Maze_Creator.Data.Models;

namespace Maze_Creator.Data.Interfaces
{
    interface IMazeBuilder
    {
        Maze BuildMaze(int length, int width);
    }
}
