using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class EmployeeRecordManager
	{
		static public IEmployeeRecordAdder employeeRecordAdder = new EmployeeRecordAdder();
		static public Dictionary<string, IEmployee> dico = new Dictionary<string, IEmployee>();

		static public void LoadRecords(string filename)
		{
			throw new NotImplementedException();
		}
		static public List<IEmployee> SearchByName(string namePart)
		{
			throw new NotImplementedException();
		}
		static public IEmployee GetById(string employeeId)
		{
			throw new NotImplementedException();
		}
		static public void AddEmployeeRecord(IEmployee employee)
		{
			employeeRecordAdder.AddEmployeeRecord(employee, dico);
		}
	}
}
