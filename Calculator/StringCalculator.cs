using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class StringCalculator
	{

		public static int Add(string input)
		{
			string combinedString = input.Replace(" ", "");

			string[] table = combinedString.Split(",");

			int total = 0;

			for (var index = 0; index < table.Length; index++)
			{
				var s = table[index];
				if (!string.IsNullOrWhiteSpace(s))
				{
					if (!int.IsNegative(int.Parse(s)))
					{
						total += int.Parse(s);
					}
					else
					{
						throw new NombreNégatifException(int.Parse(s),index);
					}
				}
			}

			return total;
		}

	}
}