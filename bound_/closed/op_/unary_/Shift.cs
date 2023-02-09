using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;

using R1 = nilnul.num.quotient.bound_.Closed;//.border.duo.be_.Nonempty.En;

using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.bound_.closed.op_.unary_
{
	static public class _ShiftX
	{
		static public R1 Op(Q1 shift, R1 range) {



			return new R1(
					shift+range.lower

					, 
					shift+ range.upper
			
			);
		
		}

	}
}
