using System;
using System.Collections.Generic;
using System.Text;

namespace RobbiesMazes.Data.Models
{
    public class Location
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Location(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
