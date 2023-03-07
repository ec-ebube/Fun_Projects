using System;
namespace Fun_Projects
{
    public class Primenumber
    {
        public static void prime_search()
        {
            //Write a function that test if a number n is a prime number
            int number = 21;
            if (number == 1)
            {
                Console.WriteLine($"{number} is not a prime number");
            }
            for (int i = 2; i < number; i++)
            {
                if ((number %i) != 0)
                {
                    Console.WriteLine($"Cannot be divided by {number}");
                }
                else
                {
                    Console.WriteLine($"Can be divided by {number}, therefore, it's not a prime number");
                }
            }
        }
    }
}