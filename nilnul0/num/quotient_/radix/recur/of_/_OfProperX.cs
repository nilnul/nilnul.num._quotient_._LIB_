using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.radix.recur.of_
{
	/// <summary>
	///  get all the remainders, till a cycle formed.
	/// </summary>
	/// <remarks>recurring, cyclic, repeating, recurring...</remarks>
	static public class _OfProperX
	{

	

		/// <summary>
		///
		/// keep dividing numerator by the denominator to get the gits; As integer is the quotient already, so we now only tackle the proper part in a way different from how we treat the integers;
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		static public quotient_.radix.recur_.ByNeg _OfProper_0radic(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.proper.vow.En proper
		)
		{
			return _OfProper_0radic_1proper(_radix_plural, proper.en);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_radix_plural">
		/// eg:
		///		10
		/// </param>
		/// <param name="proper">
		///	eg:
		///		2/7
		/// </param>
		/// <returns>
		/// 
		/// .(285714
		/// </returns>
		/// <exception cref="NotImplementedException"></exception>
		public static quotient_.radix.recur_.ByNeg _OfProper_0radic_1proper(BigInteger _radix_plural, Quotient1 proper)
		{
			return new quotient_.radix.recur_.ByNeg(
				quotient_.nonneg_.radix.recur.of_._OfProperX._Of_0radic_1proper(_radix_plural,proper)
				);
			BigInteger signific = 0;
			BigInteger indic = 0;
			/// we now have,eg: 0*10^0

			List<BigInteger> remainders = new List<BigInteger>() { };
			const int NOT_FOUND = -1;

			BigInteger recurFound = NOT_FOUND/* remainders.IndexOf(remainder)*/;


			while (recurFound == NOT_FOUND)
			{
				BigInteger remainder ;

				BigInteger quotient = BigInteger.DivRem(
								proper.numerator * _radix_plural
								,
								proper.denominator.val
								,
								out remainder
				);  ///   20%7 =2 ... 6

				if (remainder == 0)
				{
					///0 is added to the remainder; 0 will repeat for ever; and the recurFound is the last position; recurSpan is the length one. This reduces to :  no 0 is added, and ---
					recurFound = remainders.Count;
				}
				else
				{
					remainders.Add(remainder);
					signific =
						signific * _radix_plural
						+
						quotient
					;
					indic--; //this offsets the effect of multiplier*_radix
					recurFound = remainders.IndexOf(remainder);
				}
			}
			//return new Recur(_radix_plural, signific, indic, remainders.Count - recurFound);
			//throw new NotImplementedException();
		}
	}
}
