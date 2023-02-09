using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.phrase_._scientific
{
	/// <summary>
	/// the coef part, when normalized, of a <see cref="radix.phrase_.Scientific"/> notation
	/// eg:
	///		for decimal:
	///			1.0
	///			9.9
	///			but not:
	///				0.7
	///				0
	///				10
	///				10.1
	///	that is the number must be lt the base 10.
	///	for binary,
	///		1
	///		1.1
	///		but not:
	///			0
	///			0.1
	///			11.1
	///	This is primarily used in scientific notation. for 0.1, it's rewritten as 1 * 2^-1
	/// </summary>
	internal class IEngineered
	{
	}
}
