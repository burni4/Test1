using System;
using System.Threading;
using System.Threading.Tasks;

namespace Test1
{
    public class AsyncAwaitThread
    {
        public async void StartAsync()
        {
            Console.WriteLine("Начало метода StartAsync");
            Console.WriteLine(await Task.Run(() => StartMethod(" from Async")));
            Console.WriteLine("Конец метода StartAsync");

        }

        public void StartNotAsync()
        {
            Console.WriteLine("Начало метода StartNotAsync");
            Console.WriteLine(StartMethod(" from not Async"));        ;
            Console.WriteLine("Конец метода StartNotAsync");
        }

        public void StartThread(ThreadPriority threadPriority, string numThread)
        {
            Console.WriteLine($"Начало метода StartThread{numThread}");
            Thread myThread = new Thread(new ThreadStart(()=> StartMethod($" from Thread{numThread}")));
            myThread.Priority = threadPriority;
            myThread.Start();
            Console.WriteLine($"Конец метода StartThread{numThread}");
        }

        private string StartMethod(string mes)
        {
            for (int i=0; i<10000000;i++)
            {
                if (i%1000000==0)
                {
                    Console.WriteLine($"{i} {mes}");
                }
            }

            return "Конец метода StartMethod";
        }

    }


}
