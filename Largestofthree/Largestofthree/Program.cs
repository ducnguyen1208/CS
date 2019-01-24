using System;

namespace Largestofthree
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            c = Convert.ToInt32(Console.ReadLine());
            if (a>b && a>c)
            {
                Console.WriteLine("{0} is largest", a);
            }
            else if (b>a && b>c)
            {
                Console.WriteLine("{0} is largest", b);
            }
            else if (c>a && c>b)
            {
                Console.WriteLine("{0} is largest", c);
;            }
            else
            {
                Console.WriteLine("All three numbers are equal");
            }
        }
    }
}
