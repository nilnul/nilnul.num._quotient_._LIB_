using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.border.op_
{
	public  class Shift
	{
		static public Border1 Eval(Q1 shift, q.Border1 border) {


			return new Border1(border.openFalseCloseTrue, shift + border.mark);
		
		}

	}
}
