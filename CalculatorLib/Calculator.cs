using System;

namespace CalculatorLib
{
    public class Calculator
    {
		public int Total { get; private set; }
		
		public void Add(int number)
		{
			Total += number;
		}
		
		public void Subtract(int number)
		{
			Total -= number;
		}
    }
}
