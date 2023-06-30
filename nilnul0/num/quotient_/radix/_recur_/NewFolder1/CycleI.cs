using System;

namespace nilnul.num.quotient_.radix._recur_
{
	/// <summary>
	///  the gits in a cycle;
	/// from the beginning, how many gits are covered;
	/// eg:
	///		312 in 	0123.312312...
	///			where the <see cref="PeriodI"/> is 3;
	///			
	/// </summary>
	[Obsolete(nameof(UnsignedI.unsigned.period) +  " is prefered;")]
	public interface CycleI
	{

		/// <summary>
		/// </summary>

		nilnul.num_.RadixI cycle { get; }

	}


}