using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num._quotient.fraction.Simplified;
using System.Numerics;




namespace nilnul.num.rational.op
{
	[Obsolete()]
	public partial class Abs
		:UnaryI

	{
		static public R Eval(R x) {
			return x.toAbs();
		}

		public Rational_InheritFraction2 eval(Rational_InheritFraction2 arg)
		{
			return Eval(arg);
			throw new NotImplementedException();
		}
	}


}
