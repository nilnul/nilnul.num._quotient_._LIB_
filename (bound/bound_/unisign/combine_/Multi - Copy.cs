using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.quotient.range_.unisign.combine_
{
	static public  class _MultiX
	{
		
	

		public static Range1 OfNegPositive(Range1 a, Range1 b) {

			return -range_.unisign_.positive.combine_._MultiX.Range(-a,b);
		}

		public static Range1 OfPositiveNeg(Range1 a, Range1 b) {

			return OfNegPositive(b,a);
		}
		public static Range1 OfOneNil() {

			return Range1.CreateZero();
		}

		public static Range1 OfOneNil(Range1 a, Range1 b) {

			return Range1.CreateZero();
		}





		public static Range1 Range(Range1 a, Range1 b) {
			if (a.isNil()|| b.isNil() )
			{
				return Range1.CreateZero();
			}
			return unisign_.nonnil.combine_._MultiX._Range(a, b);

		}

	}
}
