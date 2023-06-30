using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix.trich_
{
	/// <summary>
	/// supposing we write from left to right, observe the location of the decimal point like in 0.1230
	/// </summary>
	public enum _Floaty {
		/// <summary>
		/// the point is too left;
		/// eg:
		///		01230e7, where we need append 0s to get 0123000., for which we can later trim the trailing dot, or 0123000.0
		/// </summary>
		Farleft
			,
		/// <summary>
		/// the point is in the closed range;
		/// eg:
		///		01230e0, which can be convertd to "01230."
		///		01230e1, which can be "0123.0"
		///		01230e4, which can be "0.1230"
		///		01230e5, which can be ".01230"
		/// </summary>
		Moderate
			,
		/// <summary>
		/// the point is too right;
		/// eg:
		///		01230e-7, where we need prepend some 0s to get .0001230
		/// </summary>

		Farright
	}
	internal class Floaty
	{
	}
}
