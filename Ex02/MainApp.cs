using System;

namespace Ex02
{
	class MainApp
	{
		static void Main(string[] args)
		{
			Welcome2 welcome2 = new Welcome2();
			welcome2.PrintWelcome2(args);
			Console.WriteLine("");
			
			Welcome3 welcome3 = new Welcome3();
			welcome3.PrintWelcome3(args);
			Console.WriteLine("");

			Welcome4 welcome4 = new Welcome4();
			welcome4.PrintWelcome4(args);
			Console.WriteLine("");

			Addition addition = new Addition();
			addition.PrintAddition(args);
			Console.WriteLine("");

			Comparison comparison = new Comparison();
			comparison.PrintComparison(args);
			Console.WriteLine("");

			Addition2 addition2 = new Addition2();
			addition2.PrintAddition2(args);
		}
	}
}
