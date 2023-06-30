using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num.QuotientI;



namespace nilnul.num.quotient.str
{
	static public class _SumX
	{
		static public num.Quotient1 Sum(this IEnumerable<num.Quotient1> str)
		{
			var r = num.Quotient1.CreateZero();

			foreach (var item in str)
			{
				r += item;
			}
			return r;
		}

		static public quotient_.DenomNonnil Sum(this IEnumerable<num.quotient_.DenomNonnil> str)
		{
			var r = num.quotient_.DenomNonnil.Nil;

			foreach (var item in str)
			{
				r += item;
			}
			return r;
		}


		static public Q1 Sum(nilnul.num.quotient.stream.Take take) {
			Q1 r = new nilnul.num.Quotient();

			var count = take.count;
			var countBigint = count.toBigint();
			while (countBigint-->0)
			{
				r = nilnul.num.quotient.combine_.Add.Instance.eval(
					r,
					take.stream.next()
				);
			}

			return r;
		}
	}
}
