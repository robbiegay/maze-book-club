using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maze_Creator.Models
{
    public class Maze
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public List<List<Cell>> Grid { get; set; }

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