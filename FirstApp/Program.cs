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
            string myFavColor = "green";
            byte myAge = 32;
            bool havePet = true;
            double myShoeSize = 46.5;
            double result = 5.0 / 2.0 * 3.0;
            int k = -10;
            int b = 20;
            int result1 = b - k;
            double result2 = 10 % 3;
            Console.WriteLine("My name is " + myName);
            Console.WriteLine("I'm " + myAge);
            Console.WriteLine("Do you have a pet? " + havePet);
            Console.WriteLine("My shoe size is " + myShoeSize);

            daysOfWeek myFavoriteDay;
            myFavoriteDay = daysOfWeek.Friday;
            Console.WriteLine(myFavoriteDay);

            Semaphore mySemaphore;
            mySemaphore = Semaphore.Red;
            Console.WriteLine(mySemaphore);

            Console.WriteLine("\tПривет, \nмир!");

            Console.WriteLine($"My age is {myAge}");

            Console.WriteLine($"My name is {myName}, my age is {myAge} y.o. and my favorite color is {myFavColor}");

            Console.Write("Enter a sentence: ");
            string str = Console.ReadLine();
            Console.WriteLine(str);

            Console.WriteLine($"5 / 2 * 3 = {result}");

            Console.WriteLine(result1);

            Console.WriteLine(result2);


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

    enum Semaphore : int
    {
        Red = 100,
        Green = 200,
        Blue = 300,
    }
}

