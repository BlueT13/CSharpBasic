using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
	class TypeConversion
	{
		public void PrintTypeConversion(string[] args)
		{
			byte b = 127;
			int i = 100;

			Console.WriteLine($"{b + i}");
			Console.WriteLine($"{10/4}");
			Console.WriteLine($"{10.0/4}");
			//Console.WriteLine($"{Convert.ToChar(0x12340041)}"); error발생
			//Console.WriteLine($"{Convert.ToByte(b+i)}"); error발생
			//Console.WriteLine($"{Convert.ToInt32(2.9)+1.8}"); error발생
			//Console.WriteLine($"{Convert.ToInt32(2.9+1.8)}"); error발생
			//Console.WriteLine($"{Convert.ToInt32(2..9)+Convert.ToInt32(1.8)}"); error발생
		}
	}
}
