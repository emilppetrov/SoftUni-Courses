using System;

namespace L01.GreetingbyName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            //first way
            Console.WriteLine($"Hello, {name}!");
            //second way
            Console.WriteLine("Hello, " +name+ "!");
            //third way
            Console.WriteLine("Hello, {0}!",  name);
        }
    }
}
