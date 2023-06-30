using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.nonneg_.radix.recur
{
	/// <summary>
	/// the recur can be improper, resulting a phrase like:
	///		0123(40*10^4  =0123404040.4040...;
	///		0123(40*10-1 =01234.0404040...
	/// </summary>
	/// <remarks>
	/// no radix point
	/// </remarks>
	static public class _PhraseX
	{
		public const char Separator4recur = '(';
		public static string Separator4recurAsTxt = $"{Separator4recur}";


		static public  string _PhrasePrecision(RecurI recur)
		{
			var precisionTxt = _phrase._Insignificant1stX.PhrasePrecisionWithCycle(recur.radix.precision,recur.period);

			precisionTxt = nilnul.txt.of_.unary_._ReverseX.ToReverseAsTxt(precisionTxt);


			precisionTxt=precisionTxt.TrimEnd( radix.recur._PhraseX.Separator4recur );
			if (precisionTxt==string.Empty)
			{
				precisionTxt = "0";
			}
			return precisionTxt;

		}
		static public  string Phrase(Recur recur)
		{
			
			return $"{_PhrasePrecision(recur)}*{recur.radix.precision.radic}^{recur.indic}";
		}

	}
}
