namespace Fun_Projects
{
    public class NewClass
    {
        public static bool search_prime()
        {
            //Write a function that test if a number n is a prime number
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine($"{number} is not a prime number");
            }
            Console.WriteLine("It returns true if the number is a prime number");
            Console.WriteLine("It returns false if the number is not a prime number");
            for (int i = 2; i < number; i++)
            {
                if ((number %i) != 0)
                {
                   continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}