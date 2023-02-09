using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Rational_InheritFraction2 = nilnul.num.quotient.Q;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num.quotient_.DenomNonnilI;//._quotient.fraction.op.Simplify.Ed1;
using nilnul.num._quotient.fraction.op;
using nilnul.num.natural.__bigint.be;
using nilnul.num.natural.be;
using nilnul._num.bigint.be_;
using nilnul.num.quotient_;

namespace nilnul.num.quotient.of_.unary_
{


	/// <summary>
	/// this is useful in positional/indexed numeral system.
	/// </summary>
	static public class _IndicX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="radic"></param>
		/// <param name="index"></param>
		/// <returns></returns>
		/// <exception cref=""> when index is neg, and when radic is nil</exception>

		static public DenomNonnil DenomNonnil(
			BigInteger radic,
			BigInteger index
		)
		{
			if (index<0)
			{
				return nilnul.num.quotient_.nonnil.of_.unary_._IndicX.DenomNonnil_indicAssumeNeg(radic, index);
			}
			
			return _PonentX.DenomNonnil_ponentAssumeNat(radic,index);

		}



		static public DenomNonnil DenomNonnil(
			Q1 radic,
			BigInteger index
		)
		{
			if (index<0)
			{
				return nilnul.num.quotient_.nonnil.of_.unary_._IndicX.DenomNonnil_indicAssumeNeg(radic, index);
			}
			
			return _PonentX.DenomNonnil_ponentAssumeNat(radic,index);

		}







	}
}

