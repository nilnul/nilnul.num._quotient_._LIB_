using nilnul.num._quotient.fraction.op;
using nilnul.num.rational;
using System;

namespace nilnul.num.quotient_.denomNonnil
{
	static public class _RegressionsX
	{
		static public nilnul.num.quotient_.DenomNonnil ToDenomNonnil(
			this
			nilnul.num.QuotientI1 q
		)
		{
			return new quotient_.DenomNonnil(q.numerator, q.denominator1);
		}

		static public nilnul.num.Quotient1 ToStd(
			this
			nilnul.num.quotient_.DenomNonnil q
		)
		{
			return  Quotient1.CreateByDivide (q.numerator, q.denominator);
		}


		public static DenomNonnil ToDenomNonnil(this Rational_InheritFraction2 rational_positive)
		{
			return new DenomNonnil(
				rational_positive.numerator1,rational_positive.denominator
			);
		}

		public static DenomNonnil ToDenomNonnil(this Simplify.Ed1 rational_positive)
		{
			return new DenomNonnil(
				rational_positive.numerator,rational_positive.denominator.val
			);

		}

		public static DenomNonnil ToDenomNonnil(this Rational_InheritFraction rational_positive)
		{
			return new DenomNonnil(
				rational_positive.numerator,rational_positive.denominator
			);


		}
	}
}
