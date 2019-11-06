using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    class Plateau
    {
        public List<Point> Points { get; } = new List<Point>();
        public int X { get; }
        public int Y { get; }

        public Plateau(int x, int y)
        {
            X = x;
            Y = y;

            DrawPlateau();
        }

        private void DrawPlateau()
        {
            for (int i = 0; i <= X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    Points.Add(new Point(i, j));
                }
            }
        }
    }
}
