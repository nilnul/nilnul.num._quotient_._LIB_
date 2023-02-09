using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Rational_InheritFraction2 = nilnul.num.quotient.Q;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using nilnul.num._quotient.fraction.op;
using nilnul.num.natural.__bigint.be;
using nilnul.num.natural.be;
using nilnul._num.bigint.be_;
using nilnul.num.quotient_;

namespace nilnul.num.quotient.of_.unary_
{


	/// <summary>
	/// the index is natural number; no negative values are allowed;
	/// </summary>
	/// alias:
	///		ponent
	///		pon
	static public class _PonentX
	{


		static public DenomNonnil DenomNonnil_ponentAssumeNat(
			BigInteger radic,
			BigInteger index
		)
		{
			return  (nilnul.num.int_.op.Pow.Eval(radic, index));


		}

		static public num.quotient_.DenomNonnil DenomNonnil_ponentAssumeNat(num.quotient_.DenomNonnilI r, BigInteger index)
		{
			return
				 DenomNonnil_ponentAssumeNat(r.numerator, index)
				/
				DenomNonnil_ponentAssumeNat(r.denominator, index)
			;
		}





		




	}
}

