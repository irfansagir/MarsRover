using MarsRover.Enums;
using MarsRover.Impl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    class MoveManager : IMoveManager
    {
        public IEnumerable<Point> Points { get; set; }

        public MoveManager(IEnumerable<Point> points)
        {
            Points = points;
        }

        public Direction TurnLeft(IRover rover)
        {
            var direction = rover.Direction;

            switch (rover.Direction)
            {
                case Direction.North:
                    direction = Direction.West;
                    break;
                case Direction.East:
                    direction = Direction.North;
                    break;
                case Direction.South:
                    direction = Direction.East;
                    break;
                case Direction.West:
                    direction = Direction.South;
                    break;
            }

            return direction;
        }

        public Direction TurnRight(IRover rover)
        {
            var direction = rover.Direction;

            switch (rover.Direction)
            {
                case Direction.North:
                    direction = Direction.East;
                    break;
                case Direction.East:
                    direction = Direction.South;
                    break;
                case Direction.South:
                    direction = Direction.West;
                    break;
                case Direction.West:
                    direction = Direction.North;
                    break;
            }

            return direction;
        }

        public Point Move(IRover rover)
        {
            var x = rover.Point.X;
            var y = rover.Point.Y;

            switch (rover.Direction)
            {
                case Direction.North:
                    y++;
                    break;
                case Direction.East:
                    x++;
                    break;
                case Direction.South:
                    y--;
                    break;
                case Direction.West:
                    x--;
                    break;
            }

            return Points.FirstOrDefault(p => p.X == x && p.Y == y) ?? throw new Exception("Rover outside the plateau!");
        }
    }
}
