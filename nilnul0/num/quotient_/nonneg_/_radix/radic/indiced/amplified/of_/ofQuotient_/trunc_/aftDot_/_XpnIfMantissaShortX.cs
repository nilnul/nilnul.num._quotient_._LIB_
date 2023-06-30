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

namespace nilnul.num.quotient_.nonneg_._radix.radic.indiced.amplified.of_.ofQuotient_.trunc_.aftDot_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	///
	static public class _XpnIfMantissaShortX
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
				significant = significant * _root_plural + BigInteger.DivRem(remainder * _root_plural, _nonneg.denominator, out remainder);
				index--;
				if (_digitsAftDot_natural == 0)
				{
					throw new quotient_._radix.xpn_.OverlongException(
						$"{_nonneg} being converted to magnificed based {_root_plural},  the mantissa might too long or cyclic, exceeding :{_digitsAftDot_natural};"
					);
				}
				_digitsAftDot_natural--;
			}
			return  Amplified.Of_0radic_1indic_2precision(_root_plural, index, significant);
		}
	
		static public Amplified _Of_0radicPlural_1nonneg_2mantissaNonneg(
			BigInteger _root_plural,
			Q1 _nonneg
			,
			BigInteger _digitsAftDot_natural
		)
		{
			
			return _Of_0radicPlural_1nonneg_2mantissaNonneg(
				_root_plural, denomNonnil._RegressionsX.ToDenomNonnil(_nonneg),_digitsAftDot_natural
			);
		}

	







	}
}