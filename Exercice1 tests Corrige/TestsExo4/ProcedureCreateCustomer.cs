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
	public class ProcedureCreateCustomer
	{
		[TestMethod]
		public void ShouldSucceed()
		{
			Mocks.MockLineReader reader = new Mocks.MockLineReader(new string[] { "Sylvain Bellamy", "1234" });
			Mocks.MockPrinter printer = new Mocks.MockPrinter();

			Mocks.MockHijackCustomerRecordAdderFakeDico fakeDico = new Mocks.MockHijackCustomerRecordAdderFakeDico(CustomerRecordManager.customerRecordAdder);
			CustomerRecordManager.customerRecordAdder = fakeDico;

			Program.ProcedureCreateNewCustomer(reader, printer);
			Assert.AreEqual("Enter the customer name:", printer.lines[0]);
			Assert.AreEqual("Enter the customer id:", printer.lines[1]);
		}
		[TestMethod]
		public void ShouldFailWithEmptyName()
		{
			Mocks.MockLineReader reader = new Mocks.MockLineReader(new string[] { "", "1234" });
			Mocks.MockPrinter printer = new Mocks.MockPrinter();
			Assert.ThrowsException<BadNameException>(() => Program.ProcedureCreateNewCustomer(reader, printer));
		}
		[TestMethod]
		public void ShouldFail()
		{
			Mocks.MockLineReader reader = new Mocks.MockLineReader(new string[] { "Sylvain Bellamy", "12A4" });
			Mocks.MockPrinter printer = new Mocks.MockPrinter();
			Assert.ThrowsException<BadIDException>(() => Program.ProcedureCreateNewCustomer(reader, printer));
			Assert.AreEqual("Enter the customer name:", printer.lines[0]);
			Assert.AreEqual("Enter the customer id:", printer.lines[1]);
		}
		[TestMethod]
		public void AddsCustomerOnSuccess()
		{
			Mocks.MockLineReader reader = new Mocks.MockLineReader(new string[] { "Sylvain Bellamy", "1234" });
			Mocks.MockPrinter printer = new Mocks.MockPrinter();

			var hijacker = new Mocks.MockHijackCustomerRecordAdder(Exercice4.CustomerRecordManager.customerRecordAdder);

			Exercice4.CustomerRecordManager.customerRecordAdder = hijacker;

			Program.ProcedureCreateNewCustomer(reader, printer);

			Assert.IsNotNull(hijacker.lastCustomer);
			Assert.IsNotNull(hijacker.lastDico);
			Assert.IsNotNull(hijacker.lastDico.ContainsKey(hijacker.lastCustomer.GetCID()));
		}
		[TestMethod]
		public void DoesNotAddCustomerOnFailure()
		{
			Mocks.MockLineReader reader = new Mocks.MockLineReader(new string[] { "Sylvain Bellamy", "12A4" });
			Mocks.MockPrinter printer = new Mocks.MockPrinter();

			var hijacker = new Mocks.MockHijackCustomerRecordAdder(Exercice4.CustomerRecordManager.customerRecordAdder);

			Exercice4.CustomerRecordManager.customerRecordAdder = hijacker;

			Assert.ThrowsException<BadIDException>(() => Program.ProcedureCreateNewCustomer(reader, printer));

			Assert.IsNull(hijacker.lastCustomer);
			Assert.IsNull(hijacker.lastDico);
		}
	}
}
