using System.Numerics;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty
{
	/// <summary>
	/// recur can happen before point;
	/// eg:
	///		123(4.5 
	/// </summary>
	public interface RecurI
		:radix.RecurI
	{
		Floaty floaty { get;  }
	}
}