using System;

namespace task8Library
{
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Step { get; set; }

        public Coordinates(int x, int y, int step)
        {
            X = x;
            Y = y;
            Step = step;
        }

        public int Distance(Coordinates coordinates)
        {
            return (int) Math.Sqrt((X - coordinates.X) * (X - coordinates.X) + (Y - coordinates.Y) * (Y - coordinates.Y));
        }

        public bool IsOn(Coordinates coordinates)
        {
            return Math.Abs(coordinates.X - X)<Step && Math.Abs(coordinates.Y - Y)<Step;
        }

        public void MoveTo(Coordinates coordinates)
        {
            int xStep = Math.Abs(X-coordinates.X)<Step ? Math.Abs(X - coordinates.X) : Step;
            if (X > coordinates.X)
                X-=xStep;
            else if (X < coordinates.X)
                X+=xStep;
            
            int yStep = Math.Abs(Y-coordinates.Y)<Step ? Math.Abs(Y - coordinates.Y) : Step;

            if (Y > coordinates.Y)
                Y-=yStep;
            else if (Y < coordinates.Y)
                Y+=yStep;
        }
    }
}