using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur._phrase
{
	static public class _Insignificant1stX
	{
		static public  string PhrasePrecision(floaty.Recur recur)
		{
			var floatyAsTxt = radix_.floaty._phrase._Little1stX.Phrase(recur.floaty);

			if (recur.period > recur.floaty.mantissa)
			{
				return floatyAsTxt.Insert(
					(int)(recur.period.eeByRef + 1), num.quotient_.radix.recur._PhraseX.SeparatorForLatterCycle
				);
			}
			/// put recur separator before point, especially in case 01230.(0456, or 01230.(
			return floatyAsTxt.Insert(
				(int)(recur.period.eeByRef), num.quotient_.radix.recur._PhraseX.SeparatorForLatterCycle
			);

		}
	}
}
