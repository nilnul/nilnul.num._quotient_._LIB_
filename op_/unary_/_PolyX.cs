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



	static public class _PolyX
	{


		static public Q1 AssumeIndexNat(
			BigInteger radic,
			BigInteger index
		)
		{

			return (nilnul.num.int_.op.Pow.Eval(radic, index));



		}

		static public Q1 AssumeIndexNat(Q1 r, BigInteger index)
		{
			return
				 AssumeIndexNat(r.numerator, index)
				/
				AssumeIndexNat(r.denominator, index)
			;
		}





		




	}
}

