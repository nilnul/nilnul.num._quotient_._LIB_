using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.frac_
{
	/// <summary>
	/// simplified (denominator and numerator are coprime);
	/// eg:
	///		0/1
	///		1/1
	///		2/1
	///		4/1
	///		3/4
	///	not:
	///		4/2
	///		
	/// </summary>
	/// alias:
	///		simplified
	public interface IRational
		:IFrac
	{
	}
}
