using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur_.mantissaed._phrase
{
	static public class _Insignificant1stX
	{
		static public  string Phrase(floaty.recur_.MantissaedI recur)
		{
			var floatyAsTxt = radix_.floaty._phrase._Little1stX.Phrase(recur.floaty);

			return floatyAsTxt.Insert(
				(int)(recur.period.eeByRef)
				,
				num.quotient_.nonneg_.radix.recur._PhraseX.Separator4recurAsTxt
			);

		}
	}
}
