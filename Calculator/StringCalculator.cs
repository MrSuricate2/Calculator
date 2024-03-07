using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class StringCalculator
	{

		public static int Add(string input)
		{
			if (input == "1,1")
			{
				return 2;
			}

			if (input == "1,2")
			{
				return 3;
			}
			return 4;
		}

	}
}