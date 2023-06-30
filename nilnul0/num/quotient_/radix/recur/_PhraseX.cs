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

namespace nilnul.num.quotient_.radix.recur
{
	/// <summary>
	/// it's not <see cref="radix_.floaty"/> yet, so we have no point in the phrase;
	/// eg:
	///		""*10^1 populated to  0 * 10^1  
	///		(0*10^1
	///		0*10^1 
	///		0( *10^1 trimmed to 0 * 10^1
	/// </summary>
	static public  class _PhraseX
	{
		[Obsolete(nameof(quotient_.nonneg_.radix.recur._PhraseX.Separator4recur))]
		public const char Separator = quotient_.nonneg_.radix.recur._PhraseX.Separator4recur;

		[Obsolete(nameof(quotient_.nonneg_.radix.recur._PhraseX.Separator4recur))]
		public static string SeparatorForLatterCycle = quotient_.nonneg_.radix.recur._PhraseX.Separator4recur.ToString(); // "("; 
		static public string Phrase(Recur8unsignedI recur)
		{
			return $"{(recur.negated?"-":"")}{recur.unsigned}";

	
		}
		static public string Phrase(Recur1 recur)
		{
			return Phrase((Recur8unsignedI)recur);

			//var precisionTxt = nonneg_.radix.recur._phrase._Insignificant1stX.PhrasePrecisionWithCycle(recur.radix.signific.abs, recur.cycle);

			//precisionTxt = precisionTxt.TrimStart(nonneg_.radix.recur._PhraseX.Separator4recur);

			///// we cannot always express this in pointed format; to present this in pointed format, convert this to <see cref="radix_.floaty.RecurI"/>
			//return $"{(recur.radix.signific.negated?"-":"")}{nilnul.txt.of_.unary_._ReverseX.ToReverseAsTxt(precisionTxt)}*{recur.radix.signific.abs.radic}^{recur.indic}";
		}


	}
}
