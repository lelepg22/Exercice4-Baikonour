﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class CommandLineReader : ILineReader
	{
		public string line;
		public string[] readLine;
		string ILineReader.GetLine()
		{
			return line;
		}
		
		public CommandLineReader(string[] readLine)
        {

        }
	}
}
