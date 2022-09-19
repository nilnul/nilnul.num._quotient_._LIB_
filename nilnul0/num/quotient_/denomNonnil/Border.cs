using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num.quotient.border;
using Q1 = nilnul.num.Quotient_NonnilDenom;//._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient_.denomNonnil
{
	public  class Border
		:
		nilnul.obj.Border<Q1>
		,
		nilnul.obj.BorderI<Q1>
	{
		public Border(bool openFalseCloseTrue, Q1 bound)
			:base(openFalseCloseTrue,bound)
		{

		}

		public Border(bool openFalseCloseTrue, BigInteger mark)
			:this(
				openFalseCloseTrue, (Q1)mark 
			)
		{
		}

		static public Border Multi(Border x, Border y) {

			return new Border(x.openFalseCloseTrue && y.openFalseCloseTrue, x.mark * y.mark);
		}

		


		static public Border operator *(Border x, Border y) {
			return Multi(x, y);
		}

		static public Border Abs(Border x) {
			return new Border(
				x.openFalseCloseTrue
				,
				nilnul.num.quotient.op_.unary_.Abs.Singleton.op(
					x.mark
				)
			);
		}

		static public Border CreateZeroClose() {
			return new Border(true, 0);
		}

		static public Border CreateOpenNil() {
			return new Border(false, 0);
		}

		static public Border CreateClose(Q1 mark) {
			return new Border(true, mark);
		}

		static public Border CreateOpen(Q1 mark) {
			return new Border(false, mark);
		}


		static public Border Add(Border x,Border y) {
			return new Border(
				x.openFalseCloseTrue&&y.openFalseCloseTrue
				,
				x.mark+y.mark	
			);
		}
		static public Border Add(Border x,BigInteger y) {
			return new Border(
				x.openFalseCloseTrue
				,
				x.mark+y	
			);
		}

		static public Border operator -(Border x)
		{
			return new Border(
				x.openFalseCloseTrue
				,
				-x.mark
			);
		}

		static public Border operator +(Border x,BigInteger y) {
			return new Border(
				x.openFalseCloseTrue
				,
				x.mark+y	
			);
		}


		static public Border operator +(Border x,Border y) {
			return new Border(
				x.openFalseCloseTrue && y.openFalseCloseTrue
				,
				x.mark+y.mark	
			);
		}

		static public bool operator ==(Border x,Border y) {
			return x.mark==y.mark && x.openFalseCloseTrue == y.openFalseCloseTrue;
		}

		static public bool operator !=(Border x,Border y) {
			return !(x==y);
		}

		static public bool operator ==(Border x,nilnul.num.Quotient_NonnilDenom y) {
			return x==  new Border (true,y);
		}
		static public bool operator !=(Border x,nilnul.num.Quotient_NonnilDenom y) {
			return !(x==y);
		}

		static public bool operator ==(nilnul.num.Quotient_NonnilDenom x, Border y2) {
			return y2==x;
		}
		static public bool operator !=(nilnul.num.Quotient_NonnilDenom x1, Border y) {
			return !(x1==y);
		}

		static public bool operator ==(Border x,int y) {
			return x== new Quotient_NonnilDenom(y);
		}
		static public bool operator !=(Border x,int y) {
			return !(x==y);
		}

		static public bool operator ==(int x, Border y2) {
			return y2==x;
		}
		static public bool operator !=(int x1, Border y) {
			return !(x1==y);
		}
		


		static public Border Negate(Border x) {

			return new Border(
				x.openFalseCloseTrue
				,
				-x.mark
			);
		
		}

		static public Border Inverse(Border x) {
			return new Border(x.openFalseCloseTrue,

				(x.mark.inverse())
				
				
				);
		}

		static public bool Eq(Border x, Border y) {

			return nilnul.obj.border.eq_.MarkEqDefault<Q1, num.quotient.Eq2,Border>.Singleton.Equals(x, y);
		
		}

	
		static public implicit operator Border(nilnul.num.Quotient_NonnilDenom numBorder) {
			return  Border.CreateClose(numBorder);
		}

		static public implicit operator Border(int numBorder) {
			return  CreateClose(numBorder);
		}



	
	}
}
