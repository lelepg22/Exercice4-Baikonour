using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class Employee : IEmployee
	{
		public Employee(string eid, string name)
		{
			throw new NotImplementedException();
		}

		int IComparable<IEmployee>.CompareTo(IEmployee other)
		{
			throw new NotImplementedException();
		}

		bool IEquatable<IEmployee>.Equals(IEmployee other)
		{
			throw new NotImplementedException();
		}

		string IEmployee.GetEID()
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
