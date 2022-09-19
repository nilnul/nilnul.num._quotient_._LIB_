using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.sortie
{
	static public class _FindX
	{
		static public (int?, int?) _IndexRange_assumeSortie(
			IEnumerable<nilnul.num.QuotientI1 > sortie
			,
			nilnul.num.QuotientI1 el
		) {
			return nilnul.obj.sortie._FindX._IndexRange(sortie, el, nilnul.num.quotient.Comparer2.Singleton);
		}
	}
}
