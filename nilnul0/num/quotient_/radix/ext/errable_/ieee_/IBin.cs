using nilnul.bit.expr_.call_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_
{
	///
	/// https://float.exposed/0x000fffffffffffff
	///
	/// https://fabiensanglard.net/floating_point_visually_explained/
	///
	/// IEC 60559:1989 (IEEE 754)
	/// <summary>
	/// the double struct in dotnet;
	/// as this is under <see cref="binary_"/>, we only consider those dbl that can be casted to <see cref="IQuotient"/>, by excluding inf, Nan, and regard -0 as equal to 0;
	/// </summary>
	/// <remarks>
	/// let's treat this here in quotient,not in num.Real; as this is in fact quotient, and lose some precision when operated and the result is still quoteint mostly;
	/// </remarks>
	/// ±5.0 × 10^−324 to ±1.7 × 10^308
	///
	/// why negative zero?
	///		*) complement encoding is suitable for prefixed lengthed integer;
	///			**) signed one can make variable-lengthed integer easy to compare;
	///		*) negative zero can make negative inf by inverting it;
	///	alias:
	///		IBin
	///			reserve for <see cref="_bin_.ErrableI"/>
	public interface IBin:IIeee
	{
	}
}
