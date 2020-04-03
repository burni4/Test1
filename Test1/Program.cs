using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCar playerCar = new PlayerCar("SportCar", 10, 100);
            Console.WriteLine($"Player car Start position:");
            playerCar.printCurrentPosition();
            EnemyCar enemyCar = new EnemyCar("BigBoss", 15, 200);
            Console.WriteLine($"Enemy car Start position:");
            enemyCar.printCurrentPosition();

            playerCar.movePosition(1, 1);
            enemyCar.movePosition(2, 2);

            Console.WriteLine($"Player car:");
            playerCar.printCurrentPosition();
            Console.WriteLine($"Enemy car:");
            enemyCar.printCurrentPosition();

            Console.ReadLine();
        }
    }
}
