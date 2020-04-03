using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public double CoordinateX { get; set; } = 0;
        public double CoordinateY { get; set; } = 0;

        public Car()
        {
            
        }
        public Car(string name, int speed, int health)
        {
            Name = name;
            Speed = speed;
            Health = health;
        }

        public void movePosition(double x, double y)
        {
            CoordinateX += x;
            CoordinateY += y;
        }
        public void printCurrentPosition()
        {
            Console.WriteLine($"Current car position: X[{this.CoordinateX}] Y[{this.CoordinateY}]");
        }
    }
}
