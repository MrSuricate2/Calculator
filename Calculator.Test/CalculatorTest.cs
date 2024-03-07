namespace Calculator.Test
{
	public class CalculatorTest
	{
		[Theory]
		[InlineData("1,1", 2)]
		[InlineData("1,2", 3)]
		public void APlusB(string input, int attendu)
		{
			int result = StringCalculator.Add(input);

			Assert.Equal(result, attendu);
		}
	}
}