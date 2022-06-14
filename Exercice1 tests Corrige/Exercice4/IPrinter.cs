using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public interface IPrinter
	{
		void PrintLine(string str);
	}
	public interface IPrintable
	{
		void Print(IPrinter printer);
	}
}
