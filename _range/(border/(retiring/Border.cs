using nilnul.order;
using nilnul.order.comparer.ext;
using nilnul.order.ext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient
{
	[Obsolete()]
	public partial class Border
		:nilnul.tuple.ord.Border<Q>
	{
		public Border(
			bool openFalseCloseTrue
			,
			Q pinpoint
		)
			:base(openFalseCloseTrue,pinpoint)
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

			return mark==0 && openFalseCloseTrue;

		}

		static public Border CreateZeroClose() {
			return new Border(
				true, ( 0	)
			);
		
		}

	

		static public Border Abs(Border x) {
			return new Border(x.openFalseCloseTrue, Q.ToAbs(x.mark));
		}





		


		
	}
}
