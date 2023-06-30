using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.nonneg_.radix.recur._phrase
{
	static public class _Insignificant1stX
	{

		static public  string PhrasePrecisionWithCycle(num_.RadixI precision, int cycle)
		{
			var precisionTxt = nilnul.num_.radix._phrase._Insignificant1stX.Phrase(precision);

			precisionTxt = precisionTxt.Insert(cycle, "(");
			return precisionTxt;
		}
		public static string PhrasePrecisionWithCycle(num_.RadixI precision, BigInteger eeByRef)
		{
			return PhrasePrecisionWithCycle(precision,(int)eeByRef);
		}

		public static string PhrasePrecisionWithCycle(num_.RadixI precision, Num_ofIn cycle)
		{
			return PhrasePrecisionWithCycle(precision, cycle.eeByRef);
		}

	}
}
