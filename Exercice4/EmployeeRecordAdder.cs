using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	internal class EmployeeRecordAdder : IEmployeeRecordAdder
	{
		void IEmployeeRecordAdder.AddEmployeeRecord(IEmployee employee, IDictionary<string, IEmployee> dico)
		{

			dico.Add(employee.GetEID(), employee);

		}
	}
}
