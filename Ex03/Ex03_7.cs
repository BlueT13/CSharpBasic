using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
	class Ex03_7
	{
		public void PrintEx03_7(string [] args)
		{
			double a;

			Console.WriteLine("inch: ");
			a = double.Parse(Console.ReadLine());

			Console.WriteLine("cm: " + a * 2.54);
		}
	}
}
