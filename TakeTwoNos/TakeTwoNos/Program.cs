using System;

namespace TakeTwoNos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, r, mchoice;
            char ynchoice;

            do
            {
                Console.WriteLine("Enter first number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter first number");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1: +");
                Console.WriteLine("2: -");
                Console.WriteLine("3: *");
                Console.WriteLine("4: /");
                Console.WriteLine("5: %");
                Console.WriteLine("6: Exit");
                Console.WriteLine("Please select choice above");

                mchoice = Convert.ToInt32(Console.ReadLine());
                if (mchoice == 6)
                {
                    break;
                }
                else
                {
                    switch (mchoice)
                    {
                        case 1:
                            r = num1 + num2;
                            Console.WriteLine("Addition is: {0}", r);
                            break;
                        case 2:
                            r = num1 - num2;
                            Console.WriteLine("Subtraction is: {0}", r);
                            break;
                        case 3:
                            r = num1 * num2;
                            Console.WriteLine("Multiplication is: {0}", r);
                            break;
                        case 4:
                            r = num1 / num2;
                            Console.WriteLine("Division is: {0}", r);
                            break;
                        case 5:
                            r = num1 % num2;
                            Console.WriteLine("Remainder is: {0}", r);
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                Console.WriteLine("Do you want to continue (Y/N)?");
                ynchoice = Convert.ToChar(Console.ReadLine());
            } while (ynchoice == 'y' || ynchoice == 'Y');
        }
    }
}
