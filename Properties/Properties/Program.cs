using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et navn");
            Person person1 = new Person(Console.ReadLine());
            Console.WriteLine("Navnet du har indtastet er " + person1.Navn);
        }
    }
}
