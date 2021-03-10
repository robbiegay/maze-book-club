using RobbiesMazes.Data.Algorithms;
using RobbiesMazes.Data.Models;
using System.Collections.Generic;
using Xunit;

namespace RobbiesMazes.Data.Tests
{
    public class Algorithms_BinaryTreeShould
    {
        [Fact]
        public void BinaryTreeAlgorithm_BuildMaze_HasNoLoops()
        {
            // Arrange
            var binaryTreeMaze = new BinaryTree();
            Maze completedMaze;
            bool hasLoops = false;
            int length = 12;
            int width = 12;

            // Act
            completedMaze = binaryTreeMaze.BuildMaze(length, width);

            // Unit testing best practices dictates that you should avoid logic (for, if, etc) in unit tests
            // I feel as though it is unavoidable in this test
            for (int i = 0; i < completedMaze.Grid.Count; i++)
            {
                for (int j = 0; j < completedMaze.Grid[i].Count; j++)
                {
                    var cell = completedMaze.Grid[i][j];
                    
                    // Ignore final cell in top right corner
                    if (i == completedMaze.Grid.Count - 1 && j == completedMaze.Grid[i].Count - 1)
                        continue;
                    // If it finds a single loop, set hasLoops = true
                    else if (cell.North == cell.East)
                        hasLoops = true;
                }
            }

            // Assert
            Assert.False(hasLoops);
        }

        [Fact]
        public void BinaryTreeAlgorithm_BuildMaze_TopRowGoesEast()
        {
            // Arrange
            var binaryTreeMaze = new BinaryTree();
            Maze completedMaze;
            bool goesEast = true;
            int length = 12;
            int width = 12;
            int lastRow;

            // Act
            completedMaze = binaryTreeMaze.BuildMaze(length, width);
            lastRow = completedMaze.Grid.Count - 1;

            // Unit testing best practices dictates that you should avoid logic (for, if, etc) in unit tests
            // I feel as though it is unavoidable in this test
            for (int i = 0; i < completedMaze.Grid[lastRow].Count; i++)
            {
                var cell = completedMaze.Grid[lastRow][i];

                // Ignore final cell in top right corner
                if (i == completedMaze.Grid[lastRow].Count - 1)
                    continue;
                else if (cell.East != false)
                    goesEast = false;
            }
            
            // Assert
            Assert.True(goesEast);
        }

        [Fact]
        public void BinaryTreeAlgorithm_BuildMaze_LastColumnGoesNorth()
        {
            // Arrange
            var binaryTreeMaze = new BinaryTree();
            Maze completedMaze;
            bool goesNorth = true;
            int length = 12;
            int width = 12;

            // Act
            completedMaze = binaryTreeMaze.BuildMaze(length, width);

            // Unit testing best practices dictates that you should avoid logic (for, if, etc) in unit tests
            // I feel as though it is unavoidable in this test
            for (int i = 0; i < completedMaze.Grid.Count; i++)
            {
                var cell = completedMaze.Grid[i][completedMaze.Grid.Count - 1];

                // Ignore final cell in top right corner
                if (i == completedMaze.Grid.Count - 1)
                    continue;
                else if (cell.North != false)
                    goesNorth = false;
            }

            // Assert
            Assert.True(goesNorth);
        }

        [Fact]
        public void BinaryTreeAlgorithm_BuildMaze_TopRightCellHasNorthAndEastWalls()
        {
            // Arrange
            var binaryTreeMaze = new BinaryTree();
            Maze completedMaze;
            int length = 12;
            int width = 12;
            Cell topRightCell;

            // Act
            completedMaze = binaryTreeMaze.BuildMaze(length, width);
            topRightCell = completedMaze.Grid[completedMaze.Length - 1][completedMaze.Width - 1];

            // Assert
            Assert.True(topRightCell.North && topRightCell.East);
        }
    }
}
