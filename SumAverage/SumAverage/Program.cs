using System;
using System.Text;

namespace SumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, sum, avg;
            Console.WriteLine("Enter number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number");
            n5 = Convert.ToInt32(Console.ReadLine());
            sum = n1 + n2 + n3 + n4 + n5;
            avg = sum / 5;
            Console.WriteLine("Sum is {0}", sum);
            Console.WriteLine("Avg is {0}", avg);
            Console.ReadLine();
        }
    }
}
