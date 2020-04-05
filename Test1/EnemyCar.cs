using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class EnemyCar : Car, ICarActions, IDisplayInformationOnTheScreen
    {
        private int enemyState;
        public ElementID<string> elementID { get; private set; }
        public int accelerationOfMovement { get; set; } = 2;

        public EnemyCar(string name, int speed, int health): base(name, speed, health)
        {
            this.position = new Position(10, 10);
            this.Name = name;
            this.Speed = speed;
            this.Health = health;
        }

        public void MoveUpX(int x)
        {
            this.position.CoordinateX += x * accelerationOfMovement;
            this.PositionEvents += this.position.PositionHasBeenChanged;
        }

        public void MoveUpY(int y)
        {
            this.position.CoordinateY += y * accelerationOfMovement;
            this.PositionEvents += this.position.PositionHasBeenChanged;
        }

        public void PrintCurrentPosition()
        {
            Console.WriteLine($"Current enemy car({this.Name}) position: X[{this.position.CoordinateX}] Y[{this.position.CoordinateY}]");
        }
    }
}
