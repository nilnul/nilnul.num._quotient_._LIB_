using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using B = nilnul.num.quotient.Bound;


namespace nilnul.num.quotient.bound_.unisign.combine_
{
	static public  class _MultiX
	{
		
	

		public static B OfNegPositive(B a, B b) {

			return -bound_.unisign_.positive.combine_._MultiX.Bound(-a,b);
		}

		public static B OfPositiveNeg(B a, B b) {

			return OfNegPositive(b,a);
		}
		public static B OfOneNil() {

			return B.CreateZero();
		}

		public static B OfOneNil(B a, B b) {

			return B.CreateZero();
		}





		public static B Bound(B a, B b) {
			if (a.isNil()|| b.isNil() )
			{
				return B.CreateZero();
			}
			return unisign_.nonnil.combine_._MultiX._Bound(a, b);

		}

	}
}
