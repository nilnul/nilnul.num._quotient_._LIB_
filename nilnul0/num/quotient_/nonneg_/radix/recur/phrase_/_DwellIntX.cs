using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.nonneg_.radix.recur.phrase_
{
	/// <summary>
	/// eg:
	///		.3 * 10^ 1   ->  0.3*10^1
	/// </summary>
	static public class _DwellIntX
	{


		static public  string _PhrasePrecision(RecurI recur)
		{
			return radix_.floaty.phrase_._dweltInt._TxtX.DwellInt(
				_PhraseX._PhrasePrecision(recur)
			);

		}
		static public  string Phrase(RecurI recur)
		{
			
			return $"{_PhrasePrecision(recur)}*{recur.radix.precision.radic}^{recur.radix.indic}";
		}

		public static string Phrase(Recur recur)
		{
			return $"{_PhrasePrecision(recur)}*{recur.radix.precision.radic}^{recur.radix.indic}";

		}
	}
}
