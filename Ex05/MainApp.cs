using System;

namespace Ex05
{
	class MainApp
	{
		static void Main(string[] args)
		{
			TernaryOperator ternaryOperator = new TernaryOperator();
			//ternaryOperator.PrintTernaryOperator(args);
			Console.WriteLine("");

			BitOperator bitOperator = new BitOperator();
			bitOperator.PrintBitOperator(args);
			Console.WriteLine("");
		}
	}
}
