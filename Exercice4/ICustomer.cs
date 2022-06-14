using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public interface ICustomer : IPerson, IEquatable<ICustomer>, IComparable<ICustomer>
	{
		/// <summary>
		/// Obtains the customer ID
		/// </summary>
		/// <returns>a number only string containing the customer ID</returns>
		public string GetCID();
	}
}
