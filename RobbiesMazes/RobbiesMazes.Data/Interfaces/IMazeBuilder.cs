using RobbiesMazes.Data.Models;

namespace RobbiesMazes.Data.Interfaces
{
    interface IMazeBuilder
    {
        Maze BuildMaze(int length, int width);
    }
}
