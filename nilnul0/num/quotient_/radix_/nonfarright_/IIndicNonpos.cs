using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_
{
	/// <summary>
	/// the indicand is not positive; it can be nil or neg;
	/// if it were positive like 01230 * 10^5, the decimal is 01230 00000, where we need prepend (as the gits are little-endian) nils to the significand;
	/// 01230 * 10^-8 would still be xpn, so this is not enough; we need to prepend nils:
	///  00001230*10^-8;  to make this accomodate '.', use <see cref="byNeg_.Floaty"/>
	/// </summary>
	/// <see cref="IFloaty"/>
	///
	[Obsolete(nameof(INonfarright))]
	internal class IIndicNonpos
	{
	}
}
