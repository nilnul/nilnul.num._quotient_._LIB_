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

	

	public  class Poly
	{



		static public Q1 Eval(
			BigInteger radic,
			BigInteger index
		)
		{
			if (index >= 0)
			{
				return new Q1(nilnul.num.int_.op.Pow.Eval(radic, index));

			}
			throw new Exception($"{index} cannot be negative");
			//return new Q1(1, nilnul.num.int_.op.Pow.Eval(radic, -index));

			//throw new NotImplementedException();
		}

		static public Q1 Eval(Q1 r, BigInteger index)
		{
			return 
				 Eval(r.numerator, index)
				/
				Eval(r.denominator, index)
			;
		}



		static public Q1 OneTenthPoly(BigInteger _nonNeg) {
			return Eval( Q1.CreateUnit(10) , _nonNeg );
		}

		public  static Q1 Op(Q1 par, quotient_.Natural natural)
		{
			return Eval(par, natural.numerator);

		}
		public  static Q1 Op(Q1 par, nilnul.Num1 natural)
		{
			return Eval(par, natural.en);

		}

		public  static Q1 Op(Q1 par, nilnul.NumI1 natural)
		{
			return Eval(par, natural.toBigint());

		}

	}
}

