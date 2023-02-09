using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.range_
{
	public class _NilMarkedX
	{
		static public Range1 _CreatePositive(nilnul.num.quotient.Border2 _borderPositive) {
			return new Range1(nilnul.num.quotient.Border2.CreateOpenNil(), _borderPositive);
		}
		static public Range1 _CreateNeg(nilnul.num.quotient.Border2 _borderNeg) {
			return new Range1(_borderNeg, nilnul.num.quotient.Border2.CreateOpenNil());
		}

	}
}
