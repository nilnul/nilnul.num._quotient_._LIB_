using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;

using R1 = nilnul.num.quotient.Bound;//.border.duo.be_.Nonempty.En;

using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;


namespace nilnul.num.quotient.bound.op_.unary_
{
	static public class _AbsX
	{
		static public R1 Op_assumeContainZero(R1 range)
		{


			return new R1(
				nilnul.num.quotient.Border2.CreateZeroClose()
				,
				nilnul.num.quotient.border_.upper.op_.binary_._MaxX.Max(
					nilnul.num.quotient.border.op_.unary_.Abs.Singleton.op(range.lower)
					,
					nilnul.num.quotient.border.op_.unary_.Abs.Singleton.op(range.upper)
				)
			);
		}

		static public R1 Op_assumePositive(R1 range)
		{


			return range;
		}

		static public R1 Op_assumeNegative(R1 range)
		{


			return Op_assumePositive(
				q.bound.op_.unary_.Negate.Singleton.op(range)
			);
		}


		static public R1 Op_assumeNotContainNil(R1 range)
		{

			if (range.upper.mark > 0)
			{
				return Op_assumePositive(range);
			}
			return Op_assumeNegative(range);
			;
		}
		static public R1 Op(R1 range)
		{

			if (range.containsZero())
			{
				return Op_assumeContainZero(range);
			}
			return Op_assumeNotContainNil(range);
			;
		}



	}
}
