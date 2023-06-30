using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur_.mantissaed.of_
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
		static public Mantissaed _Of_0radic(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.proper.vow.En proper
		)
		{
			return _Of_0radic_1proper(_radix_plural, proper.en);

		}

		
		public static Mantissaed _Of_0radic_1proper(BigInteger _radix_plural, Quotient1 proper)
		{
			
			return _Of_0radic_1proper(_radix_plural, quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper));
		}
		public static Mantissaed _Of_0radic_1proper(BigInteger _radix_plural, DenomNonnilI proper)
		{
			return _Of_0radic_12proper(_radix_plural,proper.numerator,proper.denominator);
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <param name="numerator"></param>
		/// <param name="denominator">will we allow negative? will we simplify the fraction?</param>
		/// <returns></returns>
		public static Mantissaed _Of_0radic_12proper(BigInteger _radix_plural, BigInteger numerator, BigInteger  denominator)
		{
			BigInteger indic = 0;
			/// we now have,eg: 0*10^0

			List<BigInteger> gits = new List<BigInteger>() { };
			const int NOT_FOUND = -1;

			BigInteger recurFound = NOT_FOUND; /* remainders.IndexOf(remainder)*/;

			var remainder = numerator;

			List<BigInteger> remainders = new List<BigInteger>() {};
			
			while (remainder != 0)
			{
				recurFound = remainders.IndexOf(remainder);

				if (recurFound>=0)// no need to get nextRound
				{
					break;
				}

				remainders.Add(remainder);


				BigInteger quotient = BigInteger.DivRem(
								remainder * _radix_plural
								,
								denominator
								,
								out remainder
				);  ///   20%7 =2 ... 6
				gits.Add(quotient);
				indic--; //this offsets the effect of multiplier*_radix




				

			}
			gits.Reverse();//heavy1st; as we treat gits as integer, so we reverse it;
			//recurFound

			if (recurFound==NOT_FOUND)
			{
				return  new Mantissaed(
					_radix_plural,
					gits 
					,
					indic,
					0 /// where to start the cycle; for unfound,  <see cref="recurFound"/> = -1; the cycle, if computed using the following regular formula, is count+1, which is incorrect;
				);

			}

			return  new Mantissaed(
				_radix_plural,
				gits,
				indic,
				gits.Count - recurFound /// where to start the cycle; for unfound,  <see cref="recurFound"/> = -1; the cycle is count+1
			);
		}

	}
}
