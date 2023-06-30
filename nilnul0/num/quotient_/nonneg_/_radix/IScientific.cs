using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_._radix
{
	/// <summary>
	/// like 123e456; no radic is specified, as it's implied;
	/// note this cannot be directly written as <see cref="radix_.IFloaty"/>, as we need to append 456 zeros to the precision, and meawhile downside the indic by the same;
	/// </summary>
	/// <remarks>
	/// it can express large number or very small numbers used in science|engineering|astrology, but not in common life;
	/// </remarks>
	/// alias:
	///		engineering
	///			'e' is the e in eg 123e456;
	///		sansroot
	///			sounds somewhat like scientific
	internal class IScientific
	{
	}
}
