using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur_.mantissaed_.xpn_
{

	/// <summary>
	/// eg:
	///		012345(0.0670 is not proper
	/// </summary>
	[Serializable]
	public class CycleImproperException : Exception
	{
		public CycleImproperException() { }
		public CycleImproperException(string message) : base(message) { }
		public CycleImproperException(string message, Exception inner) : base(message, inner) { }
		protected CycleImproperException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		static public void Vow(FloatyI radix, Num_ofIn cycle)
		{
			if (cycle.eeByRef > -radix.indic)
			{
				throw new CycleImproperException(
					$"cycle:{cycle} would start from right to the decimal point of {radix};"
				);
			}
		}
	

		public static void Vow(radix_.Floaty radix, Num_ofIn cycle)
		{
			Vow((FloatyI)radix,cycle);

		}
	}
}

