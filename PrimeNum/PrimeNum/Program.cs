using System;

namespace PrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, num = 1, flag = 0;
            while(counter < 10)
            {
                num++;
                flag = 0;
                Console.WriteLine("Num: {0}",num);
                for(int i = 2; i < num; i++)
                {
                    Console.WriteLine("I: {0}", i);
                    if (num % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("Prime Num: {0} ", num);
                    counter++;
                    Console.WriteLine("Counter: {0}", counter);
                    Console.WriteLine();
                }
            }
        }
    }
}
