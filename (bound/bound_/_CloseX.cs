using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num.Quotient1;


namespace nilnul.num.quotient.bound_
{
	static public class _CloseX
	{
		static public Bound Bound(Q1 a, Q1 b)
		{
			return new quotient.Bound(Border2.CreateClose(a), Border2.CreateClose(b));
		}

		[Obsolete(nameof(_CenteredX))]
		static public Bound _Bound_assumeRadiusNoneg(Q1 _radius_nonNeg)
		{
			return new Bound(Border2.CreateClose(-_radius_nonNeg), Border2.CreateClose(_radius_nonNeg));
		}


	}

	
}
