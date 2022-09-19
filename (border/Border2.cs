using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num.quotient.border;
using Q1 = nilnul.num.Quotient1;//._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient
{
	public partial class Border2
		:
		nilnul.Border<Q1>
		,
		nilnul.obj.BorderI<Q1>
	{
		public Border2(bool openFalseCloseTrue, Q1 bound)
			:base(openFalseCloseTrue,bound)
		{

		}

		public Border2(bool openFalseCloseTrue, Num mark)
			:this(
				openFalseCloseTrue, (Q1)mark 
			)
		{
		}

		static public Border2 Multi(Border2 x, Border2 y) {

			return new Border2(x.openFalseCloseTrue && y.openFalseCloseTrue, x.mark * y.mark);
		}

		
		public static Border2 CreateOpen(QuotientI a)
		{
			return CreateOpen(new Quotient1(a));
		}

		public static Border2 CreateClose(QuotientI a)
		{
			return CreateClose(new Quotient1(a));
		}

		static public Border2 operator *(Border2 x, Border2 y) {
			return Multi(x, y);
		}

		static public Border2 Abs(Border2 x) {
			return new Border2(
				x.openFalseCloseTrue
				,
				nilnul.num.quotient.op_.unary_._AbsX.Op(
					x.mark
				)
			);
		}

		static public Border2 CreateZeroClose() {
			return new Border2(true, 0);
		}

		static public Border2 CreateOpenNil() {
			return new Border2(false, 0);
		}

		static public Border2 CreateClose(Q1 mark) {
			return new Border2(true, mark);
		}
		static public Border2 CreateOpen(Q1 mark) {
			return new Border2(false, mark);
		}


		static public Border2 Add(Border2 x,Border2 y) {
			return new Border2(
				x.openFalseCloseTrue&&y.openFalseCloseTrue
				,
				x.mark+y.mark	
			);
		}
		static public Border2 Add(Border2 x,BigInteger y) {
			return new Border2(
				x.openFalseCloseTrue
				,
				x.mark+y	
			);
		}

		static public Border2 operator -(Border2 x)
		{
			return new Border2(
				x.openFalseCloseTrue
				,
				-x.mark
			);
		}

		static public Border2 operator +(Border2 x,BigInteger y) {
			return new Border2(
				x.openFalseCloseTrue
				,
				x.mark+y	
			);
		}


		static public Border2 operator +(Border2 x,Border2 y) {
			return new Border2(
				x.openFalseCloseTrue && y.openFalseCloseTrue
				,
				x.mark+y.mark	
			);
		}

		static public bool operator ==(Border2 x,Border2 y) {
			return x.mark==y.mark && x.openFalseCloseTrue == y.openFalseCloseTrue;
		}

		static public bool operator !=(Border2 x,Border2 y) {
			return !(x==y);
		}

		static public bool operator ==(Border2 x,nilnul.num.QuotientI y) {
			return x==  Border2.CreateClose(y);
		}
		static public bool operator !=(Border2 x,nilnul.num.QuotientI y) {
			return !(x==y);
		}

		static public bool operator ==(Border2 x,nilnul.num.Quotient1 y) {
			return x==  Border2.CreateClose(y);
		}
		static public bool operator !=(Border2 x,nilnul.num.Quotient1 y) {
			return !(x==y);
		}
		static public bool operator ==(nilnul.num.QuotientI x, Border2 y2) {
			return y2==x;
		}
		static public bool operator !=(nilnul.num.QuotientI x1, Border2 y) {
			return !(x1==y);
		}

		static public bool operator ==(Border2 x,int y) {
			return x== new Quotient1(y);
		}
		static public bool operator !=(Border2 x,int y) {
			return !(x==y);
		}

		static public bool operator ==(int x, Border2 y2) {
			return y2==x;
		}
		static public bool operator !=(int x1, Border2 y) {
			return !(x1==y);
		}
		


		static public Border2 Negate(Border2 x) {

			return new Border2(
				x.openFalseCloseTrue
				,
				-x.mark
			);
		
		}

		static public Border2 Inverse(Border2 x) {
			return new Border2(x.openFalseCloseTrue,

				num.quotient_.nonnil.op_.unary_._InverseX.Op(x.mark)
				
				
				);
		}

		static public bool Eq(Border2 x, Border2 y) {

			return nilnul.border.Eq_TEqDefault<Q1, num.quotient.Comparer2,Border2>.Singleton.Equals(x, y);
		
		}

		static public implicit operator Border2(nilnul.num.Border1 numBorder) {
			return new Border2(numBorder.openFalseCloseTrue, numBorder.mark);
		}
		static public implicit operator Border2(nilnul.num.Quotient1 numBorder) {
			return  Border2.CreateClose(numBorder);
		}

		static public implicit operator Border2(int numBorder) {
			return  Border2.CreateClose(numBorder);
		}



	
	}
}
