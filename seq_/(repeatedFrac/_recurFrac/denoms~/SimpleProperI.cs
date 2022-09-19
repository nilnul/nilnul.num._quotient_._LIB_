using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient._continuedFrac
{
	/// <summary>
	/// we cannot have a uniform class but an interface, in that:
	///		the last denominator can be 1 if we want to use it in a stream to express irrational number
	///		the last denominator cannot be 1 if we want to normalize it to express a quotient number.
	/// </summary>
	public interface SimpleProperI
	{
	}
}
