using nilnul.order;
using nilnul.order.comparer.ext;
using nilnul.order.ext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.quotient.Q;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient.ext
{
	public partial class Border1
		:nilnul.Border<q.ExtI>
	{
		public Border1(
			bool openFalseCloseTrue
			,
			q.ExtI pinpoint
		)
			:base(openFalseCloseTrue,pinpoint)
		{

		}

		public Border1(bool openFalseCloseTrue, Q1 bastion)
			:this(
				 openFalseCloseTrue,(ext_.Bare)bastion as q.ExtI
				 
			)
		{

		}

		public Border1(bool openFalseCloseTrue, int x)
			:this( openFalseCloseTrue, (Q1)x )
		{

		}

		
		public bool isInfClose() {
			return openFalseCloseTrue && mark is nilnul.order.ext.InfI;
		}

		public bool isNotInfClose() {
			return !isInfClose();
		}

		//public bool isFinite() {
		//	return base.isFinite();
		//}

		//public bool isNotInf() {
		//	return !isInf();
		//}

		public bool isNegOpen() {
			return mark is nilnul.order.ext.NegInfI && !openFalseCloseTrue;
		}

		public bool isPosOpen() {
			return mark is PosInfI && !openFalseCloseTrue;
		}


		public bool isNegInf()
		{
			return mark is nilnul.order.ext.NegInfI;
		}
		public bool isNotNegInf()
		{
			return !isNegInf();
		}
		public bool isPosInf()
		{
			return mark is nilnul.order.ext.PosInfI;
		}
		public bool isNotPosInf()
		{
			return !isPosInf();
		}

		public bool isZeroClose()
		{

			return ext.comparer.Decider.Singleton.Equals(mark,  new ext_.Bare( 0)) && openFalseCloseTrue;

		}

		static public Border1 CreateZeroClose() {
			return new Border1(
				true,  ( 0	)
			);
		
		}

		static public implicit operator Border1(
			quotient.Border1 border
			) {
			return new Border1(border.openFalseCloseTrue,border.mark);
		}


		

		static public Border1 CreateClose(ExtI x){

			return new Border1(true, x);

		}

		static public Border1 operator -(Border1 x) {
			return new Border1(x.openFalseCloseTrue,  ext.op.Negate.Eval(x.mark));
		}

	

		static public Border1 Abs(Border1 x) {
			return new Border1(x.openFalseCloseTrue, ext.op.Abs.Eval( x.mark));
		}

		static public explicit operator q.Border(Border1 x) {
			return new quotient.Border(x.openFalseCloseTrue,(x.mark as _ext.Base)   );
		}



		


		
	}
}
