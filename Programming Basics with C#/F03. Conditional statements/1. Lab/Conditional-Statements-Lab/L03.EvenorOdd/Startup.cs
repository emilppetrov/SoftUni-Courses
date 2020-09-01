using System;

namespace L03.EvenorOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //read number from console
            int number = int.Parse(Console.ReadLine());
            //check if number is even or odd
            bool isNumberEven = (number % 2) == 0;
            //print to console
            if (isNumberEven)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
