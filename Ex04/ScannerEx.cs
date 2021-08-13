using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
	class ScannerEx
	{
		public void PrintScannerEx(string[] args)
		{
			Console.WriteLine("Enter name, city, age, weight, marriage.");
			string name = Console.ReadLine();
			Console.WriteLine($"Name: {name}", ", ");
			
			string city = Console.ReadLine();
			Console.WriteLine($"City: {city}", ", ");

			int age = int.Parse(Console.ReadLine());
			Console.WriteLine($"Age: {age}", ", ");

			double weight = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine($"Weight: {weight}", ", ");

			bool marriage =Convert.ToBoolean(Console.ReadLine());
			Console.WriteLine($"Marriage: {marriage}");
		}
	}
}
