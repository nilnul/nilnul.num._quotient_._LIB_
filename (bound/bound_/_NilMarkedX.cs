using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B = nilnul.num.quotient.Bound;

namespace nilnul.num.quotient.bound_
{
	public class _NilMarkedX
	{
		static public Bound _CreatePositive(nilnul.num.quotient.Border2 _borderPositive) {
			return new B(nilnul.num.quotient.Border2.CreateOpenNil(), _borderPositive);
		}
		static public B _CreateNeg(nilnul.num.quotient.Border2 _borderNeg) {
			return new B(_borderNeg, nilnul.num.quotient.Border2.CreateOpenNil());
		}

	}
}
