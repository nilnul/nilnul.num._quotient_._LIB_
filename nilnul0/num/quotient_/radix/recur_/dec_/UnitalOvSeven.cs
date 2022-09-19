using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.recur_.dec_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///142857, the six repeating digits of 1/7 (0.142857), is the best-known cyclic number in base 10. If it is multiplied by 2, 3, 4, 5, or 6, the answer will be a cyclic permutation of itself
	/// </remarks>
	static public class _UnitalOvSevenX
	{
		/// <summary>
		/// 0._142857_
		/// when this*7, we get 0._9
		/// 
		/// </summary>
		/// <returns></returns>
		/// <remarks>
		///
		/// </remarks>
		static public Dec Dec() {
			return recur_.Dec.FroQuotient(
				quotient_._UnitalX.Over(7)
			);
		}
	}
}
