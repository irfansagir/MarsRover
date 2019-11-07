using MarsRover.Enums;

namespace MarsRover.Impl
{
    interface IMoveManager
    {
        Direction TurnLeft(IRover rover);
        Direction TurnRight(IRover rover);
        Point Move(IRover rover);
    }
}
