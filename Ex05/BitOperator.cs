using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
	class BitOperator
	{
		public void PrintBitOperator(string[]args)
		{
			short a = Convert.ToInt16(0x55ff);
			short b = Convert.ToInt16(0x00ff);
			Console.WriteLine("[Bitwise logical operation]");
			Console.WriteLine($"{0}", a & b);
		}
	}
}
