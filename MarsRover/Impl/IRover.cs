using MarsRover.Enums;

namespace MarsRover.Impl
{
    interface IRover
    {
        Point Point { get; }
        Direction Direction { get; }
        string Commands { get; }
        void Run();
    }
}
