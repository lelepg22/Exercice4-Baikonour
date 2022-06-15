using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class Customer : ICustomer
	{
		public Customer(string cid, string name)
		{
			throw new NotImplementedException();
		}

		int IComparable<ICustomer>.CompareTo(ICustomer other)
		{
			throw new NotImplementedException();
		}

		bool IEquatable<ICustomer>.Equals(ICustomer other)
		{
			throw new NotImplementedException();
		}

		string ICustomer.GetCID()
		{
			throw new NotImplementedException();
		}

		string IPerson.GetName()
		{
			throw new NotImplementedException();
		}

		void IPrintable.Print(IPrinter printer)
		{
			throw new NotImplementedException();
		}
	}
}
