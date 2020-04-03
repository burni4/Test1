using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public class EnemyCar : Car
    {
        private int enemyState;
        public EnemyCar()
        {

        }
        public EnemyCar(string name, int speed, int health)
        {
            this.CoordinateX = 10;
            this.CoordinateY = 10;
            this.Name = name;
            this.Speed = speed;
            this.Health = health;
        }
    }
}
