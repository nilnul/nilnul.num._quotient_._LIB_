using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix.recur_.xpn_
{

	/// <summary>
	/// eg:
	///		0123450*10^-4, cycle: [0,1,2,...,7] is ok, outside this range would be exception;
	/// </summary>
	///	we can prepend 0s to the precision to make it accomodate the cycle;eg:
	///	01230*10^-4, cycle:7,  ==>0001230*10^-4, cycle:7 => (0001230.
	/// 
	[Serializable]
	public class CycleGtPrecisionException : Exception
	{
		public CycleGtPrecisionException() { }
		public CycleGtPrecisionException(string message) : base(message) { }
		public CycleGtPrecisionException(string message, Exception inner) : base(message, inner) { }
		protected CycleGtPrecisionException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		static public void Vow(num_.RadixI radix, Num_ofIn cycle)
		{
			if (cycle.eeByRef > radix.gits.Count())
			{
				throw new recur_.xpn_.CycleGtPrecisionException(
					$"cycle:{cycle} would exceed the precision:{radix};"
				);  /// but we lost the info of the original <see cref="num.quotient_.nonneg_.RadixI"/>
			}
		}
		static public void Vow(RadixI radix, Num_ofIn cycle)
		{
			Vow(radix.precision,cycle);

			//if (cycle.eeByRef > radix.precision.gits.Count())
			//{
			//	throw new recur_.xpn_.CycleGtPrecisionException(
			//		$"cycle:{cycle} would exceed the precision of {radix};"
			//	);
			//}
		}

		static public void Vow(Radix radix, Num_ofIn cycle)
		{
			Vow((RadixI)radix,cycle);
		}


		public static void Vow(radix_.Floaty radix, Num_ofIn cycle)
		{
			Vow((RadixI)radix,cycle);

		}

		
	}
}

