using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Sergei";
            Console.WriteLine(myName);
            Console.WriteLine("\tHello,\n \tworld!");
            Console.WriteLine("\tI'm 27 y.o.");
            Console.WriteLine("\tMy name is Sergei");
            Console.WriteLine('\u0040');
            Console.WriteLine('\x23');

            Console.ReadKey();
        }
    }
}
