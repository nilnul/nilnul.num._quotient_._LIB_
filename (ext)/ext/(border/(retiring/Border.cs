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
	public partial class Border
		:nilnul.tuple.ord.Border<_ext.ExtI>
	{
		public Border(
			bool openFalseCloseTrue
			,
			_ext.ExtI pinpoint
		)
			:base(openFalseCloseTrue,pinpoint)
		{

		}

		public Border(bool openFalseCloseTrue, Q bastion)
			:this(
				 openFalseCloseTrue,(_ext.Base)bastion as _ext.ExtI
				 
			)
		{

		}

		public Border(bool openFalseCloseTrue, int x)
			:this( openFalseCloseTrue, (Q1)x )
		{

		}

		public Border(bool openFalseCloseTrue, Q1 bastion)
			:this(
				 openFalseCloseTrue,(_ext.Bare)bastion as _ext.ExtI
				 
			)
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

			return ext.Eq.Singleton.Equals(mark,  new _ext.Base( 0)) && openFalseCloseTrue;

		}

		static public Border CreateZeroClose() {
			return new Border(
				true,  ( 0	)
			);
		
		}

	

		static public Border Abs(Border x) {
			return new Border(x.openFalseCloseTrue, ext.op.Abs.Eval( x.mark));
		}

		static public explicit operator q.Border(Border x) {
			return new quotient.Border(x.openFalseCloseTrue,(x.mark as _ext.Base)   );
		}



		


		
	}
}
