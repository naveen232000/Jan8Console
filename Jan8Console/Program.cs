using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan8Console
{
    internal class Program
    {
        public static async Task Fun1()
        {
            await Task.Run(() => { 
            for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Function 1 exe count : {0}",i);
                    Task.Delay(1000).Wait();
                }
            });
        }
        public static void Fun2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Function 2 exe count : {0}", i);
                Task.Delay(100).Wait();
            }
        }
        static void Main(string[] args)
        {
            Fun1();
            Fun2();
            Console.ReadLine();
        }
    }
}
