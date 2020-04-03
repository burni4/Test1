using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class EnemyCar : Car
    {
        private int enemyState;

        public EnemyCar(string name, int speed, int health): base(name, speed, health)
        {
            this.position = new Position(10, 10);
            this.Name = name;
            this.Speed = speed;
            this.Health = health;
        }
    }
}
