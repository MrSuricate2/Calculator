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

		[Fact]
		public void APlusN()
		{
			string input = "0,1,2";

			int result = StringCalculator.Add(input);

			int attendu = 3;

			Assert.Equal(result, attendu);
		}
	}
}