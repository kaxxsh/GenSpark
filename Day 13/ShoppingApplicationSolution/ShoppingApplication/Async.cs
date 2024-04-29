using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication
{
    public class Async
    {
        async Task<int> GetResultFromDatabaseServer()
        {
            Thread.Sleep(5000);
            return new Random().Next();
        }

        public void AsyncMain()
        {
            Async async = new Async();
            Thread t1 = new Thread(async.PrintNumbers);
            t1.Name = "ME";
            Thread t2 = new Thread(async.PrintNumbers);
            t2.Name = "YOU";
            t1.Start();
            t2.Start();
            Console.Out.WriteLine("After the thread");

        }

        void PrintNumbers()
        {
            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("By " + Thread.CurrentThread.Name + " " + i);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
