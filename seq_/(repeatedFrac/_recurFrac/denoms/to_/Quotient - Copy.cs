using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fraction2 = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;
using Fraction = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;
using Positive = nilnul.num.natural.PositiveNatural_inheritNatural;

using Frac = nilnul.num._quotient.Fraction1;

using Q1 = nilnul.num.Quotient1;
using Positive1 = nilnul._num.bigint.be.Positive1.Asserted;
using N = nilnul._num.bigint.be.Natural.Asserted;
using System.Numerics;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient._continuedFrac.simpleProper_;

namespace nilnul.num.quotient_._recurFrac.denoms.to_
{

	static public class _ToQuotientX

	{



		static public Q1 ToQuotient(IEnumerable<num_.Positive1> _denominators_notNull)
		{

			if (_denominators_notNull.Count() == 0)
			{
				return new Q1();

			}

			return nilnul.num.quotient_.nonnil.op_.unary_._InverseX.Op(

					_denominators_notNull.First() +
					ToQuotient(_denominators_notNull.Skip(1))
				)

			;


		}

		public static Q1 ToQuotient(Denoms proper)
		{
			return ToQuotient(proper.denominators);
		}
	}
}
