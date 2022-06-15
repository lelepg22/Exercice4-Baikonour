using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class Customer : ICustomer
	{
<<<<<<< HEAD
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
=======

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
>>>>>>> second
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
<<<<<<< HEAD
			
			return clientId;
		
			
=======
			return cid;
>>>>>>> second
		}

		string IPerson.GetName()
		{
<<<<<<< HEAD
			return clientName;
=======
			return name;
>>>>>>> second
		}

		void IPrintable.Print(IPrinter printer)
		{
<<<<<<< HEAD
			printer.PrintLine(clientPrint);
=======
			printer.PrintLine("[" + cid + "] " + name);
>>>>>>> second
		}
	}
}
