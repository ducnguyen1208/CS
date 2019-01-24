using System;

namespace Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Enter Number");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    continue;
                }
                if (num == 0)
                {
                    break;
                }
                sum = sum + sum;
            }
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
