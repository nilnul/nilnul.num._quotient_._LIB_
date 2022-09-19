using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.range_.nilMarked_.positive.nulable.combine_
{
	[Obsolete()]
	public class _UnionX
	{
		static public Range1 Range(Range1 nilMarkedPositive, Range1 nilMarkedPositive1) {
			if (nilMarkedPositive  is null) return nilMarkedPositive1;
			if (nilMarkedPositive1  is null) return nilMarkedPositive;
			
			return positive.combine_._UnionX.Range(nilMarkedPositive, nilMarkedPositive1);
		}
	}
}
