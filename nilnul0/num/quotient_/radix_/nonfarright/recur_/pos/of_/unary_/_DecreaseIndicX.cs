using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using nilnul.num.quotient_.radix_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_.indicNonpos.recur_.pos.of_.unary_
{

	/// <summary>
	/// as this is a recur, we need to extend the signific to accormodate the cycle part, not 0 as done by <see cref="radix.of_.unary_._DecreaseIndicX"/>;
	/// eg:
	///		-010230 * 10 ^ -01, recur: 3  =01023.0230230
	///			=>
	///				-010230230 * 10^-4,recur 3
	///				=-01023.0(230
	/// </summary>
	static public class _DecreaseIndicX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="radix"></param>
		/// <param name="_rounds">
		/// how many cycles populated to shift <paramref name="radix"/>'s indic smaller to make cycles cover towards the right of dot;
		/// </param>
		/// <returns></returns>
		public static IndicNonpos _IndicNonpos_1pos_2nonneg(IndicNonpos radix, int cycle, int _rounds)
		{
			return new IndicNonpos(
				quotient_.radix.recur_.pos.of_.unary_._ExpandCyclesX._NopIfRoundsIs0_0positive_1nonneg(
					radix,
					cycle,
					_rounds
					)
			);
		}
		public static IndicNonpos _IndicNonpos_1pos_2pos(IndicNonpos radix, int cycle, int _rounds)
		{
			
			return new IndicNonpos(
				quotient_.radix.recur_.pos.of_.unary_._ExpandCyclesX._Duo_01pos(
					radix,
					cycle,
					_rounds
					)
			);


		}

		static public IndicNonpos _IndicNonpos_0indicNonpos_1pos_0nonneg(
			RadixI radix
			,
			int cycle
			,
			int _rounds
		)
		{
			return new IndicNonpos(
				quotient_.radix.recur_.pos.of_.unary_._ExpandCyclesX._NopIfRoundsIs0_0positive_1nonneg(
					radix,
					cycle,
					_rounds
					)
			);


		}
		static public IndicNonpos _NopIfRoundsIs0_0indicNonpos_1pos_2nonneg(
			RadixI radix
			,
			int cycle
			,
			int _rounds
		)
		{
	
			return new IndicNonpos(
				quotient_.radix.recur_.pos.of_.unary_._ExpandCyclesX._NopIfRoundsIs0_0positive_1nonneg(
					radix,
					cycle,
					_rounds
					)
			);


		}





	}
}
