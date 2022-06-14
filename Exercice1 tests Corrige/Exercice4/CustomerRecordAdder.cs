using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	internal class CustomerRecordAdder : ICustomerRecordAdder
	{
		void ICustomerRecordAdder.AddCustomerRecord(ICustomer customer, IDictionary<string, ICustomer> dico)
		{
			dico.Add(customer.GetCID(), customer);
		}
	}
}
