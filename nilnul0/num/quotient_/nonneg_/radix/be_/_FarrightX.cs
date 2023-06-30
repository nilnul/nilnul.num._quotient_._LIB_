using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix.be_
{
	/// <summary>
	/// eg:
	///		01230 * 10^1, where the point has to be floated rightward 1 chars, to make 012300.;
	/// </summary>
	/// alias:
	///		farright
	///	<seealso cref="radix_.nonfloaty_.IFarright"/>
	static public class _FarrightX
	{
		static public  bool IsPointOverLeastSignificant(this quotient_.nonneg_.RadixI indicPosible)
		{
			return  indicPosible.indic >0;
		}

	}
}
