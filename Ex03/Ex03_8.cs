using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
	class Ex03_8
	{
		public void PrintEx03_8(string[] args)
		{
			int hour;
			int minute;
			int second;
			int total;
			
			Console.WriteLine("hour: ");
			hour = int.Parse(Console.ReadLine());

			Console.WriteLine("hour: ");
			minute = int.Parse(Console.ReadLine());

			Console.WriteLine("hour: ");
			second = int.Parse(Console.ReadLine());

			total = hour * 60 * 60 + minute * 60 + second;
			Console.WriteLine("Total: {0} sec.",total);

		}
	}
}
