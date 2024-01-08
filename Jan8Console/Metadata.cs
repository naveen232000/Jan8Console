using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan8Console
{
    internal class Metadata
    {
        static void Main(string[] args)
        {
            string empName = "John";
            Type tEmpinfo = empName.GetType();
            Type t1 = typeof(Metadata);
            Type t2 = typeof(Enumerable);
            Type t3 = typeof(int);
            Console.WriteLine("Name " + t2.Name);
            Console.WriteLine("full name " + t2.BaseType);
            Console.ReadLine();

        }
    }
}
