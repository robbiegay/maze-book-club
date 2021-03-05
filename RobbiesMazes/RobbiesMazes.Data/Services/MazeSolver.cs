using RobbiesMazes.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobbiesMazes.Data.Services
{
    class MazeSolver
    {
        public Maze ActiveMaze { get; private set; }
        public PersonInMaze Person { get; private set; }

        public MazeSolver(Maze maze, PersonInMaze person)
        {
            ActiveMaze = maze;
            Person = person;
        }

        public Direction FindPath()
        {

        }
    }
}
