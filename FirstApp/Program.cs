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
            string myName = "Sergei";
            byte myAge = 32;
            bool havePet = true;
            double myShoeSize = 46.5;
            Console.WriteLine("My name is " + myName);
            Console.WriteLine("I'm " + myAge);
            Console.WriteLine("Do you have a pet? " + havePet);
            Console.WriteLine("My shoe size is " + myShoeSize);

            daysOfWeek myFavoriteDay;
            myFavoriteDay = daysOfWeek.Friday;
            Console.WriteLine(myFavoriteDay);

            Console.ReadKey();
        }        
        
    }
    enum daysOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}

