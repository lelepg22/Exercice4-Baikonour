using Exercice4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsExo4.Mocks
{
	internal class MockHijackCustomerRecordAdder : Exercice4.ICustomerRecordAdder
	{
		Exercice4.ICustomerRecordAdder other;

		public ICustomer lastCustomer = null;
		public IDictionary<string, ICustomer> lastDico = null;

		public MockHijackCustomerRecordAdder(ICustomerRecordAdder other)
		{
			this.other = other;
		}

		void ICustomerRecordAdder.AddCustomerRecord(ICustomer customer, IDictionary<string, ICustomer> dico)
		{
			lastCustomer = customer;
			lastDico = dico;
			other.AddCustomerRecord(customer, dico);
		}
	}
}
