using System;
namespace Fun_Projects
{
    public class ReverseArray
    {
        // Creating a function that reverses an array of numbers
        public static void Array_reverse()
        {
            int[] myarr = { 1, 8, 3, 4, 5, 0, 7 };
            // int one = 1;
            int[] newmyarr = { };
            for (int i = myarr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myarr[i]);
            }
        }
    }
}