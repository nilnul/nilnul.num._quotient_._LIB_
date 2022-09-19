using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.border.op_.unary_
{
	static public  class _ShiftX
	{
		static public Border2 Op(Q1 shift, q.Border2 border) {


			return new Border2(border.openFalseCloseTrue, shift + border.mark);
		
		}

	}
}
