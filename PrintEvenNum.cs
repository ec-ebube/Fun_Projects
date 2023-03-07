using System;
namespace Fun_Projects
{
    public class PrintEvenNum
    {
        //create a function that prints all even numbers from one to twenty
        public static int CheckPrime()
        {
            int div = 2;
            int num = 20;
            for (int i = 0; i <= num; i++)
            {
                if (i % div == 0)
                {
                    Console.WriteLine(i);
                }else
                {
                    break;
                }
            }
            return 0;
        }
    }
}