using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B = nilnul.num.quotient.Bound;

namespace nilnul.num.quotient.bound_.nilMarked_.positive.combine_
{
	public class _UnionX
	{
		static public B Bound(B nilMarkedPositive, B nilMarkedPositive1) {
			return _NilMarkedX._CreatePositive(
				nilnul.num.quotient.border_.upper.op_.binary_._MaxX.Max(
					nilMarkedPositive.upper
					,
					nilMarkedPositive1.upper
				)
			);
		}
	}
}
