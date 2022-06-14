using System;

namespace Exercice4
{
	public class Program
	{
		public static void ProcedureCreateNewEmployee(ILineReader reader, IPrinter printer)
		{
			printer.PrintLine("Enter the employee name:");
			string name = reader.GetLine();
			printer.PrintLine("Enter the employee id:");
			string eid = reader.GetLine();
			Employee employee = new Employee(eid, name);
			EmployeeRecordManager.AddEmployeeRecord(employee);
		}
		public static void ProcedureCreateNewCustomer(ILineReader reader, IPrinter printer)
		{
			printer.PrintLine("Enter the customer name:");
			string name = reader.GetLine();
			printer.PrintLine("Enter the customer id:");
			string eid = reader.GetLine();
			Employee employee = new Employee(eid, name);
			EmployeeRecordManager.AddEmployeeRecord(employee);
		}

		static void Main(string[] args)
		{
			IPrinter printer = new CommandLinePrinter();
			ILineReader reader = new CommandLineReader();

			bool exit = false;

			while(!exit)
			{
				printer.PrintLine("Pick an option");
				printer.PrintLine("[1] Create a new employee");
				printer.PrintLine("[2] Create a new customer");
				printer.PrintLine("[exit] Exit");

				switch(reader.GetLine())
				{
					case "1": ProcedureCreateNewEmployee(reader, printer); break;
					case "2": ProcedureCreateNewCustomer(reader, printer); break;
					case "exit": exit = true; break;
					default: break;
				}

			}
		}
	}
}
