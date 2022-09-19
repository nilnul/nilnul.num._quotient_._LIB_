using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.border.op_
{
	[Obsolete(nameof(unary_._ShiftX))]
	public  class Scale
	{
		static public Border1 Eval(Q1 scale, q.Border1 cut) {


			return new Border1(cut.openFalseCloseTrue, scale * cut.mark);
		
		}

	}
}
