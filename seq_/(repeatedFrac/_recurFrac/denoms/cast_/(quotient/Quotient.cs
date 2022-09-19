using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fraction2 = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;
using Fraction = nilnul.num.rational.Fraction_BigInteger_PositiveNatural3_;
using Positive = nilnul.num.natural.PositiveNatural_inheritNatural;

using Frac = nilnul.num._quotient.Fraction1;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Positive1 = nilnul._num.bigint.be.Positive1.Asserted;
using N = nilnul._num.bigint.be.Natural.Asserted;
using System.Numerics;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient._continuedFrac.simpleProper_;

namespace nilnul.num.quotient._continuedFrac.simpleProper.to_
{

	[Obsolete(nameof(quotient_._recurFrac. denoms.to_._ToQuotientX))]
	public class Quotient
		:nilnul.obj._to_.ToI<simpleProper_.ForQ, Q1>
		,
		nilnul.obj._to_.ToI<simpleProper_.ForIrrational,Q1>

	{




		static private Q1 _ToQuotient(IEnumerable<Positive1> _denominators_notNull)
		{

			if (_denominators_notNull.Count() == 0)
			{
				return new Q1();

			}

			return nilnul.num.quotient_.nonzero.op_._inverse.Extensions._Inverse(

					_denominators_notNull.First().val +
					_ToQuotient(_denominators_notNull.Skip(1))
				)

			;


		}

		public Q1 to(simpleProper_.ForQ src)
		{

			return _ToQuotient(src.denominators);
			//throw new NotImplementedException();
		}

		public Q1 to(ForIrrational src)
		{

			return _ToQuotient(src.denominators);

			//throw new NotImplementedException();
		}

		static public readonly Quotient Singleton = SingletonByDefault<Quotient>.Instance;

	}
}
