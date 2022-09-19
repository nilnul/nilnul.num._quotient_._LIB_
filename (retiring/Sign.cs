using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient
{
	[Obsolete()]
	static public class _SignX
	{
		static public bool? Sign(
			nilnul.num.Quotient q
		) {
			return nilnul.num.integer._SignX.Sign(q.numerator);
		}
	}
}
