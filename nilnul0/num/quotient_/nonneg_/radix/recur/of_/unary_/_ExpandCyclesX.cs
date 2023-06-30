using nilnul.num.integer_;
using nilnul.num.quotient_.nonneg_.radix_.floaty;
using nilnul.num.quotient_.radix;
using nilnul.num.quotient_.radix_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.nonneg_.radix.recur.of_.unary_
{

	/// <summary>
	/// as this is a recur, we need to extend the signific to accormodate the cycle part, not 0 as done by <see cref="radix.of_.unary_._DecreaseIndicX"/>;
	/// eg:
	///		-010230 * 10 ^ -01, recur: 3  =01023.0230230
	///			=>
	///				-010230230 * 10^-4,recur 3
	///				=-01023.0(230
	/// </summary>
	static public class _ExpandCyclesX
	{
		public static (num_.Radix2, BigInteger) __Duo_0nonneg_1nonneg(RadixI radix, int cycle,  int _recurs2populate)
		{
			return _DecreaseIndicX.__Duo_1pos_2nonneg(radix, cycle, cycle*_recurs2populate);

			var cyclePart = radix.precision.gits.Take( cycle);

			var toFill = nilnul.obj.str.of_._RepeatX._Repeat_1nonneg(cyclePart, _recurs2populate).SelectMany(x=>x);


			return (
				new nilnul.num_.Radix2(
					radix.precision.radic.eeByRef
					,
						
					radix.precision.gits.Concat(
						toFill
					).Select(
						x => x.eeByRef
					)
					
				)
				,
				radix.indic - _recurs2populate * cycle
			);
		}
		public static (num_.Radix2, BigInteger) __Duo_0pos_1nonneg(RecurI recur,  int _recurs2populate)
		{
			return __Duo_0nonneg_1nonneg(recur.radix,(int) recur.period.eeByRef,_recurs2populate);
			;
		}


		public static (num_.Radix2, BigInteger) _Duo_01pos(RadixI recur, int cycle,  int _cycles)
		{
			return __Duo_0nonneg_1nonneg(recur, cycle, _cycles);
		}
		public static (num_.Radix2, BigInteger) _Duo_01pos(RecurI recur,   int _cycles)
		{
			return __Duo_0pos_1nonneg(recur,  _cycles);
		}



		static public (num_.RadixI, BigInteger) _NopIfRoundsIs0_0positive_1nonneg(
			RadixI radix
			,
			int cycle
			,
			int rounds
		)
		{
			if (rounds == 0)
			{
				return (radix.precision, radix.indic);
			}

			return _Duo_01pos(radix,cycle, rounds);
		}

		static public Recur _NopIfRoundsIs0_0positive_1nonneg(
			Recur radix
			,
			int cycle
			,
			int rounds
		)
		{
			var t= _NopIfRoundsIs0_0positive_1nonneg(radix.radix, cycle, rounds);
			return new Recur(t.Item1,t.Item2,cycle);



		}






	}
}
