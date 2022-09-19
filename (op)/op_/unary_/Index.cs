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

namespace nilnul.num.quotient.op_.unary_
{


	/// <summary>
	/// this is useful in positional/indexed numeral system.
	/// </summary>
	static public class _IndexX
	{

		static public Q1 RetQuotient(
			BigInteger radic,
			BigInteger index
		)
		{
			if (index<0)
			{
				return nilnul.num.quotient_.nonnil._IndexX.RetQuotient(radic, index);
			}
			
			return _PolyX.AssumeIndexNat(radic,index);

		}

		static public Q1 RetQuotient(
			Q1 radic,
			BigInteger index
		)
		{
			if (index<0)
			{
				return nilnul.num.quotient_.nonnil._IndexX.RetQuotient(radic, index);
			}
			
			return _PolyX.AssumeIndexNat(radic,index);

		}







	}
}

