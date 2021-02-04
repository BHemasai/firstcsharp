using System;

namespace Ternary
{
    class Program
    {
       
		public static void Main()
		{
			int x = 100, y = 10;

			string result = x > y ? "x is greater than y"
									: x < y ? "x is less than y"
										: x == y ? "x is equal to y" : "No result";

			Console.WriteLine(result);
		}
	}
}

