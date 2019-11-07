using MarsRover.Enums;
using System.Linq;
using Xunit;

namespace MarsRover.Test
{
    public class MarsRoverTest
    {
        [Theory]
        [InlineData(5, 5)]
        [InlineData(10, 10)]
        public void Should_Be_True_Coordinates_With_Plateau(int x, int y)
        {
            var plateau = new Plateau(x, y);
            x += 1;
            y += 1;
            Assert.True(x * y == plateau.Points.Count);
        }

        [Theory]
        [InlineData(1, 2, Direction.North, "LMLMLMLMM", "1 3 N")]
        [InlineData(3, 3, Direction.East, "MMRMMRMRRM", "5 1 E")]
        public void Should_Be_Valid_Coordinate_Rover(int x, int y, Direction direction, string commands, string result)
        {
            var plateau = new Plateau(5, 5);
            plateau.AddRover(x, y, direction, commands);
            plateau.Run();
            var roverResult =  plateau.Rovers.First().ToString();

            Assert.True(result == roverResult);
        }
    }
}
