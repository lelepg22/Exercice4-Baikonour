using Exercice4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsExo4.Mocks
{
	internal class MockPrinter : Exercice4.IPrinter
	{
		public List<string> lines = new List<string>();

		void IPrinter.PrintLine(string str)
		{
			lines.Add(str);
		}
	}
}
