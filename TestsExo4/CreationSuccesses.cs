using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exercice4;
using System.Threading.Tasks;

namespace TestsExo4
{
	[TestClass]
	public class CreationSuccesses
	{
		[TestMethod]
		public void CreatingAnEmployeeWorks()
		{
			IEmployee employee = new Employee("LHB", "Arthur Pendragon");
			Assert.AreEqual("LHB", employee.GetEID());
			Assert.AreEqual("Arthur Pendragon", employee.GetName());
		}
		[TestMethod]
		public void EmployeesArePrintable()
		{
			IEmployee employeeA = new Employee("LHB", "Arthur Pendragon");
			IEmployee employeeB = new Employee("FDS", "Nikola Tesla");
			Mocks.MockPrinter printer = new Mocks.MockPrinter();
			employeeA.Print(printer);
			employeeB.Print(printer);
			Assert.AreEqual("[LHB] Arthur Pendragon", printer.lines[0]);
			Assert.AreEqual("[FDS] Nikola Tesla", printer.lines[1]);
		}

		[TestMethod]
		public void CreatingACustomerWorks()
		{
			ICustomer c = new Customer("1254", "Arthur Pendragon");
			Assert.AreEqual("1254", c.GetCID());
			Assert.AreEqual("Arthur Pendragon", c.GetName());
		}
		[TestMethod]
		public void CustomersArePrintable()
		{
			ICustomer cA = new Customer("17", "Arthur Pendragon");
			ICustomer cB = new Customer("378", "Nikola Tesla");
			Mocks.MockPrinter printer = new Mocks.MockPrinter();
			cA.Print(printer);
			cB.Print(printer);
			Assert.AreEqual("[17] Arthur Pendragon", printer.lines[0]);
			Assert.AreEqual("[378] Nikola Tesla", printer.lines[1]);
		}

		[TestMethod]
		public void GoodEmployeeID()
		{
			Assert.IsNotNull(new Employee("ASD", "Sylvain Bellamy"));
			Assert.IsNotNull(new Employee("GED", "Sylvain Bellamy"));
			Assert.IsNotNull(new Employee("CAS", "Sylvain Bellamy"));
			Assert.IsNotNull(new Employee("LKU", "Sylvain Bellamy"));
			Assert.IsNotNull(new Employee("ADS", "Sylvain Bellamy"));
			Assert.IsNotNull(new Employee("ACD", "Sylvain Bellamy"));
		}
		[TestMethod]
		public void GoodCustomerID()
		{
			Assert.IsNotNull(new Customer("1", "Sylvain Bellamy"));
			Assert.IsNotNull(new Customer("2345", "Sylvain Bellamy"));
			Assert.IsNotNull(new Customer("3435", "Sylvain Bellamy"));
			Assert.IsNotNull(new Customer("0", "Sylvain Bellamy"));
		}
	}
}
