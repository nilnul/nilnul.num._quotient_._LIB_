using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;
using nilnul.bit.op_.unary_.not;

namespace nilnul.num.quotient_.radix.recur.to_
{

	static public class _ToQuotientX
	{


		static public Quotient1 ToQuotient1(
			this Recur p
		)
		{

			var recurPart = p.recurPart();

			return (p.significand - recurPart) * nilnul.num.quotient.op_.unary_._PolyX.AssumeIndexNat(p.radixAsBigInt, p.indexAsBigInt)
				+

				nilnul.num.Quotient1.CreateByDivide(
					recurPart
					,
					nilnul.num.int_.op.PowX.Eval_basePlural_indexNoNeg(p.radixAsBigInt, p.recurSpanAsBigInt) - 1
				)
				*
				  nilnul.num.quotient.op_.unary_._PolyX.AssumeIndexNat(p.radix.base_.rootAsBigint, (p.recurSpan

				  +
					p.indexAsBigInt     //this is usually negative.

				  ))
			;


		}

	}
}
