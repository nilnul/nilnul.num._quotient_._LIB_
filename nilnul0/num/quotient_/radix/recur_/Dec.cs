using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient_.radix.recur_
{
	public class Dec
		:Recur
	{
		public Dec(BigInteger significand, BigInteger index,BigInteger span)
			:base(10,significand,index,span)
		{

		}

		static public Dec _FroQuotient(Q1 x, BigInteger _natural__digitsAfterDo)
		{

			var t = Recur._FroQuotient(10, x,_natural__digitsAfterDo);
			return new Dec(t.significand, t.indexAsBigInt, t.recurSpan);


		}

		static public Dec FroQuotient(Q1 q) {
			var t = Recur._FroQuotient(10, q);
			return new Dec(t.significand, t.indexAsBigInt, t.recurSpan);
		}

		static public Dec FroQuotient(int x, int y) {
			return FroQuotient(new Q1(x,y));
		}


	
	}
}
