using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur_.mantissaed
{
	static public class _PhraseX
	{
		static public  string Phrase(floaty.recur_.MantissaedI recur)
		{
			var insignificant1st = nilnul.txt.of_.unary_._ReverseX.ToReverseAsTxt(
				_phrase._Insignificant1stX.Phrase(recur)
			);

			/// now treat the above as txt;
			/// eg: 01230.04560(
			var r = insignificant1st.TrimEnd(
				quotient_.radix.recur._PhraseX.Separator
			);

			/// eg: 0123004560.( trimmed by above, now ended up as 0123004560.
			/// note: ( will never go before a dot;
			r = r.TrimEnd(
			   floaty._phrase._RadixPointX.CHAR
		   );
			if (r=="")
			{
				return "0";
			}
			return r;


		}
	}
}
