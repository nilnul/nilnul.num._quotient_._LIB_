using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.op_.binary_
{
	static public class _AbsMaxX
	{
		static public nilnul.num.Quotient1 AbsMax(nilnul.num.Quotient1 x, nilnul.num.Quotient1 y) {
			return nilnul.num.QuotientX.Abs( x) >= nilnul.num.QuotientX.Abs( y) ? x : y;
		}
	}
}
