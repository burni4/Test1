using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class PlayerCar : Car
    {
        private int playerState;

        public PlayerCar(string name, int speed, int health): base(name,speed,health)
        {
            this.Name = name;
            this.Speed = speed;
            this.Health = health;
        }
    }
}
