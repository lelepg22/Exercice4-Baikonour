using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercice4;


namespace TestsExo4
{
	[TestClass]
	public class ProcedureCreateEmployee
	{
		[TestMethod]
		public void ShouldSucceed()
		{
			Mocks.MockLineReader reader = new Mocks.MockLineReader(new string[] { "Sylvain Bellamy", "AWS" });
			Mocks.MockPrinter printer = new Mocks.MockPrinter();
			Program.ProcedureCreateNewEmployee(reader, printer);
			Assert.AreEqual("Enter the employee name:", printer.lines[0]);
			Assert.AreEqual("Enter the employee id:", printer.lines[1]);
		}
		[TestMethod]
		public void ShouldFailWithEmptyName()
		{
			Mocks.MockLineReader reader = new Mocks.MockLineReader(new string[] { "", "ASD" });
			Mocks.MockPrinter printer = new Mocks.MockPrinter();
			Assert.ThrowsException<BadNameException>(() => Program.ProcedureCreateNewEmployee(reader, printer));
		}
		[TestMethod]
		public void ShouldFail()
		{
			Mocks.MockLineReader reader = new Mocks.MockLineReader(new string[] { "Sylvain Bellamy", "12A4" });
			Mocks.MockPrinter printer = new Mocks.MockPrinter();
			Assert.ThrowsException<BadIDException>(() => Program.ProcedureCreateNewCustomer(reader, printer));
			Assert.AreEqual("Enter the employee name:", printer.lines[0]);
			Assert.AreEqual("Enter the employee id:", printer.lines[1]);
		}
	}
}
