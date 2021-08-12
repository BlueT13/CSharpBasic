using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
	class Ex03_6
	{
		public void PrintEx03_6(string[] args)
		{
			int price = 20_100;
			long cardNumber = 1234_5678_9012_3456L;
			uint controlBits = 0b10110100_01011011_10110011_11111000;
			long maxLong = 0x7fff_ffff_ffff_ffffL;
			int age = 2______5;

			Console.WriteLine($"{price}");
			Console.WriteLine($"{cardNumber}");
			Console.WriteLine($"{controlBits}"); //수정필요
			Console.WriteLine($"{maxLong}"); //수정필요
			Console.WriteLine($"{age}");
		}
	}
}
