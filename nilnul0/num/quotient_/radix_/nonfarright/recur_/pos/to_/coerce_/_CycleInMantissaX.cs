using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using nilnul.num.quotient_.radix_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_.indicNonpos.recur_.pos.to_.coerce_
{

	/// <summary>
	/// as this is a recur, we need to extend the signific to accormodate the cycle part, not 0 as done by <see cref="radix.of_.unary_._DecreaseIndicX"/>;
	/// eg:
	///		-010230 * 10 ^ -01, recur: 3  =01023.0230230
	///			=>
	///				-010230230 * 10^-4,recur 3
	///				=-01023.0(230
	/// </summary>
	static public class _CycleInMantissaX
	{
	
		public static IndicNonpos _IndicNonpos_1pos(IndicNonpos radix, int cycle)
		{
			return IndicNonpos.Of(
				_Radix_1pos(radix,cycle)
			);
		}
	
		public static RadixI _Radix_1pos(IndicNonpos radix, int cycle)
		{
			return quotient_.radix.recur_.pos.to_.coerce_._CycleInMantissaX._Radix_1positive(
					radix,
					cycle
			);
		}
	

		static public RadixI _Radix_0indicNonpos_1pos(
			ByNeg radix
			,
			int _cycle
		)
		{
			return quotient_.radix.recur_.pos.to_.coerce_._CycleInMantissaX._Radix_1positive(
					radix,
					_cycle
			);

		}
		static public RadixI _Radix_0indicNonpos_1pos(
			RadixI radix
			,
			int _cycle
		)
		{
			return quotient_.radix.recur_.pos.to_.coerce_._CycleInMantissaX._Radix_1positive(
					radix,
					_cycle
			);

		}

	





	}
}
