using MarsRover.Enums;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var plateau = new Plateau(5, 5);

            plateau.AddRover(1, 2, Direction.North, "LMLMLMLMM");
            plateau.AddRover(3, 3, Direction.East, "MMRMMRMRRM");

            plateau.Run();
        }
    }
}
