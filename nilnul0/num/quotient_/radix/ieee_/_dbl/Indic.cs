using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.ieee_._dbl
{
	/// <summary>
	/// the raw indicand;
	/// when in [1,2046], it's rationable;
	/// </summary>
	internal class Indic
	{
		/// <summary>
		/// total 11 bits;
		/// 2^11 = 2048;
		/// </summary>
		public const int BITS = 11;


		/// <summary>
		/// 
		/// </summary>
		public const int BIAS = 1024 - 1;

		/// <summary>
		/// For a double-precision number, the exponent is stored in the range 1 .. 2046 (0 and 2047 have special meanings), and is interpreted by subtracting the bias for an 11-bit exponent to get an exponent value in the range −1022 .. +1023.
		/// </summary>
		/// <param name="_positive"></param>
		/// <returns></returns>
		static public int _Indicand_assumePositive(int _positive)
		{
			return _positive - BIAS;
		}

	}
}
