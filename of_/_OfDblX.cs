using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.of_
{
	/// <summary>
	/// The Double type complies with the IEC 60559:1989 (IEEE 754) standard for binary floating-point arithmetic.
	/// ignificand or mantissa	0-51
	/// Exponent	52-62
	/// Sign(0 = Positive, 1 = Negative)   63
	/// </summary>
	static public class _OfDblX
	{
		/// <summary>
		/// x = s * m * b^e
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public nilnul.num.quotient_.DenomNonnil _OfDbl_assumeOrdinary(double x) {
			var bitConverted=BitConverter.DoubleToInt64Bits(x);
			throw new NotImplementedException();


		}
	}
}
