using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.radix_.indicNonpos.recur
{
	/// <summary>
	/// eg:
	///		1.233333....
	///		123333.33333...... | 12333(3.but we generally only allow recurrence in mantissa part;
	/// </summary>
	static public  class _PhraseX
	{
		public const string separatorForLatterCycle = radix.recur._PhraseX.separatorForLatterCycle;


		/// <summary>
		/// 
		/// </summary>
		/// <param name="radix"></param>
		/// <param name="recur"></param>
		/// <returns></returns>
		/// <exception cref="Exception"></exception>
		static public string _Phrase_0radicLe16_1nonneg(quotient_.radix_.IndicNonpos radix, int recur)
		{
			var radic = (int)radix.radic.eeByRef;

			var alphabet = nilnul.character.sortie_.alphabet_.radix_.Hex.Chars.Take(
				radic
			).ToArray();
			if (recur == 0)
			{

				return radix._phraseWithDot_0valid(alphabet);

			}

			return recur_.pos._PhraseX._Phrase_0radicLe16_1positive(radix, recur);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="radix"></param>
		/// <param name="recur"></param>
		/// <returns></returns>
		/// <exception cref="Exception"></exception>
		static public string _Phrase_1nonneg(quotient_.radix_.IndicNonpos radix, int recur)
		{
			var radic = (int)radix.radic.eeByRef;

			if (radic > 16)
			{
				throw new Exception("We need an alphabet; but now for 17 or more, we have no default one;");
			}
			return _Phrase_0radicLe16_1nonneg(radix, recur);

	
		}
	}
}
