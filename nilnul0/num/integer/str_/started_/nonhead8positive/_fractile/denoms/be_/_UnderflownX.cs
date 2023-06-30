using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.integer.str_.started_.nonhead8positive._fractile.denoms.be_
{
	/// <summary>
	/// at least one denom, and the last denom is not one;
	///
	/// eg:
	///		1/1
	///		1/ (2+1/1)
	///	counter eg:
	///		[], or 0
	///		,[2] or 1/2
	/// </summary>
	/// alias:
	///		Collapsible
	static public class _UnderflownX
	{

		static public bool Be(IEnumerable<nilnul.num_.Positive1> denoms) {
			return denoms.Any() && denoms.Last().en == 1;
		}

		static public bool Be(_fractile.Denoms denoms) {
			return Be(denoms.denominators);
		}
	}
}
