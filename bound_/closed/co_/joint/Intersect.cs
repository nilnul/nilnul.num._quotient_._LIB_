using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.bound_.closed.co_.joint
{
	static public class _IntersectX
	{
		static public Closed Intersect(Closed x, Closed y) {
			return new Closed(
				nilnul.num.quotient.op_.binary_._MaxX.Max(x.lower.mark,y.lower.mark)
				,
				nilnul.num.quotient.op_.binary_._MinX.Min(x.upper.mark,y.upper.mark)
			);
		}
	}
}
