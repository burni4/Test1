using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: не до конца понял тонкости работы с where
            Lesson12();

            Console.ReadLine();
        }

        static void Lesson10()
        {
            PlayerCar playerCar = new PlayerCar("SportCar", 10, 100);
            Console.WriteLine($"Player car Start position:");
            playerCar.printCurrentPosition();
            EnemyCar enemyCar = new EnemyCar("BigBoss", 15, 200);
            Console.WriteLine($"Enemy car Start position:");
            enemyCar.printCurrentPosition();

            playerCar.position.movePosition(1, 1);
            enemyCar.position.movePosition(2, 2);

            Console.WriteLine($"Player car:");
            playerCar.printCurrentPosition();
            Console.WriteLine($"Enemy car:");
            enemyCar.printCurrentPosition();
        }

        static void Lesson11()
        {
            PlayerCar playerCar1 = new PlayerCar("SportCar1", 10, 100);
            PlayerCar playerCar2 = new PlayerCar("SportCar2", 10, 100);
            playerCar2.position.movePosition(5, 5);
            playerCar1.position = playerCar1.position + playerCar2.position;
            playerCar1.printCurrentPosition();

            /////
            ///
            playerCar1.position=new Position(0,0);
            playerCar2.position = new Position(0, 1);
            Console.WriteLine(playerCar1.position < playerCar2.position);
            Console.WriteLine(playerCar1.position > playerCar2.position);
            Console.WriteLine(playerCar1.position <= playerCar2.position);
            Console.WriteLine(playerCar1.position >= playerCar2.position);
            Console.WriteLine(playerCar1.position == playerCar2.position);
            Console.WriteLine(playerCar1.position != playerCar2.position);
        }

        static void Lesson12()
        {

        }
    }
}
