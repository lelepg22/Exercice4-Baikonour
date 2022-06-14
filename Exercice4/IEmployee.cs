using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public interface IEmployee : IPerson, IEquatable<IEmployee>, IComparable<IEmployee>
	{
		/// <summary>
		/// Obtains the EID of the employee
		/// </summary>
		/// <returns>a 3 letter ID for an employee</returns>
		string GetEID();
	}
}
