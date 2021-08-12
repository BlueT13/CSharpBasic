using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
	class Ex03_11
	{
		public void PrintEx03_11(string[] args)
		{
			double r;
			double r2;
			double r3;
			const double pi = 3.1415926536;

			Console.WriteLine("원의 반지름(실수값)을 입력하시오: ");
			r = double.Parse(Console.ReadLine());

			r2 = 2 * pi * r; //수정필요
			r3 = pi * r * r; //수정필요

			Console.WriteLine($"반지름이 {r}인 원의 둘레길이는 {r2}, 넓이는 {r3} 이다.");
		}
	}
}
