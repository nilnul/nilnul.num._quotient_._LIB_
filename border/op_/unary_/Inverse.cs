using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Q1 = nilnul.num.Quotient1;//.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.border.op_.unary_
{
	static public  class _InverseX
	{
		static public Border2 Inverse(  q.Border2 cut) {

			return new Border2(cut.openFalseCloseTrue, 1/cut.mark);
		
		}

	}
}
