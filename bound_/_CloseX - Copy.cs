using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num.Quotient1;


namespace nilnul.num.quotient.range_
{
	[Obsolete()]
	static public class _CloseX
	{
		static public Range1 Range(Q1 a, Q1 b)
		{
			return new Range1(Border2.CreateClose(a), Border2.CreateClose(b));
		}

		static public Range1 _Range_assumeRadiusNoneg(Q1 _radius_nonNeg)
		{
			return new Range1(Border2.CreateClose(-_radius_nonNeg), Border2.CreateClose(_radius_nonNeg));
		}


	}

	
}
