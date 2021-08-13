using System;

namespace Ex04
{
	class MainApp
	{
		static void Main(string[] args)
		{
			ScannerEx scannerEx = new ScannerEx();
			scannerEx.PrintScannerEx(args);
			Console.WriteLine("");

			ArithmeticOperator arithmeticOperator = new ArithmeticOperator();
			arithmeticOperator.PrintArithmeticOperator(args);
			Console.WriteLine("");

			AssignmentIncDecOperator assignmentIncDecOperator = new AssignmentIncDecOperator();
			assignmentIncDecOperator.PrintAssignmentIncDecOperator(args);
			Console.WriteLine("");

			LogicalOperator logicalOperator = new LogicalOperator();
			logicalOperator.PrintLogicalOperator(args);
			Console.WriteLine("");

			Account account = new Account();	//수정필요
			account.PrintAccount(args);
			Console.WriteLine("");

			Ex04_1 ex04_1 = new Ex04_1();
			ex04_1.PrintEx04_1(args);
			Console.WriteLine("");

			Ex04_2 ex04_2 = new Ex04_2();
			ex04_2.PrintEx04_2(args);
			Console.WriteLine("");

			Ex04_3 ex04_3 = new Ex04_3();
			ex04_3.PrintEx04_3(args);
			Console.WriteLine("");

			Ex04_4 ex04_4 = new Ex04_4();
			ex04_4.PrintEx04_4(args);
			Console.WriteLine("");
		}
	}
}
