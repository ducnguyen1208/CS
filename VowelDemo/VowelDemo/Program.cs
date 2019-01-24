using System;

namespace VowelDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter character (A to Z)");
            ch = Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Character is not vowel");
                    break;
            }
        }
    }
}
