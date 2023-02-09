using nilnul.bit.expr_.call_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.ieee_
{
	/// IEC 60559:1989 (IEEE 754)
	/// <summary>
	/// the double struct in dotnet;
	/// as this is under <see cref="binary_"/>, we only consider those dbl that can be casted to <see cref="IQuotient"/>, by excluding inf, Nan, and regard -0 as equal to 0;
	/// </summary>
	/// ±5.0 × 10^−324 to ±1.7 × 10^308
	///
	/// why negative zero?
	///		*) complement encoding is suitable for prefixed lengthed integer;
	///			**) signed one can make variable-lengthed integer easy to compare;
	///		*) negative zero can make negative inf by inverting it;
	///	alias:
	///		IBin
	public interface IBin:IIeee
	{
	}
}
