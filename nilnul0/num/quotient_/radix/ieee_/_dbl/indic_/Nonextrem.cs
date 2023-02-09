using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.ieee_._dbl.indic_
{
	/// <summary>
	/// [1,2046]
	/// </summary>
	/// alias:
	///		normal
	internal class Nonextrem
	{
		/// <summary>
		/// 2^(11-1) -1
		/// </summary>
		public const int BIAS = 1023;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_nonextrem">
		/// [1,2046]
		/// </param>
		/// <returns>
		/// [-1022, 1023]
		/// so
		///		when the raw is 1023, the debiased indicand is 0
		/// </returns>
		static public int _Unbias_assumeNonextrem(int _nonextrem) {
			return _nonextrem - BIAS;
		}
	}
}
