using MarsRover.Enums;
using MarsRover.Impl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    class Plateau
    {
        public List<Point> Points { get; } = new List<Point>();
        public List<IRover> Rovers { get; } = new List<IRover>();
        public IMoveManager MoveManager { get; }
        public int X { get; }
        public int Y { get; }

        public Plateau(int x, int y)
        {
            X = x;
            Y = y;

            DrawPlateau();

            MoveManager = new MoveManager(Points);
        }

        private void DrawPlateau()
        {
            for (int i = 0; i <= X; i++)
            {
                for (int j = 0; j <= Y; j++)
                {
                    Points.Add(new Point(i, j));
                }
            }
        }

        public void Run() => Rovers.ForEach(p =>
        {
            Console.WriteLine(p.Commands);
            Console.WriteLine(p.ToString());
            p.Run();
            Console.WriteLine(p.ToString());
        });

        public void AddRover(int x, int y, Direction direction, string commands)
        {
            var point = Points.FirstOrDefault(p => p.X == x && p.Y == y);

            if (point is null)
            {
                Console.WriteLine("Rover outside the plateau!");
                return;
            }

            Rovers.Add(new Rover(point, direction, commands, MoveManager));
        }
    }
}
