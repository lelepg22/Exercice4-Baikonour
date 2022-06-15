using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class Employee : IEmployee
	{
		public string employeeId;
		public string employeeName;
		public string employeePrint;
		public Employee(string eid, string name)
		{

			if (eid.All(Char.IsLetter))
			{
				employeeId = eid; ;
			}
			if (!eid.All(Char.IsLetter) || (eid.Length != 3))
			{
				throw new BadIDException();
			}
			
			employeeName = name;
			employeePrint = "[" + employeeId + "] " + employeeName;

		}
    
        int IComparable<IEmployee>.CompareTo(IEmployee other)
        {
            throw new NotImplementedException();
        }

<
		string IEmployee.GetEID()
		{
			return employeeId;
		}

		string IPerson.GetName()
		{
			return employeeName;
		}

		void IPrintable.Print(IPrinter printer)
		{
			printer.PrintLine(employeePrint);
		}
	}

    
    }

}
