using System;

namespace E05.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hall = double.Parse(Console.ReadLine());
            double cake = hall * 0.20;
            double drinks = cake - (cake * 0.45);
            double animator = hall / 3;
            double sum = hall + cake + drinks + animator;
            Console.WriteLine(sum);
        }
    }
}
