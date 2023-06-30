using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient
{
	[Obsolete()]
	public partial class Border1
		:nilnul.Border<Q1>
	{
		public Border1(bool openFalseCloseTrue, Q1 bound)
			:base(openFalseCloseTrue,bound)
		{

		}

		static public Border1 Multi(Border1 x, Border1 y) {

			return new Border1(x.openFalseCloseTrue && y.openFalseCloseTrue, x.mark * y.mark);
		}

		static public Border1 operator *(Border1 x, Border1 y) {
			return Multi(x, y);
		}

		static public Border1 Abs(Border1 x) {
			return new Border1(
				x.openFalseCloseTrue
				,
				nilnul.num.quotient.op.Abs.Eval(
				x.mark
				)
			);
		}

		static public Border1 CreateZeroClose() {
			return new Border1(true, 0);
		}

		static public Border1 CreateClose(Q1 mark) {
			return new Border1(true, mark);
		}
		static public Border1 CreateOpen(Q1 mark) {
			return new Border1(false, mark);
		}


		static public Border1 Add(Border1 x,Border1 y) {
			return new Border1(
				x.openFalseCloseTrue&&y.openFalseCloseTrue
				,
				x.mark+y.mark	
			);
		}
		static public Border1 Add(Border1 x,BigInteger y) {
			return new Border1(
				x.openFalseCloseTrue
				,
				x.mark+y	
			);
		}

		static public Border1 operator -(Border1 x)
		{
			return new Border1(
				x.openFalseCloseTrue
				,
				op.Negate.Eval(x.mark)
			);
		}

		static public Border1 operator +(Border1 x,BigInteger y) {
			return new Border1(
				x.openFalseCloseTrue
				,
				x.mark+y	
			);
		}


		static public Border1 operator +(Border1 x,Border1 y) {
			return new Border1(
				x.openFalseCloseTrue && y.openFalseCloseTrue
				,
				x.mark+y.mark	
			);
		}


		static public Border1 Negate(Border1 x) {

			return new Border1(
				x.openFalseCloseTrue
				,
				-x.mark
			);
		
		}

		static public Border1 Inverse(Border1 x) {
			return new Border1(x.openFalseCloseTrue,

				num.quotient.be.NonZero.En.Inverse(x.mark)
				
				
				);
		}

		static public bool Eq(Border1 x, Border1 y) {

			return nilnul.border.Eq_TEqDefault<Q1, num.quotient.Comparer1,Border1>.Singleton.Equals(x, y);
		
		}

		static public implicit operator Border1(nilnul.num.Border1 numBorder) {
			return new Border1(numBorder.openFalseCloseTrue, numBorder.mark);
		}

	
	}
}
