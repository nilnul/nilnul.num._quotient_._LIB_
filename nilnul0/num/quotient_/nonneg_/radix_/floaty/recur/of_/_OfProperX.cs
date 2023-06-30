using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur.of_
{
	/// <summary>
	///  get all the remainders, till a cycle formed.
	/// </summary>
	/// <remarks>recurring, cyclic, repeating, recurring...</remarks>
	static public class _OfProperX
	{



		/// <summary>
		///
		/// keep dividing numerator (multiplied by <see cref="nilnul.num_._radix.IRadic"/>) by the denominator to get the gits:<see cref="nilnul.num_._radix_.GitsI"/>; 
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		static public RecurI _Of_0radic(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.proper.vow.En proper
		)
		{
			return _Of_0radic_1proper(_radix_plural, proper.en);

		}

		
		public static RecurI _Of_0radic_1proper(BigInteger _radix_plural, Quotient1 proper)
		{
			
			return _Of_0radic_1proper(_radix_plural, quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper));
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <param name="proper"></param>
		/// <returns>
		/// <see cref="nonneg_.radix_.floaty.recur_.Mantissaed"/>
		/// </returns>
		public static RecurI _Of_0radic_1proper(BigInteger _radix_plural, DenomNonnilI proper)
		{




			///eg: 0.0142857 = 1/70
			/// 0(142857 * 10^-7, where recur =6
			return _Of_0radic_12proper(_radix_plural,proper.numerator,proper.denominator);
		}

		public static RecurI _Of_0radic_12proper(BigInteger radix_plural, BigInteger numerator, BigInteger denominator)
		{
			/// as this is proper, it's equivlanet to a mantissaed floaty;
			return nonneg_.radix_.floaty.recur_.mantissaed.of_._OfProperX._Of_0radic_12proper(
				radix_plural
				,numerator
				,
				denominator
			);

		}


	}
}
