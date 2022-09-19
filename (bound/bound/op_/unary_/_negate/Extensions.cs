using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.quotient.border.duo.be_;
using R1 = nilnul.num.quotient.border.duo.be_.Nonempty.En;

namespace nilnul.num.quotient.range.op_._negate
{
	[Obsolete(nameof(range.op_.unary_._NegateX))]
	public static class Extensions
	{
		static public R1 Negate(this R1 x) {
			return new R1(
			-(x.upper)
				,
				-(x.lower)
				
			);
		}

		
	}
}
