using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction2;

using R1 = nilnul.num.quotient.bound_.Closed;//.border.duo.be_.Nonempty.En;

using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;


namespace nilnul.num.quotient.bound_.closed.op_.unary_
{
	static public class _SqureX
	{
		static public R1 Op_assumeContainNil( R1 range) {

			var lowerAbs = nilnul.num.quotient.op_.unary_.Abs.Singleton.op(range.lower);

			var upperAbs = nilnul.num.quotient.op_.unary_.Abs.Singleton.op(range.upper);
			var max = nilnul.num.quotient.op_.binary_._MaxX.Max(
				lowerAbs
				,
				upperAbs
			);

			return new R1(
					0
					, 
					nilnul.num.quotient.op_.unary_._SquareX.Square(max)
			);
		}

		static public R1 Op_assumePositive( R1 range) {

			

			return new R1(
					nilnul.num.quotient.op_.unary_._SquareX.Square(range.lower)
					, 
					nilnul.num.quotient.op_.unary_._SquareX.Square(range.upper)
			);
		}

		static public R1 Op_assumeNegative( R1 range) {


			return Op_assumePositive(
				q.bound_.closed.op_.unary_.Negate.Singleton.op(range)
			);
		}


		static public R1 Op_assumeNotContainNil( R1 range) {

			if (range.upper.mark>0)
			{
				return Op_assumePositive(range);
			}
			return Op_assumeNegative(range);
			;
		}
		static public R1 Op( R1 range) {

			if (range.containsZero())
			{
				return Op_assumeContainNil(range);
			}
			return Op_assumeNotContainNil(range);
			;
		}



	}
}
