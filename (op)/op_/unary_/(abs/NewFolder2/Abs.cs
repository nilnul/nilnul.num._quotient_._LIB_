using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num._quotient.fraction.Simplified;
using System.Numerics;
using nilnul.num.rational.op;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.op_
{
	[Obsolete()]
	public  class Abs

	{
		



		static public Q1 Eval(Q1 x) {
			return new Q1(BigInteger.Abs( x.fraction.numerator), x.fraction.denominator);
		}




	}


}
