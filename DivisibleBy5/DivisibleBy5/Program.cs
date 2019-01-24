using System;

namespace DivisibleBy5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            if(num % 5 == 0)
            {
                Console.WriteLine("Entered number is divisible by 5");
            }
            else
            {
                Console.WriteLine("Entered number is not divisible by 5");
            }
        }
    }
}
