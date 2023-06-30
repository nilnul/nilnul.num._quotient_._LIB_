using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_.nonerr_.noninf_
{
	/// <summary>
	/// when the biased indicand is all nil`s;
	/// 0.xxxx * 2 ^ -1022
	/// 
	/// for number representation, the numbers within [0,1) shall be denser than those in [1,inf).
	/// that means we need better precision within [0,1)
	/// Let's take [1, inf) as normal, then
	///		for x in [1, inf), we have y= 1/x, where y is in (0,1]; but if we keep y and x syn in monotone (grow or going down), we need to let x= 1/(1-y), then y= -1/x+1 = (x-1) /x, which is in [0,1), not (0,1] this time, where we have right closeness at the right border;
	///		or put another way:
	///			for x in [0,1), 1/(1-x) =y is in [1,inf)
	///		
	/// </summary>
	/// alias:
	///		subnormal
	///		nonscientific
	///		minindic
	///		mindic
	///		infinitesimal
	///		infimum
	///		inferior
	internal interface INonsup
	{
	}
}
