using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient.radix.recur
{
	[Obsolete()]
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


		[Obsolete()]
		public  string _ToString()
		{
			 if (recurSpan == 0)
			{
				return this.radix.ToString();//.toStr_linear_0_prepended2();
			}
			var magStr = nilnul.num.natural.op.ToStrX.Do(magnitudeAsBigInt, radixAsBigInt);
			if (magStr.Length < recurSpanAsInt)
			{
				magStr = magStr.PadLeft(recurSpanAsInt, '0');
			}
			var recurPartStr = magStr.Substring(
				magStr.Length - (int)recurSpanAsBigInt
				, recurSpanAsInt
			);
			var unRecur = magStr.Length - recurPartStr.Length;
			var suffix = magStr.Substring(0, unRecur);
			var index = this.indexAsInt;
			index += recurSpanAsInt;
			while (index > 0)
			{
				index -= recurPartStr.Length;
				suffix += recurPartStr;
			}
			var offset = suffix.Length + index;
			if (offset <= 0)
			{
				suffix = "0." + nilnul.obj.str.X.Repeat(0, -(offset)) + suffix;// +magStr;// +significandStr;
			}
			else
			{
				suffix = suffix.Insert(offset, ".");
			}
			suffix += separatorForLatterCycle + recurPartStr;
			return (sign < 0 ? "-" : "") + suffix; ;
		}
	}
}
