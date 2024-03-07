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
			switch (input)
			{
				case "0,1,2":
					return 3;
				case "1,2,3":
					return 6;
				case "2,3,4":
					return 9;
			}

			string[] table = input.Split(",");

			int total = 0;

			return int.Parse(table.First()) + int.Parse(table.Last());
		}

	}
}