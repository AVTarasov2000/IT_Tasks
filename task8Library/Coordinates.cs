using System;

namespace task8Library
{
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Distance(Coordinates coordinates)
        {
            return (int) Math.Sqrt((X - coordinates.X) * (X - coordinates.X) + (Y - coordinates.Y) * (Y - coordinates.Y));
        }

        public bool IsOn(Coordinates coordinates)
        {
            return coordinates.X == X && coordinates.Y == Y;
        }

        public void MoveTo(Coordinates coordinates)
        {
            if (X > coordinates.X)
                X--;
            else if (X < coordinates.X)
                X++;

            if (Y > coordinates.Y)
                Y--;
            else if (Y < coordinates.Y)
                Y++;
        }
    }
}