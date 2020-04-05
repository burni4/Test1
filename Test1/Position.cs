using System;

namespace Test1
{
    public class Position : ICarActions, IDisplayInformationOnTheScreen
    {
        public double CoordinateX { get; set; } = 0;
        public double CoordinateY { get; set; } = 0;
        public int accelerationOfMovement { get; set; } = 1;

        public Position(double x, double y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }
        public void MoveUpX(int x)
        {
            CoordinateX += x;
        }

        public void MoveUpY(int y)
        {
            CoordinateY += y;
        }

        public void PositionHasBeenChanged()
        {
            Console.WriteLine("Position has been changed");
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

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   CoordinateX == position.CoordinateX &&
                   CoordinateY == position.CoordinateY;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CoordinateX, CoordinateY);
        }

        public void PrintCurrentPosition()
        {
            Console.WriteLine($"Current position: X[{this.CoordinateX}] Y[{this.CoordinateY}]");
        }

        public static Position operator+ (Position position1, Position position2)
        {
            var newPosition = new Position(position1.CoordinateX+ position2.CoordinateX, 
                                            position1.CoordinateY + position2.CoordinateY);

            return newPosition;
        }

        public static bool operator >(Position position1, Position position2)
        {
         
            double sum1 = position1.CoordinateX
                       + position1.CoordinateY;
            double sum2 = position2.CoordinateX
                       + position2.CoordinateY;

            return sum1> sum2;
        }

        public static bool operator <(Position position1, Position position2)
        {

            double sum1 = position1.CoordinateX
                       + position1.CoordinateY;
            double sum2 = position2.CoordinateX
                       + position2.CoordinateY;

            return sum1 < sum2;
        }

        public static bool operator <=(Position position1, Position position2)
        {
            if (position1 == position2)
            {
                return true;
            }

            double sum1 = position1.CoordinateX
                       + position1.CoordinateY;
            double sum2 = position2.CoordinateX
                       + position2.CoordinateY;

            return sum1 <= sum2;
        }

        public static bool operator >=(Position position1, Position position2)
        {
            if (position1 == position2)
            {
                return true;
            }           

            double sum1 = position1.CoordinateX
                       + position1.CoordinateY;
            double sum2 = position2.CoordinateX
                       + position2.CoordinateY;

            return sum1 >= sum2;
        }

        public static bool operator ==(Position position1, Position position2)
        {

            if (position1.CoordinateX == position2.CoordinateX &&
               position1.CoordinateY == position2.CoordinateY)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Position position1, Position position2)
        {

            if (position1.CoordinateX != position2.CoordinateX ||
               position1.CoordinateY != position2.CoordinateY)
            {
                return true;
            }

            return false;
        }
    }
}
