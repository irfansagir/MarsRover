using MarsRover.Enums;
using MarsRover.Impl;

namespace MarsRover
{
    class Rover : IRover
    {
        public Point Point { get; private set; }
        public Direction Direction { get; private set; }
        public IMoveManager MoveManager { get; }
        public string Commands { get; }

        public Rover(Point point, Direction direction, string commands, IMoveManager moveManager)
        {
            Point = point;
            Direction = direction;
            MoveManager = moveManager;
            Commands = commands;
        }

        public void Run()
        {
            foreach (var command in Commands)
            {
                switch (command)
                {
                    case ('L'):
                        Direction = MoveManager.TurnLeft(this);
                        break;
                    case ('R'):
                        Direction = MoveManager.TurnRight(this);
                        break;
                    case ('M'):
                        Point = MoveManager.Move(this);
                        break;
                }
            }
        }

        public override string ToString()
            => $"{Point.X} {Point.Y} {Direction.ToString()[0]}";
    }
}
