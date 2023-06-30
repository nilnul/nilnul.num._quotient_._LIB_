using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_
{
	
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	///

	static public class _NonerrX
	{
	

		static public quotient.ExtI _ToExt_assumeValid(double x)
		{
			if (double.IsNegativeInfinity(x))
			{
				return nilnul.num.quotient.ext_.inf_.Neg.Singleton;
			}
			if (double.IsPositiveInfinity(x))
			{
				return nilnul.num.quotient.ext_.inf_.Pos.Singleton;
			}

			return new quotient.ext_.Finite( nonerr_._NoninfX._ToSignificed_0finite(x).toDenomNonnil() );
		}

	

		


	}
}
