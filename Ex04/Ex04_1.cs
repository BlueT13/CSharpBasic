using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
	class Ex04_1
	{
		public void PrintEx04_1(string[] args)
		{
			double won;
			double dollar;

			Console.WriteLine("Price in won: ");
			won = Convert.ToDouble(Console.ReadLine());

			dollar = won / 1170;
			dollar = Math.Round(dollar, 2);
			Console.WriteLine($"--> ${dollar}");
		}
	}
}
