namespace Calculator.Test
{
	public class CalculatorTest
	{
		[Fact]
		public void APlusB()
		{
			string input = $"{1},{1}";

			int result = StringCalculator.Add(input);

			int attendu = 2;

			Assert.Equal(result, attendu);
		}
	}
}