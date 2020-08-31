using System;

namespace L06.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int animals = int.Parse(Console.ReadLine());
            double dogsFoodPrice = dogs * 2.50;
            double animalsFoodPrice = animals * 4;
            double totalFoodPrice = dogsFoodPrice + animalsFoodPrice;
            Console.WriteLine($"{totalFoodPrice:F2} lv.");
        }
    }
}
