using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public interface ICompanyNoteRecordAdder
	{
		void AddNoteRecord(ICompanyNote note, IDictionary<string, ICompanyNote> dico);
	}
}
