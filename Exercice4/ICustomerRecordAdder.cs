using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public interface ICustomerRecordAdder
	{
		void AddCustomerRecord(ICustomer customer, IDictionary<string, ICustomer> dico);
	}
}
