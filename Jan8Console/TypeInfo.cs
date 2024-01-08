using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jan8Console
{
    public interface Bike { bool IsRunning(); }
    public class TypeInfo:Bike
    {
        public string color;
        private int speed; 
        public int JetSpeed { get { return speed; } }
        public void Acceclate(int milage) { speed += milage; }
        public bool IsRunning()
        {
            if (JetSpeed == 0) return false; return true;
        }

    }
   public class Checking
    {
        public static void GetTypeInfo(Type t)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name : "+t.Name);
            sb.AppendLine("FullName : "+t.FullName);
            sb.AppendLine("Name Space : "+t.Namespace);
            sb.AppendLine("Base Type : "+t.BaseType.ToString());
            Type tb = t.BaseType;
            if (tb != null) sb.AppendLine("Name : " + tb.Name);
            Type tls = t.UnderlyingSystemType;
            if (tls != null) sb.AppendLine("is it an abstrct class : " + tls.IsAbstract);
            sb.AppendLine("is it a class : " + tls.IsAnsiClass);
            sb.AppendLine("is it an array : " + tls.IsArray);
            sb.AppendLine("\n For More Info");
            MemberInfo[] mi = t.GetMembers();
            foreach (var v1 in mi)
            {
                sb.AppendLine("declare type : " + v1.DeclaringType.ToString());
                sb.AppendLine("module name : " + v1.Module.ToString());
            }
            Console.WriteLine(sb);

        }

        static void Main(string[] args)
        {
            TypeInfo typeInfo = new TypeInfo();
            Type t = typeInfo.GetType();
            Checking checking = new Checking();
            //Type t = checking.GetType();
            GetTypeInfo(t);
            Console.ReadLine();
        }
    }
}
