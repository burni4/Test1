using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class Car: IDisplayInformationOnTheScreen
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public Position position { get; set; }

        public Car(string name, int speed, int health)
        {
            position = new Position(0, 0);
            Name = name;
            Speed = speed;
            Health = health;
        }

        public void PrintCurrentPosition()
        {
            Console.WriteLine($"Current car({this.Name}) position: X[{this.position.CoordinateX}] Y[{this.position.CoordinateY}]");
        }
    }
}
