using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class Customer : ICustomer
	{

		string cid;
		string name;

		public Customer(string cid, string name)
		{
			if(cid.Length == 0 || !cid.All(x => Char.IsDigit(x)))
            {
				throw new BadIDException();
            }
			if(name.Length == 0)
            {
				throw new BadNameException();
            }
			this.cid = cid;
			this.name = name;
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
			return cid;
		}

		string IPerson.GetName()
		{
			return name;
		}

		void IPrintable.Print(IPrinter printer)
		{
			printer.PrintLine("[" + cid + "] " + name);
		}
	}
}
