using System;
using CalculatorLib;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator Started!");
			Calculator calc = new Calculator();
			
			calc.Add(ReadNumber("Enter number 1:"));
			calc.Add(ReadNumber("Enter number 2:"));			
			
			Console.WriteLine("Result is {0}", calc.Total);
			
			Console.ReadKey();
        }
		
		static int ReadNumber(string prompt)
		{
			int number;
			Console.WriteLine(prompt);
			while(int.TryParse(Console.ReadLine(), out number))
			{
				Console.WriteLine(prompt);
			}
			return number;
		}
    }
}
