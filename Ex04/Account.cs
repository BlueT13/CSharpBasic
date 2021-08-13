using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
	class Account
	{
		public void PrintAccount(string[] args)
		{
			double balance = 0.0;
			Console.WriteLine($"Balance: {0}",balance);	//수정필요

			double amount;
			Console.WriteLine("Enter deposit amout: ");
			amount = Convert.ToDouble(Console.ReadLine());
			balance += amount;
			Console.WriteLine($"Balance: {.2f}", balance);	//수정필요

			Console.WriteLine("Enter deposit amount: ");
			amount = Convert.ToDouble(Console.ReadLine());
			balance += amount;
			Console.WriteLine($"Balance: {balance}");		//수정필요
		}
	}
}
