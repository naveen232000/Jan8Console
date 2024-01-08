using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Jan8Console
{
    internal class NamedDefaultParam
    {
        static void RegCanditate(string Fname, string Lname, int age,string city="TN") {
        
            HashSet<string> canditateDetails = new HashSet<string>();
            canditateDetails.Add(Fname);
            canditateDetails.Add(Lname);
            string ages=age.ToString();
            canditateDetails.Add(ages);
            canditateDetails.Add(city);
            Console.WriteLine();
            foreach (string s in canditateDetails)
            {
                Console.WriteLine(s);
            }

        }
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Enter Your Details : ");
            Console.Write("Enter Your First Name* : ");
            string fname=Console.ReadLine();
            Console.Write("Enter Your Last Name* : ");
            string lname = Console.ReadLine();
            Console.Write("Enter Your Age* : ");
            int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Your City(optional) : ");
                string city = Console.ReadLine();
                if (city == "")
                {
                    RegCanditate(Fname: fname, Lname: lname, age: age);
                }
                else
                {
                    RegCanditate(Fname: fname, Lname: lname, age: age, city: city);
                }
            }
            catch(Exception e) { Console.WriteLine(e.Message); }
           
          
            Console.ReadLine();
        }
    }
}
