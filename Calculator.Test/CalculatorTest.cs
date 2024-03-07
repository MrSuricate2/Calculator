namespace Calculator.Test
{
	public class CalculatorTest
	{
		[Theory]
		[InlineData("1,1", 2)]
		[InlineData("1,2", 3)]
		[InlineData("2,2", 4)]
		[InlineData("2,3", 5)]
		public void APlusB(string input, int attendu)
		{
			int result = StringCalculator.Add(input);

			Assert.Equal(result, attendu);
		}

		[Theory]
		[InlineData("0,1,2", 3)]
		[InlineData("1,2,3", 6)]
		[InlineData("2,3,4", 9)]
		[InlineData("3,4,5", 12)]
		public void APlusN(string input, int attendu)
		{
			int result = StringCalculator.Add(input);

			Assert.Equal(result, attendu);
		}
	}
}