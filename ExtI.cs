using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient
{
	public  interface ExtI
		:
		nilnul.ExtI<Q1>
		,
		nilnul.ExtI<nilnul.num.quotient_.DenomNonnilI>

	{

	}
}
