using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
	class TernaryOperator
	{
		public void PrintTernaryOperator(string[] args)
		{
			int a = 3, b = 5;
			int difference = (a > b) ? (a - b) : (b - a);
			Console.WriteLine("Difference is " +difference);
		}
	}
}
