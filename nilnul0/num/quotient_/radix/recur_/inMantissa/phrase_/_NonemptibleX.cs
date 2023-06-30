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

namespace nilnul.num.quotient_.radix.recur_.inMantissa.phrase_
{
	/// <summary>
	/// eg:
	///		1.233333....
	///		123333.33333...... 
	/// </summary>
	static public  class _NonemptibleX
	{
		public const string separatorForLatterCycle = radix.recur._PhraseX.SeparatorForLatterCycle;

		public static string _Phrase_cycleInMantissa(RecurI recurI)
		{
			return _Phrase_cycleInMantissa(recurI.radix,recurI.cycle);
		}

		public static string _Phrase_cycleInMantissa(Radix3 radix, Num_ofIn cycle)
		{
			return _Phrase_cycleInMantissa(radix,cycle.eeByRef);

		}

		public static string _Phrase_cycleInMantissa(Radix3 radix, BigInteger eeByRef)
		{
			return _Phrase_cycleInMantissa((RadixI)radix,eeByRef);

		}
		public static string _Phrase_cycleInMantissa(RadixI radix, BigInteger eeByRef)
		{
			return _Phrase_cycleInMantissa(radix,(int)eeByRef);

		}

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
			if (recur==0)
			{
				return quotient_.radix_.indicNonpos.phrase_._NonemptyBeforeDotX._Phrase_0indicNonpos(radix);
			}
			return pos.phrase_._NonemptibleX._Phrase_1pos1leMantissa(radix, recur);

		
		}

		public static string _Phrase_0cycleInMantissa_1valid(RecurI recurI, char[] alphabet)
		{
			return _Phrase_1pos1LeMantissa_2valid(recurI.radix, recurI.cycle, alphabet);
		}

		public static string _Phrase_1pos1LeMantissa_2valid(Radix3 radix, Num_ofIn cycle, char[] alphabet)
		{
			return _Phrase_1pos1LeMantissa_2valid(radix, cycle.eeByRef, alphabet);

		}

		public static string _Phrase_1pos1LeMantissa_2valid(Radix3 radix, BigInteger eeByRef, char[] alphabet)
		{
			return _Phrase_1pos1LeMantissa_2valid((RadixI)radix, eeByRef, alphabet);

		}
		public static string _Phrase_1pos1LeMantissa_2valid(RadixI radix, BigInteger eeByRef, char[] alphabet)
		{
			return _Phrase_1pos1LeMantissa_2valid(radix,(int) eeByRef, alphabet);

		}

		static public string _Phrase_1pos1LeMantissa_2valid(
			quotient_.RadixI radix, int recur, char[] alphabet
		)
		{
			if (recur==0)
			{
				return quotient_.radix_.indicNonpos.phrase_._NonemptyBeforeDotX._Phrase_0indicNonpos(radix);
			}
			return pos.phrase_._NonemptibleX._Phrase_1pos1leMantissa(radix, recur);

		}

	}
}
