using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using B = nilnul.num.quotient.Bound;


namespace nilnul.num.quotient.bound_.closed.op_.binary_
{
	static public class _MultiX
	{
		public static Closed Op(Closed x, Closed y)
		{
			var points = new[] {
				x.lower.mark*y.lower.mark
				,
				x.lower.mark*y.upper.mark
				,
				x.upper.mark*y.lower.mark
				,
				x.upper.mark*y.upper.mark
			};
			return new Closed(
				nilnul.num.quotient.str_.started._MinX._Min(points)
				,
				num.quotient.str_.started._MaxX._Max(points)
			);

		}
		static public Closed Square(Closed x)
		{
			return Op(x, x);
		}

	}
}
