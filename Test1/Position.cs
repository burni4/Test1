using System;

namespace Test1
{
    public class Position
    {
        public double CoordinateX { get; set; } = 0;
        public double CoordinateY { get; set; } = 0;

        public Position(double x, double y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }

        public string getCurrentPositionInString()
        {
            return $"Position: X[{CoordinateX}] Y[{CoordinateY}]";
        }

        public void movePosition(double x, double y)
        {
            CoordinateX += x;
            CoordinateY += y;
        }

    }
}
