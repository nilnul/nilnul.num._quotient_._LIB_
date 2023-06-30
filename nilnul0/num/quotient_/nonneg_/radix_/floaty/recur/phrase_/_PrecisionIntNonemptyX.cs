using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur.phrase_
{
	/// <summary>
	/// the recur can be improper, resulting a phrase like: 0123(004560;
	/// for proper recur, <see cref="recur_.Mantissaed"/>
	/// </summary>
	static public class _PrecisionIntNonemptyX
	{
		public const char Separator4recur = radix.recur._PhraseX.Separator4recur;

		static public string _PhrasePrecision(floaty.Recur recur)
		{
			var r = _PhraseX._PhrasePrecision(recur);
			return radix_.floaty.phrase_._dweltInt._TxtX.DwellInt(r);
		}

		static public string Phrase(floaty.Recur recur)
		{
			return $"{_PhrasePrecision(recur)}";

			return $"{_PhrasePrecision(recur)}*{_radix.radic.indiced._PhraseX._Phrase_plural0radic_1indic(recur.precision.radic, recur.indic)}";
		}

	}
}
