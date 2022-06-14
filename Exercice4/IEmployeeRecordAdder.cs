using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public interface IEmployeeRecordAdder
	{
		void AddEmployeeRecord(IEmployee employee, IDictionary<string, IEmployee> dico);
	}
}
