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

namespace nilnul.num.quotient_.radix.recur.phrase_
{
	/// <summary>
	/// </summary>
	static public  class _DwellIntX
	{
		static public string Phrase(Recur8unsignedI recur)
		{
			return $@"{(recur.negated?"-":"")}{
				quotient_.nonneg_.radix.recur.phrase_._DwellIntX.Phrase(
					recur.unsigned
				)
			}";
		}
		static public string Phrase(Recur1 recur)
		{
			return Phrase((Recur8unsignedI)recur);
		}
	}
}
