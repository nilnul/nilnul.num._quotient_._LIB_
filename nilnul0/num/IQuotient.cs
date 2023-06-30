using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{

	/// <summary>
	/// <see cref="_quotient.Dividing"/>, but the divider is nonnil; (the dividend|numerator can be anything)
	/// </summary>
	/// alias:
	///		dividing
	///			divisor might be nil
	///			(dividend, divisor)
	///			1 \ 3;
	///		quotient
	///			eg: 20/3 and we get a quotient as "6 with remainder 2"
	///		frac
	///			numerator,denominator;
	///			but quotient is closer to <see cref="_quotient.Dividing"/>
	///		rational
	///			coprime, divisor positive;
	///			initial conflicts with real
	///		ratio
	///			divisor is not nil;
	///			not reduced;
	///			in most contexts, both numbers are restricted to be positive.

	public interface IQuotient //:IFrac
		:
		_quotient.IDividing
	{

	}
}
