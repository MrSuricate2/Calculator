﻿using System;
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

			string[] table = input.Split(",");

			int total = 0;

			foreach (var t in table)
			{
				int numbers = int.Parse(t);
				
				total += numbers;
			}
			return total;
		}

	}
}