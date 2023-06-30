using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;
using System.Security;

namespace nilnul.num.quotient_.radix.recur.phrase_
{
	/// <summary>
	/// eg:
	///		1.233333....
	///		123333.33333...... 
	/// </summary>
	static public  class _EmptibleX
	{
		public const string separatorForLatterCycle = _PhraseX.SeparatorForLatterCycle;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="radix"></param>
		/// <param name="recur"></param>
		/// <returns>
		///eg:
		///	.12(3
		///	-.12(3
		/// </returns>
		/// <exception cref="Exception"></exception>
		static public string _Phrase_cycleInMantissa(
			quotient_.RadixI radix, int recur

			)
		{
			return recur_.inMantissa.phrase_._EmptibleX._Phrase_cycleInMantissa(
				to_.coerce_._IndicNonposX._IndicNonpos_1nonneg(radix,recur)
			);

		

		
		}

		static public string _Phrase_1pos1LeMantissa_2valid(
			quotient_.RadixI radix, int recur, char[] alphabet
		)
		{

			return recur_.inMantissa.phrase_._EmptibleX._Phrase_0cycleInMantissa_1valid(
				to_.coerce_._IndicNonposX._IndicNonpos_1nonneg(radix,recur),alphabet
			);

		}

	


	}
}
