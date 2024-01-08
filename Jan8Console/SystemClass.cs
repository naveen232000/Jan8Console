using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jan8Console
{
    //using System.Reflection;
    internal class SystemClass
    {
        static void Main(string[] args)
        {
            Assembly ourIo = Assembly.LoadFile("C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\system.dll");
           Type[] x= ourIo.GetTypes();
           foreach(Type t in x)
            {
                Console.WriteLine(t.Name);
                Console.WriteLine(t.ReflectedType+"\n");
                //Task.Delay(1000).Wait();
            }
          Console.ReadLine();
        }


    }
}
