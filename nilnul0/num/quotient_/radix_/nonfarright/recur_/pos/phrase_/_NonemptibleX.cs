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

namespace nilnul.num.quotient_.radix_.indicNonpos.recur_.pos.phrase_
{
	/// <summary>
	/// eg:
	///		1.233333....
	///		123333.33333...... 
	/// </summary>
	static public class _NonemptibleX
	{
		public const string separatorForLatterCycle = radix.recur._PhraseX.SeparatorForLatterCycle;

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
		static public string _Phrase_1pos1leMantissa(
			quotient_.RadixI radix, int recur

			)
		{
			return pos_.leMantissa.phrase_._NonemptibleX._Phrase_0indicNonpos_1posLeMantissa(
				pos.to_.coerce_._CycleInMantissaX._Radix_0indicNonpos_1pos(radix, recur)
				,
				recur
			);

		}

		static public string _Phrase_1pos1LeMantissa_2valid(
			quotient_.RadixI radix, int recur, char[] alphabet
		)
		{
			return pos_.leMantissa.phrase_._NonemptibleX._Phrase_1pos1LeMantissa_2valid(
				pos.to_.coerce_._CycleInMantissaX._Radix_0indicNonpos_1pos(radix, recur)
				,
				recur
				,
				alphabet
			);


		}




	}
}
