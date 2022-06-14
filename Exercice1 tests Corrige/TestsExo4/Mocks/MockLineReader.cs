using Exercice4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsExo4.Mocks
{
	internal class MockLineReader : Exercice4.ILineReader
	{
		string[] lines;
		int idx = 0;

		public MockLineReader(string[] lines)
		{
			if (lines.Length == 0) throw new ArgumentException("Expected at least a line");
			this.lines = lines;
		}

		string ILineReader.GetLine()
		{
			if (idx >= lines.Length) throw new Exception("Not enough lines");
			string ret = lines[idx];
			idx++;
			return ret;
		}
	}
}
