using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.quotient_.radix.recur
{
	public class Binary
		:Recur
	{
		public Binary(BigInteger significand, BigInteger index,BigInteger span)
			:base(2,significand,index,span)
		{

		}

		static public Binary _FroQuotient(Q1 x, BigInteger _natural__digitsAfterDo)
		{

			var t = Recur._FroQuotient(2, x,_natural__digitsAfterDo);
			return new Binary(t.significand, t.indexAsBigInt, t.recurSpan);


		}

		static public Binary FroQuotient(Q1 q) {
			var t = Recur._FroQuotient(2, q);
			return new Binary(t.significand, t.indexAsBigInt, t.recurSpan);
		}

		static public Binary FroQuotient(int x, int y) {
			return FroQuotient(new Q1(x,y));
		}


	
	}
}
