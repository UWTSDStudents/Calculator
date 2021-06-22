using System;
using Xunit;
using CalculatorLib;

namespace CalculatorXUnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTest()
        {
			Calculator calc = new Calculator();
			calc.Add(4);
			Assert.Equal(4, calc.Total);
        }
		
		[Fact]
        public void SubtractTest()
        {
			Calculator calc = new Calculator();
			calc.Subtract(3);
			Assert.Equal(-3, calc.Total);
        }
    }
}
