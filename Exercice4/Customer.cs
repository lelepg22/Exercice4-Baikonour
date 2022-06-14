using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class Customer : ICustomer
	{
		public string clientId;
		public string clientName;
		public string clientPrint;
		public int val;
		public Customer(string cid, string name)
		{
			if (cid.All(Char.IsDigit))
			{
				 clientId = cid; ;
			}
			if (!cid.All(Char.IsDigit))
			{
				throw new BadIDException();
			}
			
			clientName = name;
			clientPrint = "[" +clientId +"] " + clientName;
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
			if (clientId.All(Char.IsDigit)) { 
			return clientId;
			}
			throw new NotImplementedException();
		}

		string IPerson.GetName()
		{
			return clientName;
		}

		void IPrintable.Print(IPrinter printer)
		{
			printer.PrintLine(clientPrint);
		}
	}
}
