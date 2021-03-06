using System.Collections.Generic;

namespace RobbiesMazes.Data.Models
{
    public class Maze
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public List<List<Cell>> Grid { get; set; }
        public List<Direction> Solution { get; set; }

        public Maze(int length, int width)
        {
            var grid = new List<List<Cell>>();

            Length = length;
            Width = width;

            for (int i = 0; i < Length; i++)
            {
                var row = new List<Cell>();

                for (int j = 0; j < Width; j++)
                {
                    row.Add(new Cell());
                }

                grid.Add(row);
            }

            Grid = grid;
        }
    }
}
