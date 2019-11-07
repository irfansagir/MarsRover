using System;

namespace MarsRover
{
    public class Point : IEquatable<Point>
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Point);
        }

        public bool Equals(Point point)
        {
            if (point is null)
            {
                return false;
            }

            if (Object.ReferenceEquals(this, point))
            {
                return true;
            }

            if (this.GetType() != point.GetType())
            {
                return false;
            }

            return (X == point.X) && (Y == point.Y);
        }

        public override int GetHashCode()
        {
            return X * 0x00010000 + Y;
        }

        public static bool operator ==(Point leftPoint, Point rightPoint)
        {
            if (leftPoint is null)
            {
                if (rightPoint is null)
                {
                    return true;
                }

                return false;
            }

            return leftPoint.Equals(rightPoint);
        }

        public static bool operator !=(Point leftPoint, Point rightPoint)
        {
            return !(leftPoint == rightPoint);
        }
    }
}
