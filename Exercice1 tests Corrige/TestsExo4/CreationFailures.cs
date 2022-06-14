using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercice4;


namespace TestsExo4
{
	[TestClass]
	public class CreationFailures
	{
		[TestMethod]
		public void BadEmployeeID()
		{
			Assert.ThrowsException<BadIDException>(() => new Employee("123", "Sylvain Bellamy"));
			Assert.ThrowsException<BadIDException>(() => new Employee("1B3", "Sylvain Bellamy"));
			Assert.ThrowsException<BadIDException>(() => new Employee("1BA", "Sylvain Bellamy"));
			Assert.ThrowsException<BadIDException>(() => new Employee("ZB3", "Sylvain Bellamy"));
			Assert.ThrowsException<BadIDException>(() => new Employee("ADCS", "Sylvain Bellamy"));
			Assert.ThrowsException<BadIDException>(() => new Employee(".", "Sylvain Bellamy"));
		}
		[TestMethod]
		public void BadCustomerID()
		{
			Assert.ThrowsException<BadIDException>(() => new Customer("A123", "Sylvain Bellamy"));
			Assert.ThrowsException<BadIDException>(() => new Customer("A193", "Sylvain Bellamy"));
			Assert.ThrowsException<BadIDException>(() => new Customer("193q", "Sylvain Bellamy"));
			Assert.ThrowsException<BadIDException>(() => new Customer("-1", "Sylvain Bellamy"));
			Assert.ThrowsException<BadIDException>(() => new Customer(".", "Sylvain Bellamy"));
		}
	}
}
