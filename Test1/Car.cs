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
        public Position position { get; set; }

        public Car(string name, int speed, int health)
        {
            position = new Position(0, 0);
            Name = name;
            Speed = speed;
            Health = health;
        }

        public void printCurrentPosition()
        {
            Console.WriteLine($"Current car position: {position.getCurrentPositionInString()}");
        }
    }
}
