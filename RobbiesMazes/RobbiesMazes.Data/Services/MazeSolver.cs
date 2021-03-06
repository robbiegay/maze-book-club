using RobbiesMazes.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobbiesMazes.Data.Services
{
    public class MazeSolver
    {
        public List<Direction> Solve(Maze maze)
        {
            var forward = Direction.North;
            var left = Direction.West;
            var right = Direction.East;

            bool leftWall = true;
            bool frontWall = true;

            var path = new List<Direction>();
            int row = 0;
            int column = 0;

            bool mazeSolved = false;

            while (!mazeSolved)
            {
                switch (forward)
                {
                    case Direction.North:
                        leftWall = column == 0 || maze.Grid[row][column - 1].East;
                        frontWall = maze.Grid[row][column].North;
                        break;
                    case Direction.East:
                        leftWall = maze.Grid[row][column].North;
                        frontWall = maze.Grid[row][column].East;
                        break;
                    case Direction.South:
                        leftWall = maze.Grid[row][column].East;
                        frontWall = row == 0 || maze.Grid[row - 1][column].North;
                        break;
                    case Direction.West:
                        leftWall = row == 0 || maze.Grid[row - 1][column].North;
                        frontWall = column == 0 || maze.Grid[row][column - 1].East;
                        break;
                }
                

                if (leftWall)
                {
                    if (frontWall)
                    {
                        TurnRight(ref left, ref forward, ref right);
                    }
                    else
                    {
                        Move(ref path, ref forward, ref row, ref column);
                    }
                }
                else
                {
                    TurnLeft(ref left, ref forward, ref right);
                    Move(ref path, ref forward, ref row, ref column);
                }

                if (row == maze.Length - 1 && column == maze.Width - 1)
                    mazeSolved = true;
            }

            return path;
        }

        private void Move(ref List<Direction> path, ref Direction f, ref int row, ref int column)
        {
            path.Add(f);

            switch (f)
            {
                case Direction.North:
                    row++;
                    break;
                case Direction.East:
                    column++;
                    break;
                case Direction.South:
                    row--;
                    break;
                case Direction.West:
                    column--;
                    break;
            }
        }

        private void TurnLeft(ref Direction l, ref Direction f, ref Direction r)
        {
            switch (f)
            {
                case Direction.North:
                    f = Direction.West;
                    l = Direction.South;
                    r = Direction.North;
                    break;
                case Direction.East:
                    f = Direction.North;
                    l = Direction.West;
                    r = Direction.East;
                    break;
                case Direction.South:
                    f = Direction.East;
                    l = Direction.North;
                    r = Direction.South;
                    break;
                case Direction.West:
                    f = Direction.South;
                    l = Direction.East;
                    r = Direction.West;
                    break;
            }
        }

        private void TurnRight(ref Direction l, ref Direction f, ref Direction r)
        {
            switch (f)
            {
                case Direction.North:
                    f = Direction.East;
                    l = Direction.North;
                    r = Direction.South;
                    break;
                case Direction.East:
                    f = Direction.South;
                    l = Direction.East;
                    r = Direction.West;
                    break;
                case Direction.South:
                    f = Direction.West;
                    l = Direction.South;
                    r = Direction.North;
                    break;
                case Direction.West:
                    f = Direction.North;
                    l = Direction.West;
                    r = Direction.East;
                    break;
            }
        }
    }
}
