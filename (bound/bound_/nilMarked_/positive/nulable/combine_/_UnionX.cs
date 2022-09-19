using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B = nilnul.num.quotient.Bound;


namespace nilnul.num.quotient.bound_.nilMarked_.positive.nulable.combine_
{
	public class _UnionX
	{
		static public B Bound(B nilMarkedPositive, B nilMarkedPositive1) {
			if (nilMarkedPositive  is null) return nilMarkedPositive1;
			if (nilMarkedPositive1  is null) return nilMarkedPositive;
			
			return positive.combine_._UnionX.Bound(nilMarkedPositive, nilMarkedPositive1);
		}
	}
}
