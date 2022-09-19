using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.range_.nilMarked.combine_
{
	public class _UnionX
	{
		static public Range1 OfNegPositive(Range1 nilMarkedNeg, Range1 nilMarkedPositive1) {
			return _NilMarkedX._CreateNeg(
				nilMarkedNeg.lower*nilMarkedPositive1.upper
			);
		}
		static public Range1 OfPositiveNeg( Range1 nilMarkedPositive1, Range1 nilMarkedNeg) {
			return OfNegPositive(nilMarkedNeg, nilMarkedPositive1);
		}


	}
}
