﻿using System;

namespace E07.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    int sum = number1 + number2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{number1} + {number2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} + {number2} = {sum} - odd");
                    }
                    break;
                case '-':
                    int diff = number1 - number2;
                    if (diff % 2 == 0)
                    {
                        Console.WriteLine($"{number1} - {number2} = {diff} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} - {number2} = {diff} - odd");
                    }
                    break;
                case '*':
                    int product = number1 * number2;
                    if (product % 2 == 0)
                    {
                        Console.WriteLine($"{number1} * {number2} = {product} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} * {number2} = {product} - odd");
                    }
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        double division = number1 * 1.0 / number2;
                        Console.WriteLine($"{number1} / {number2} = {division:F2}");
                    }
                    break;
                case '%':
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        int leftover = number1 % number2;
                        Console.WriteLine($"{number1} % {number2} = {leftover}");
                    }
                    break;
            }
        }
    }
}
