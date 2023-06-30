using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.num.quotient.border;
using Q1 = nilnul.num.quotient_.DenomNonnil;//._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient_.denomNonnil._range
{
	/// <summary>
	/// </summary>
	///
	public  class Border
		:
		nilnul.obj.Border<Q1>
		,
		nilnul.obj.BorderI<Q1>
		,
		BorderI
	{
		public Border(bool openFalseCloseTrue, Q1 bound)
			:base(openFalseCloseTrue,bound)
		{

		}

		public Border(bool openFalseCloseTrue, Num1 mark)
			:this(
				openFalseCloseTrue, (Q1)mark 
			)
		{
		}

		static public Border Multi(Border x, Border y) {

			return new Border(
				(bool)(x.openFalseCloseTrue && y.openFalseCloseTrue)
				,
				(Q1)(_ExtensionsX.ToImpl(x.mark) * y.mark)
			);
		}

		



		static public Border operator *(Border x, Border y) {
			return Multi(x, y);
		}

		static public Border Abs(Border x) {
			return new Border(
				(bool)x.openFalseCloseTrue
				,
				(Q1)nilnul.num.quotient.op_.unary_._AbsX.Op(
					(Q1)x.mark
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

		public static Border CreateClose(int a)
		{
			return CreateClose(new quotient_.DenomNonnil(a));
		}
		public static Border CreateClose(QuotientI a)
		{
			return CreateClose(new quotient_.DenomNonnil(a));
		}

		static public Border CreateOpen(Q1 mark) {
			return new Border(false, mark);
		}

		public static Border CreateOpen(QuotientI1 a)
		{
			return CreateOpen(new quotient_.DenomNonnil(a));
		}

		static public Border Add(Border x,Border y) {
			return new Border(
				(bool)(x.openFalseCloseTrue&& y.openFalseCloseTrue)
				,
				(Q1)(_ExtensionsX.ToImpl(x.mark) + y.mark)	
			);
		}
		static public Border Add(Border x,BigInteger y) {
			return new Border(
				(bool)x.openFalseCloseTrue
				,
				(Q1)(_ExtensionsX.ToImpl(x.mark) + y)	
			);
		}

		static public Border operator -(Border x)
		{
			return new Border(
				(bool)x.openFalseCloseTrue
				,
				(Q1)(-_ExtensionsX.ToImpl(x.mark))
			);
		}

		static public Border operator +(Border x,BigInteger y) {
			return new Border(
				(bool)x.openFalseCloseTrue
				,
				(Q1)(_ExtensionsX.ToImpl(x.mark) + y)	
			);
		}


		static public Border operator +(Border x,Border y) {
			return new Border(
				(bool)(x.openFalseCloseTrue && y.openFalseCloseTrue)
				,
				(Q1)(_ExtensionsX.ToImpl(x.mark) + y.mark)	
			);
		}

		static public bool operator ==(Border x,Border y) {
			return x.mark==y.mark && x.openFalseCloseTrue == y.openFalseCloseTrue;
		}

		static public bool operator !=(Border x,Border y) {
			return !(x==y);
		}

		static public bool operator ==(Border x,nilnul.num.QuotientI y) {
			return x==  Border.CreateClose(y);
		}
		static public bool operator !=(Border x,nilnul.num.QuotientI y) {
			return !(x==y);
		}

		static public bool operator ==(Border x,nilnul.num.Quotient1 y) {
			return x==  Border.CreateClose(y);
		}
		static public bool operator !=(Border x,nilnul.num.Quotient1 y) {
			return !(x==y);
		}
		static public bool operator ==(nilnul.num.QuotientI x, Border y2) {
			return y2==x;
		}
		static public bool operator !=(nilnul.num.QuotientI x1, Border y) {
			return !(x1==y);
		}

		static public bool operator ==(Border x,int y) {
			return x== new Quotient1(y);
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
				(bool)x.openFalseCloseTrue
				,
				(Q1)(-_ExtensionsX.ToImpl(x.mark))
			);
		
		}

		static public Border Inverse(Border x) {
			return new Border((bool)x.openFalseCloseTrue,

				(Q1)num.quotient_.nonnil.op_.unary_._InverseX.Op(_ExtensionsX.ToImpl(x.mark))
				
				
				);
		}

		static public bool Eq(Border x, Border y) {

			return nilnul.obj.border.eq_.MarkEqDefault<Q1, num.quotient.Eq2,Border>.Singleton.Equals(x, y);
		
		}

		static public implicit operator Border(nilnul.num.Border2 numBorder) {
			return new Border(numBorder.openFalseCloseTrue, numBorder.mark);
		}
		static public implicit operator Border(nilnul.num.Quotient1 numBorder) {
			return  Border.CreateClose(numBorder);
		}

		static public implicit operator Border(int numBorder) {
			return  Border.CreateClose(numBorder);
		}



	
	}
}
