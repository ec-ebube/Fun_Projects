using System;
namespace Fun_Projects
{
    public class SummingArray
    {
        public static void Sum_array()
        {
            // Creating a functin that sums the numbers in an array
            int[] numarr = {1, 2, 3, 4, 5};
            int sum = 0;
            for (int i = numarr[0]; i <= numarr.Length; i++)
            {
                sum = sum + i;
            }
                Console.WriteLine(sum);
        }
    }
}