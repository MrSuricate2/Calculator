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

			foreach (string s in table)
			{
				if (!string.IsNullOrWhiteSpace(s))
				{
					total += int.Parse(s);
				}
			}

			return total;
		}

	}
}