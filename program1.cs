using System;

class Program 
{
	public static void Main()
	{
		int num1, num2;
		Console.WriteLine("Please enter first number");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please enter second number");
		num2 = Convert.ToInt32(Console.ReadLine());
		int sum = num1 + num2;
		Console.WriteLine("Addition is: {0}", sum);
		Console.WriteLine("Good morning");
		Console.Write("How are you");
	}
}
