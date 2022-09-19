using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;

using R1 = nilnul.num.quotient.border.duo.be_.Nonempty.En;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.range.op_
{
	[Obsolete()]
	public class Shift
	{
		static public R1 Eval(Q1 shift, R1 range) {



			return new R1(
					nilnul.num.quotient.border.op_.Shift.Eval(shift,range.lower)

					, 
					nilnul.num.quotient.border.op_.Shift.Eval(shift, range.upper)
			
			);
		
		}

	}
}
