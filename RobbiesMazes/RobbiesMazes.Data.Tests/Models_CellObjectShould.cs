using RobbiesMazes.Data.Models;
using Xunit;

namespace RobbiesMazes.Data.Tests
{
    public class Models_CellObjectShould
    {
        [Fact]
        public void CreateCell_EmptyConstructor_NorthIsTrue()
        {
            // Arrange
            Cell myCell;

            // Act
            myCell = new Cell();

            // Assert
            Assert.True(myCell.North);
        }

        [Fact]
        public void CreateCell_EmptyConstructor_EastIsTrue()
        {
            // Arrange
            Cell myCell;

            // Act
            myCell = new Cell();

            // Assert
            Assert.True(myCell.East);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void CreateCell_ValuesInConstructor_NorthCanBeSet(bool north, bool east)
        {
            // Arrange
            Cell myCell;

            // Act
            myCell = new Cell(north, east);

            // Assert
            Assert.Equal(north, myCell.North);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void CreateCell_ValuesInConstructor_EastCanBeSet(bool north, bool east)
        {
            // Arrange
            Cell myCell;

            // Act
            myCell = new Cell(north, east);

            // Assert
            Assert.Equal(east, myCell.East);
        }
    }
}
