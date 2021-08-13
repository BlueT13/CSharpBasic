using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
	class Ex04_3
	{
		public void PrintEx04_3(string[] args)
		{
			Console.WriteLine("Amount of withdrawal: ");
			int amount1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Amount in 50,000-won banknote: ");
			int amount2 = Convert.ToInt32(Console.ReadLine());

			int won5 = amount2 / 5;
			int won1 = amount1 - amount2;
			Console.WriteLine($"50,000-won banknote: {won5}");
			Console.WriteLine($"10,000-won banknote: {won1}");
		}
	}
}
