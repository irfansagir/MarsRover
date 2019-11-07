using MarsRover.Enums;

namespace MarsRover.Impl
{
    public interface IMoveManager
    {
        Direction TurnLeft(IRover rover);
        Direction TurnRight(IRover rover);
        Point Move(IRover rover);
    }
}
