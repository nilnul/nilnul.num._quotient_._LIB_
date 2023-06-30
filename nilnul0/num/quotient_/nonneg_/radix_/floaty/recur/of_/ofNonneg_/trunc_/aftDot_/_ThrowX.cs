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

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur.of_.ofNonneg_.trunc_.aftDot_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ThrowX
	{



		/// <summary>
		/// </summary>
		/// <param name="_radix_plural"></param>
		/// <param name="precisionAftDot">mantissa</param>
		/// <returns></returns>
		/// 
		static public Recur _Of_0plural_2nonneg(
			BigInteger _radix_plural,
			nilnul.num.quotient.be_.nonneg.vow.En proper
			,
			BigInteger precisionAftDot

		)
		{
			return _Of_0plural_1nonneg_2nonneg(_radix_plural, proper.en, precisionAftDot);

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
		public static Recur _Of_0plural_1nonneg_2nonneg(
			BigInteger _radix_plural
			,
			Quotient1 proper
			,
			BigInteger precisionAftDot

			)
		{

			return _Of_0plural_1nonneg_2nonneg(
				_radix_plural,
				quotient_.denomNonnil._RegressionsX.ToDenomNonnil(proper)
				,
				precisionAftDot
			);
		}


		public static Recur _Of_0plural_1nonneg_2nonneg(
			BigInteger _radix_plural
			,
			num.quotient_.DenomNonnilI proper
			,
			BigInteger precisionAftDot
		)
		{

			var floored = nilnul.num.quotient_.FlooredX.ToFloored(proper); ;

			BigInteger intPart = floored.floor;

			List<BigInteger> gitsAftDot = new List<BigInteger>() { };

			gitsAftDot.AddRange(
				new nilnul.num_._radix.Root1(_radix_plural)._toPositions(intPart).Select(x => x.en)
			);


			BigInteger indic = 0;


			var properRadix = ofProper_.trunc_._ThrowX._Of_0radic_1proper_2nonneg(
				_radix_plural
				,
				floored.proper
				,
				precisionAftDot

			);

			gitsAftDot.AddRange(
				properRadix.precision.gits.Select(x => x.eeByRef)
			);

			return new Recur(
				new Floaty(
					_radix_plural
					, gitsAftDot
					,
					properRadix.indic
				)
				,
				properRadix.period
			);






		}


	}
}
