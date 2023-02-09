using Q1 = nilnul.num.Quotient1;
using System.Numerics;
using System;

namespace nilnul.num.quotient.op_.unary_
{
	static public class _AbsX
	{
		static public Q1 Op(Q1 x) {
			return new Q1(BigInteger.Abs( x.numerator), x.denominator );
		}

		public static quotient_.DenomNonnil Op(quotient_.DenomNonnilI x)
		{
			return new quotient_.DenomNonnil(BigInteger.Abs( x.numerator),BigInteger.Abs( x.denominator ));

		}
		public static quotient_.DenomNonnil Op(quotient_.DenomNonnil x)
		{
			return new quotient_.DenomNonnil(BigInteger.Abs( x.numerator),BigInteger.Abs( x.denominator ));

		}


	}


}
