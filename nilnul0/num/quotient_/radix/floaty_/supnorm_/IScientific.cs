using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.floaty_.supnorm_
{
	/// <summary>
	///		01230.040
	///			we can float the decimal point:
	///				01.230040 * 10^3
	///			
	/// the coef is a cimal in [1, base)
	/// 
	/// eg:
	///		for decimal
	///			1.0 * 10 ^ -2
	///			1.2* 10^1
	///			9.8 * 10^2
	///		for bicimal:
	///			1.0 *2^-1
	///	it cannot express 0; so 0 is specially processed.
	/// </summary>
	/// alias:
	///		floated
	internal class IScientific
	{
	}

}
