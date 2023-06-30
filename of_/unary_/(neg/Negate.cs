using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num._quotient.fraction.Simplified;
using System.Numerics;
using nilnul.num.rational.op;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.op
{
	[Obsolete()]
	public class Negate

	{
		

		


		static public Q1 Eval(Q1 x) {
			return new Q1(-( x.fraction.numerator), x.fraction.denominator);
		}




		
	}


}
