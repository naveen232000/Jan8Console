using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan8Console
{
    internal class DataTypeParameter
    {
        static void F1 (int num)
        {
            num = num + 10;
        }
        static void F2 (ref int num) {
            num = num + 10;
        }
        static void F3 (out int num) {
            num = 0;
            num= num + 10;
        }
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 5;
            int num3 = 5;
            F1 (num1);
            Console.WriteLine("Value Type o/p : {0}", num1);
            F2 (ref num2);
            Console.WriteLine("Reference Type o/p : {0}", num2);
            F3 (out num3);
            Console.WriteLine("Out Type o/p : {0}", num3);

            Console.ReadLine ();
        }
    }
}
