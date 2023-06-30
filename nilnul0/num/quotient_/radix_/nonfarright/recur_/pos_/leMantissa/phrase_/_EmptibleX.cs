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

namespace nilnul.num.quotient_.radix_.indicNonpos.recur_.pos_.leMantissa.phrase_
{
	/// <summary>
	/// eg:
	///		1.233333....
	///		123333.33333...... 
	/// </summary>
	static public  class _EmptibleX
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
			quotient_.radix_.IndicNonpos radix, int recur

			)
		{
			return _Phrase_0indicNonpos_1posLeMantissa(radix,recur);
			
		}
		public static string _Phrase_0indicNonpos_1posLeMantissa(RadixI radix, int recur)
		{
			var radic = (int)radix.signific.abs.root.ed.val;

			var sb = new StringBuilder(quotient_.radix_.indicNonpos.phrase_._EmptibleX._Phrase_0indicNonpos(radix));

			sb.Insert(recur, separatorForLatterCycle);

			return sb.ToString();

		}

		static public string _Phrase_1pos1LeMantissa_2valid(
			quotient_.radix_.IndicNonpos radix, int recur, char[] alphabet
		)
		{
			var radic = (int)radix.radic.eeByRef;

			var sb = new StringBuilder(quotient_.radix_.indicNonpos.phrase_._EmptibleX._Phrase_1valid(radix,alphabet));

			sb.Insert(recur, separatorForLatterCycle);

			return sb.ToString();
		}
		public static string _Phrase_1pos1LeMantissa_2valid(RadixI radix, int recur, char[] alphabet)
		{
			var radic = (int)radix.signific.abs.root.ed.val;

			var sb = new StringBuilder(quotient_.radix_.indicNonpos.phrase_._EmptibleX._Phrase_0indicNonpos_1valid(radix,alphabet));

			sb.Insert(recur, separatorForLatterCycle);

			return sb.ToString();

		}

	}
}
