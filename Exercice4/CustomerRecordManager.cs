using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class CustomerRecordManager
	{
		static Dictionary<string, ICustomer> customers = new Dictionary<string, ICustomer>();
		static public ICustomerRecordAdder customerRecordAdder = new CustomerRecordAdder();

		static void LoadRecords(string filename)
		{
			throw new NotImplementedException();
		}
		static List<ICustomer> SearchByName(string namePart)
		{
			throw new NotImplementedException();
		}
		static ICustomer GetById(string customerId)
		{
			throw new NotImplementedException();
		}
		static void AddCustomerRecord(ICustomer customer)
		{
			customerRecordAdder.AddCustomerRecord(customer, customers);
		}
	}
}
