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

            // test data
            // Test path
            var p1 = Direction.East;
            var p2 = Direction.North;
            var p3 = Direction.West;
            var p4 = Direction.North;
            var p5 = Direction.South;

            Solution = new List<Direction>()
            {
                p1,
                p2,
                p3,
                p4,
                p5
            };
        }
    }
}
