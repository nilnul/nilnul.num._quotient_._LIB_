using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.op
{
	[Obsolete()]
	static public partial class SquareX
	{

		static public Q Square(this Q r)
		{
			return r * r;
		}

		static public Q1 Square(this Q1 r)
		{
			return r * r;
		}


	}
}

namespace nilnul.num.rational.op
{
	[Obsolete()]
	static public partial class SquareX
	{

		static public Rational_InheritFraction2 Square(this R r)
		{
			return r * r;
		}



	}
}
