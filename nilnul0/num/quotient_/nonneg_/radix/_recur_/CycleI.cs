using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace nilnul.num.quotient_.nonneg_.radix._recur_
{
	/// <summary>
	///  the gits in a cycle;
	/// from the beginning, how many gits are covered;
	/// eg:
	///		312 in 	0123.312312...
	///			where the <see cref="PeriodI"/> is 3;
	///			
	/// </summary>
	public interface CycleI
	{

		/// <summary>
		/// </summary>

		IEnumerable<BigInteger> cycle { get; }

	}


}