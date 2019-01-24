using System;

namespace Even_OddCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, even=0, odd=0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Enter number");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            if (odd > 0 && even > 0)
            {
                Console.WriteLine("Even: {0} \nOdd: {1}", even, odd);
            }
            else if (odd > 0 && even == 0)
            {
                Console.WriteLine("Odd: {0}", odd);
            }
            else
            {
                Console.WriteLine("Even: {0}", even);
            }
        }
    }
}
