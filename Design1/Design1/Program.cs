using System;

namespace Design1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            Console.WriteLine("Enter # of rows");
            rows = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= rows; i++)
            {
                for(int j = rows; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
