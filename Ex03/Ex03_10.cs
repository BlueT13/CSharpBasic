using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
	class Ex03_10
	{
		public void PrintEx03_10(string[] args)
		{
			double c;
			double f;

			Console.WriteLine("화씨 온도(실수값)를 입력하시오: ");
			f = double.Parse(Console.ReadLine());

			c = (f - 32) * 5 / 9;
			Console.WriteLine("섭씨 온도는 {0}", c);
		}
	}
}
