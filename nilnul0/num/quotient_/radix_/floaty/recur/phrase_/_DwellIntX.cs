using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.radix_.floaty.recur.phrase_
{
	static public class _DwellIntX
	{
		static public  string Phrase(floaty.Recur recur)
		{
			
			return  $"{num._integer_.negated.Phrase.Singleton.phrase(recur.negated)}{nonneg_.radix_.floaty.recur.phrase_._PrecisionIntNonemptyX.Phrase(recur.unsignedFloatyRecur)}";


		}
	}
}
