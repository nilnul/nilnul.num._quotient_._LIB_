using nilnul.order;
using nilnul.order.comparer.ext;
using nilnul.order.ext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction2;
using Q = nilnul.num.quotient.Q;

namespace nilnul.num.quotient.ext
{
	public partial class Bound
		:nilnul.order.Bound<_ext.ExtI>
	{
		public Bound(
			bool openFalseCloseTrue
			,
			_ext.ExtI pinpoint
		)
			:base(openFalseCloseTrue,pinpoint)
		{

		}

		public Bound(bool openFalseCloseTrue, Q bastion)
			:this(
				 openFalseCloseTrue,(_ext.Base)bastion as _ext.ExtI
				 
			)
		{

		}


		public bool isInfClose() {
			return openFalseCloseTrue && pinpoint is nilnul.order.ext.InfI;
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
			return pinpoint is nilnul.order.ext.NegInfI && !openFalseCloseTrue;
		}

		public bool isPosOpen() {
			return pinpoint is PosInfI && !openFalseCloseTrue;
		}


		public bool isNegInf()
		{
			return pinpoint is nilnul.order.ext.NegInfI;
		}
		public bool isNotNegInf()
		{
			return !isNegInf();
		}
		public bool isPosInf()
		{
			return pinpoint is nilnul.order.ext.PosInfI;
		}
		public bool isNotPosInf()
		{
			return !isPosInf();
		}

		public bool isZeroClose()
		{

			return ext.Eq.Singleton.Equals(pinpoint,  new _ext.Base( 0)) && openFalseCloseTrue;

		}

		static public Bound CreateZeroClose() {
			return new Bound(
				true, ( 0	)
			);
		
		}

	

		static public Bound Abs(Bound x) {
			return new Bound(x.openFalseCloseTrue, ext.op.Abs.Eval( x.pinpoint));
		}





		


		
	}
}
