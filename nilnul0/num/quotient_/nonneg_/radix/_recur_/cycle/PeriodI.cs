using System;
using System.Numerics;

namespace nilnul.num.quotient_.nonneg_.radix._recur_.cycle
{

	/// <summary>
	/// eg:
	///		
	///		0123450*10^-17, where recur:
	///			0 means from before 0 to before 0,
	///			1 means "0"
	///			2 means "05"
	///			...
	///			7 means "0123450"
	///			
	/// </summary>
	///

	public interface PeriodI
	{

		/// <summary>
		/// if it'nil, we can allow uncycled radix, thus we can use this to express all fractions;
		/// </summary>
		Num_ofIn period { get; }

	}


}