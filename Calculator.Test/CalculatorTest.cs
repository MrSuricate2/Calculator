using System.Numerics;

namespace Calculator.Test
{
	public class CalculatorTest
	{
		public static IEnumerable<object[]> CasAPlusB()
		{
			var random = Random.Shared;
			yield return [random.Next()/3, random.Next()/3];
		}


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

		[Theory]
		[MemberData(nameof(CasAPlusB))]
		public void RandomPlusRandom(int a, int b)
		{
			string input = $"{a},{b}";

			int result = StringCalculator.Add(input);

			Assert.Equal(result, a+b);
		}

		[Fact]
		public void Espace()
		{
			const string testée = "1 0, ,10";

			int parsed = StringCalculator.Add(testée);

			Assert.Equal(20, parsed);
		}

		[Fact]
		public void NombreNégatif()
		{
			const string testée = "1,-2";

			void Act() => StringCalculator.Add(testée);

			NombreNégatifException exception = Assert.Throws<NombreNégatifException>(Act);
			Assert.Equal(1, exception.Position);
			Assert.Equal(-2, exception.NombreFautif);
		}

		[Fact]
		public void PlusieursNombreNégatif()
		{
			const string testée = "1,-2, -1";

			void Act() => StringCalculator.Add(testée);

			NombreNégatifException exception = Assert.Throws<NombreNégatifException>(Act);
			Assert.Equal(1, exception.Position);
			Assert.Equal(-2, exception.NombreFautif);
		}
	}
}