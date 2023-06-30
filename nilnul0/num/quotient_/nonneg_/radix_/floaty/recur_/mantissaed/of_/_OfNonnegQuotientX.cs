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

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur_.mantissaed.of_
{
	/// <summary>
	/// spin off the whole part, and find cycle in mantissa only;
	/// </summary>
	static public class _OfNonnegQuotientX
	{



		/// <summary>
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <returns></returns>
		/// 
		static public Mantissaed _Of_0radic(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.nonneg.vow.En proper
		)
		{
			return _Of_0radic_1nonneg(_radix_plural, proper.en);

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
		public static Mantissaed _Of_0radic_1nonneg(
			BigInteger _radix_plural, Quotient1 proper)
		{

			return _Of_0radic_1nonneg(
				_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper)
			);
		}


		public static Mantissaed _Of_0radic_1nonneg(
			BigInteger _radix_plural, num.quotient_.DenomNonnilI proper
		)
		{

			var floored = nilnul.num.quotient_.FlooredX.ToFloored(proper); ;

			BigInteger intPart = floored.floor;

			//List<BigInteger> gitsAftDot = new List<BigInteger>() { };

			//gitsAftDot.AddRange(
			//	new nilnul.num_._radix.Root1(_radix_plural)._toPositions(intPart).Select(x => x.en)
			//); // it's heavy1st;


			BigInteger indic = 0;


			var properRadix = _OfProperX._Of_0radic(
				_radix_plural
				,
				floored.proper

			);

			//gitsAftDot.AddRange(
			//	properRadix.precision.gits.Select(x => x.eeByRef)
			//);

			return new Mantissaed(
				new Floaty(
					_radix_plural
					,
				properRadix.precision.gits.Select(x => x.eeByRef).Concat(
new nilnul.num_._radix.Root1(_radix_plural)._toPositions(intPart).Select(x => x.en)
				)


					//gitsAftDot
					,
					properRadix.indic
				)
				,
				properRadix.period
			);






		}


	}
}
