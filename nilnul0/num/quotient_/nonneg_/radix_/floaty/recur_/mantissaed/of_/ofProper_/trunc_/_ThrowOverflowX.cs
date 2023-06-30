using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur_.mantissaed.of_.ofProper_
{
	static public class _ThrowOverflowX
	{



		/// <summary>
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		static public Mantissaed _Of_0radic_2nonneg(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.proper.vow.En proper
			,BigInteger lengthLimit
		)
		{
			return _Of_0radic_1proper_2nonneg(_radix_plural, proper.en,lengthLimit);

		}

		
		public static Mantissaed _Of_0radic_1proper_2nonneg(BigInteger _radix_plural, Quotient1 proper
			,BigInteger lengthLimit)
		{
			
			return _Of_0radic_1proper_2nonneg(
				_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper),lengthLimit
			);
		}
		public static Mantissaed _Of_0radic_1proper_2nonneg(BigInteger _radix_plural, DenomNonnilI proper,BigInteger lengthLimit)
		{
			return _Of_0radic_12proper_3nonneg(
				_radix_plural
				,
				proper.numerator
				,
				proper.denominator
				,
				lengthLimit
			);
			
		}

		public static Mantissaed _Of_0radic_12proper_3nonneg(
			BigInteger _radix_plural
			,
			BigInteger numerator
			,
			BigInteger denominator
			,
			BigInteger lengthLimit)
		{
			BigInteger signific = 0;
			BigInteger indic = 0;
			/// we now have,eg: 0*10^0

			List<BigInteger> gits = new List<BigInteger>() { };
			const int NOT_FOUND = -1;

			BigInteger recurFound = NOT_FOUND; /* remainders.IndexOf(remainder)*/;

			//var numerator = numerator;

			List<BigInteger> remainders = new List<BigInteger>() {numerator };
			
			while (numerator != 0)
			{
				if (gits.Count >= lengthLimit)
				{
					throw new quotient_._radix.xpn_.OverlongException(
						$"we have found cycle but the length is beyond the limit:{lengthLimit};"
					);
				}

				BigInteger quotient = BigInteger.DivRem(
								numerator * _radix_plural
								,
								denominator
								,
								out numerator
				);  ///   20%7 =2 ... 6
				gits.Add(quotient);
				indic--; //this offsets the effect of multiplier*_radix

				recurFound = remainders.IndexOf((BigInteger)numerator);

				if (recurFound>=0)// no need to get nextRound
				{
					break;
				}
				

			}
			gits.Reverse();
			//recurFound

			if (recurFound==NOT_FOUND)
			{
				return  new Mantissaed(
					_radix_plural,
					gits,
					indic,
					0 /// where to start the cycle; for unfound,  <see cref="recurFound"/> = -1; the cycle is count+1
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
