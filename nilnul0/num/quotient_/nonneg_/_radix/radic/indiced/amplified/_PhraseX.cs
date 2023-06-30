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

namespace nilnul.num.quotient_.nonneg_._radix.radic.indiced.amplified
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	///
	static public class _PhraseX
	{
		static public string Phrase(
			Amplified a
		)
		{

			return $"{ a.precision}*{a.indiced}"; // as we included the base, there is no need to express each component in the base herein; To express the number in base, we can express it in such way as: 00123010.0310321000 
												   //return toTxt();
		}

		static public string _Phrase_nonneg0amplific_plural1radic_2indic(
		BigInteger a1
		,
		BigInteger r
			,
		BigInteger i
	)
		{
			return $"{a1}*{indiced._PhraseX._Phrase_plural0radic_1indic(r,i)}";
		}


		[Obsolete(nameof(_Phrase_nonneg0amplific_plural1radic_2indic) + " is prefered as that is in the same order as in txt;")]
		static public string _Phrase_plural0radic_1indic_nonneg2amplific(
		BigInteger r
		,
		BigInteger i
			,
		BigInteger a
	)
		{
			return $"{a}*{indiced._PhraseX._Phrase_plural0radic_1indic(r,i)}";
		}


	}
}