using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.op_
{
	[Obsolete()]
	static public  class _SquareX
	{


		static public Q1 Square(this Q1 r)
		{
			return r * r;
		}


	}
}
