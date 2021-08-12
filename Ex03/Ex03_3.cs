using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
	class Ex03_3
	{
		public void PrintEx03_3(string[] args)
		{
			double d = 0.1234;
			double e = 1234E-4;
			double f = 0.1234f;
			double w = .1234D;

			Console.WriteLine($"{d}");
			Console.WriteLine($"{e}");
			Console.WriteLine($"{f}");
			Console.WriteLine($"{w}");
		}
	}
}
