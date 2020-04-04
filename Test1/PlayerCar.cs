using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class PlayerCar : Car, ICarActions, IDisplayInformationOnTheScreen
    {
        private int playerState;
        public ElementID<int> elementID { get; private set; }
        public int accelerationOfMovement { get; set; } = 4;


        public PlayerCar(string name, int speed, int health): base(name,speed,health)
        {
            this.Name = name;
            this.Speed = speed;
            this.Health = health;
        }

        public void MoveUpX(int x)
        {
            this.position.CoordinateX += x * accelerationOfMovement;
        }

        public void MoveUpY(int y)
        {
            this.position.CoordinateY += y * accelerationOfMovement;
        }

        public void PrintCurrentPosition()
        {
            Console.WriteLine($"Current player car({this.Name}) position: X[{this.position.CoordinateX}] Y[{this.position.CoordinateY}]");
        }
    }
}
