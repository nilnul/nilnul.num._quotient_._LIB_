using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B = nilnul.num.quotient.Bound;


namespace nilnul.num.quotient.bound_.nilMarked_.neg.nulable.combine_
{
	public class _UnionX
	{
		static public B Bound(Bound nilMarkedNeg, B nilMarkedNeg1) {
			if (nilMarkedNeg  is null) return nilMarkedNeg1;
			if (nilMarkedNeg1  is null) return nilMarkedNeg;
			
			return neg.combine_._UnionX.Bound(nilMarkedNeg, nilMarkedNeg1);
		}
	}
}
