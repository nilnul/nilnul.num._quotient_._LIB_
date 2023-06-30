using nilnul.bit;
using nilnul.num.natural;
using nilnul.num.quotient._radix;
using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using nilnul.txt;
using nilnul.num_;

namespace nilnul.num.quotient_.nonneg_._radix.radic.indiced.amplified.of_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	///
	static public class _OfQuotientX
	{

		public const char DOT = '.';



		static public Amplified _Of_0radicPlural_1nonneg_2mantissaNonneg(
			BigInteger _root_plural,
			DenomNonnilI _nonneg
			,
			BigInteger _digitsAftDot_natural
		)
		{

			var intFrac = nilnul.num.quotient_.FlooredX.ToFloored(_nonneg); ;

			BigInteger significant = intFrac.floor;
			BigInteger remainder = intFrac.proper.en.numerator;

			BigInteger index = 0;

			while (remainder != 0)
			{
				if (_digitsAftDot_natural == 0)
				{
					break;
				}
				significant = significant * _root_plural + BigInteger.DivRem(remainder * _root_plural, _nonneg.denominator, out remainder);
				index--;
				_digitsAftDot_natural--;
			}
			return  Amplified.Of_0radic_1indic_2precision(_root_plural, index, significant);

		}




		static public Amplified _Of_0radicPlural_1nonneg_2mantissaNonneg(BigInteger radix_plural, nilnul.num.quotient.Q rational, BigInteger digits_natural)
		{

			return _Of_0radicPlural_1nonneg_2mantissaNonneg(
				radix_plural,
				denomNonnil._RegressionsX.ToDenomNonnil(rational)
				,
				(digits_natural)

			);
		}


		static public Amplified _Of_0radicPlural_1nonneg_2mantissaNonneg(
			BigInteger radix_plural,
			Rational_InheritFraction2 _rational_positive
			,
			natural.Natural_bigInteger digits
		)
		{
			return _Of_0radicPlural_1nonneg_2mantissaNonneg(
				radix_plural
				,
				denomNonnil._RegressionsX.ToDenomNonnil(_rational_positive)
				,
				digits
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="radix_plural"></param>
		/// <param name="_rational_positive"></param>
		/// <param name="digits">how many digits following the dot</param>
		/// <returns></returns>

		static public Amplified _Of_0radicPlural_1nonneg_2mantissaNonneg(
			BigInteger radix_plural,
			Rational_InheritFraction _rational_positive
			,
			natural.Natural_bigInteger digits
		)
		{
			return _Of_0radicPlural_1nonneg_2mantissaNonneg(
				radix_plural
				,
				denomNonnil._RegressionsX.ToDenomNonnil(
				_rational_positive
				)
				,
				digits
			);

		}
		static public Amplified _Of_0radicPlural_1nonneg_2mantissaNonneg(
			BigInteger _root_plural,
			Q1 _rational_positive
			,
			BigInteger _digitsAftDot_natural
		)
		{

			return _Of_0radicPlural_1nonneg_2mantissaNonneg(
				_root_plural
				,
				denomNonnil._RegressionsX.ToDenomNonnil(_rational_positive)
				,
				_digitsAftDot_natural
			);
		}





		static public Amplified _Of_0radicPlural_1nonneg_2mantissaNonneg(
			BigInteger root_plural,
			_quotient.fraction.op.Simplify.Ed1 _rational_positive
			,
			BigInteger digitsAftDot_natural
		)
		{

			return _Of_0radicPlural_1nonneg_2mantissaNonneg(
				root_plural,
				denomNonnil._RegressionsX.ToDenomNonnil(
					_rational_positive
				)
				,
				(digitsAftDot_natural)
			);

		}


		static public Amplified _Of_0radicPlural_1nonneg_2mantissaNonneg(BigInteger radix_plural, Rational_InheritFraction2 _rational_positive, BigInteger digits_natural)
		{

			return _Of_0radicPlural_1nonneg_2mantissaNonneg(
				radix_plural,
				denomNonnil._RegressionsX.ToDenomNonnil(
				_rational_positive)
				,
				(digits_natural)
			);
		}







	}
}
