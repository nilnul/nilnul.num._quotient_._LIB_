using nilnul.num.quotient._radix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using q = nilnul.num.quotient;
using nilnul.txt;
using nilnul.num.quotient_.radix.ext.errable_.ieee_._bin;

namespace nilnul.num.quotient_.nonneg_.radix.of_
{
	/// <summary>
	/// given a precision, get the gits wide less than the given precision;
	/// eg:
	///		123e2 from 12345, given precision 3;
	/// </summary>
	static public class _OfNonnegQuotientX
	{



		/// <summary>
		/// keep dividing numerator by the denominator to get the gits; As integer is the quotient already, so we now only tackle the proper part in a way different from how we treat the integers;
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		static public nonneg_.Radix _Of_0radic_2precision(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.nonneg.vow.En proper
			, BigInteger mantissa
		)
		{
			return _Of_0radic_1nonneg_2precision(_radix_plural, proper.en, mantissa);

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
		/// <param name="mantissa">
		/// how much digits allowed;
		/// eg:6
		/// </param>
		/// <returns>
		/// 
		/// .285714
		/// </returns>
		/// <exception cref="NotImplementedException"></exception>
		public static nonneg_.Radix _Of_0radic_1nonneg_2precision(
			BigInteger _radix_plural, Quotient1 proper, BigInteger mantissa)
		{

			return _Of_0radic_1nonneg_2precision(_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper), mantissa
			);
		}


		public static nonneg_.Radix _Of_0radic_1nonneg_2precision(BigInteger _radix_plural, num.quotient_.DenomNonnilI proper, BigInteger precision)
		{
			var floored = nilnul.num.quotient_.FlooredX.ToFloored(proper); ;

			BigInteger intPart = floored.floor;

			List<BigInteger> gits = new List<BigInteger>() { };
			gits.AddRange(
				new nilnul.num_._radix.Root1(_radix_plural)._toPositions(intPart).Select(x => x.en).Reverse()
			);

			var remainedGitsLength = precision - gits.Count;

			BigInteger indic = 0;
			if (remainedGitsLength < 0) // truncate precision
			{
				var remainedGitsLengthAbsAsInt = -(int)remainedGitsLength;
				gits.RemoveRange((int)precision, remainedGitsLengthAbsAsInt);
	
				return Radix.Of_0radic_1gits_2indic(
					_radix_plural
					, gits
					, remainedGitsLengthAbsAsInt
				);
			}

			var properRadix = _OfProperX._OfProper_0radic_1proper_2mantissa(
				_radix_plural
				,
				floored.proper
				,
				remainedGitsLength
			);

			//gits.AddRange(
			//	properRadix.precision.gits.Select(x => x.eeByRef)
			//);

			return Radix.Of_0radic_1gits_2indic(
				_radix_plural
				,

				properRadix.precision.gits.Select(x => x.eeByRef).Concat(
					gits
					//new nilnul.num_._radix.Root1(_radix_plural)._toPositions_0nonneg(intPart).Select(x => x.en)
				)
				, -remainedGitsLength
			);






		}


	}
}
