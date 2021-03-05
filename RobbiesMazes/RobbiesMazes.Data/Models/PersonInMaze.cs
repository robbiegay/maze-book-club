using System;
using System.Collections.Generic;
using System.Text;

namespace RobbiesMazes.Data.Models
{
    class PersonInMaze
    {
        public Location CurrentLocation { get; set; }
        public List<Location> Path { get; set; }
        public Direction DirectionFacing { get; set; }

        public PersonInMaze()
        {
            DirectionFacing = Direction.North;
            CurrentLocation = new Location(0, 0);
            Path = new List<Location>();
            Path.Add(CurrentLocation);
        }
    }
}
