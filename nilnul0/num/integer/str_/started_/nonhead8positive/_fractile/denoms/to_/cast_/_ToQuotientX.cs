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
using nilnul.num.natural;
using nilnul.num.rational;

namespace nilnul.num.integer.str_.started_.nonhead8positive._fractile.denoms.to_.cast_
{

	static public class _ToQuotientX

	{
		/// <summary>
		/// tail recursion;
		/// </summary>
		/// <param name="denominators_notNull"></param>
		/// <returns></returns>
		static public Rational_InheritFraction To__Rational_InheritFraction(IEnumerable<PositiveNatural_inheritNatural> denominators_notNull)
		{

			if (denominators_notNull.Count() == 0)
			{
				return new Rational_InheritFraction();

			}

			return Rational_InheritFraction.Inverse(Rational_InheritFraction.Add(

					denominators_notNull.First(),

					To__Rational_InheritFraction(denominators_notNull.Skip(1))
				))

			;


		}


		static public Q1 ToQuotient1(IEnumerable<num_.Positive1> _denominators_notNull)
		{

			if (_denominators_notNull.Count() == 0)
			{
				return new Q1();

			}

			return nilnul.num.quotient_.nonnil.op_.unary_._InverseX.Op(

					_denominators_notNull.First() +
					ToQuotient1(_denominators_notNull.Skip(1))
				)

			;


		}

		public static Q1 ToQuotient(Denoms proper)
		{
			return ToQuotient1(proper.denominators);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="enumerable">started; nonhead8positive;</param>
		/// <returns></returns>
		public static num.quotient_.DenomNonnil _ToDenomNonnil_0fractile(IEnumerable<int> enumerable)
		{
			if (enumerable.Any())
			{
				return 1/(
					enumerable.First()+ _ToDenomNonnil_0fractile(enumerable.Skip(1) )
				);
			}

			return 0;

		}
	}
}
