using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.range.op_.unary_
{
	static public class _InverseX
	{
		static public Range1 Range(Range1 x)
		{

			return
				new Range1(
					nilnul.num.quotient.border.op_.unary_._InverseX.Inverse(x.en.upper)
					,
					nilnul.num.quotient.border.op_.unary_._InverseX.Inverse(x.en.lower)
				)
			;

		}
	
	}
}
