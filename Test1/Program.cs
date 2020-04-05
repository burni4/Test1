using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {

            Lesson15_DelegatesAndEvents();

            Console.ReadLine();
        }

        #region LessonsMethods
        static void Lesson10()
        {
            PlayerCar playerCar = new PlayerCar("SportCar", 10, 100);
            Console.WriteLine($"Player car Start position:");
            playerCar.PrintCurrentPosition();
            EnemyCar enemyCar = new EnemyCar("BigBoss", 15, 200);
            Console.WriteLine($"Enemy car Start position:");
            enemyCar.PrintCurrentPosition();

            playerCar.position.movePosition(1, 1);
            enemyCar.position.movePosition(2, 2);

            Console.WriteLine($"Player car:");
            playerCar.PrintCurrentPosition();
            Console.WriteLine($"Enemy car:");
            enemyCar.PrintCurrentPosition();
        }

        static void Lesson11()
        {
            PlayerCar playerCar1 = new PlayerCar("SportCar1", 10, 100);
            PlayerCar playerCar2 = new PlayerCar("SportCar2", 10, 100);
            playerCar2.position.movePosition(5, 5);
            playerCar1.position = playerCar1.position + playerCar2.position;
            playerCar1.PrintCurrentPosition();

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

        static void Lesson13()
        {
            PlayerCar pcar = new PlayerCar("car1", 1, 100);
            pcar.PrintCurrentPosition();
            pcar.position.PrintCurrentPosition();
            EnemyCar enCar = new EnemyCar("enemyCar", 1, 222);
            enCar.PrintCurrentPosition();
            enCar.position.PrintCurrentPosition(); 

            Car newCar = (Car)pcar;
            newCar.PrintCurrentPosition();
            newCar.position.PrintCurrentPosition();

        }

        static void Lesson14_Exceptions()
        {
            try
            {
                int i = 10;
                int j = i / 1;
                int c = 2000000000;

                int b = checked( c * 1);

                throw new ExceptionIncorrectData(); 
                
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Divide by zero");
            }
            catch (ExceptionIncorrectData ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The work of the program is completed");
            }

        }
        #endregion

        public static void Lesson15_DelegatesAndEvents()
        {

            PlayerCar pcar = new PlayerCar("Car1",1,1);
            pcar.PrintCurrentPosition();
            pcar.CheckCarPostion();
            pcar.MoveUpX(1);
            pcar.PrintCurrentPosition();
            pcar.CheckCarPostion();

        }
    }
}
