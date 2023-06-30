using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using nilnul.num.quotient_.radix_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.recur_.pos.of_.unary_
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
		public static (integer_.Radix, BigInteger) __Duo_0pos_1nonneg(RadixI radix, int cycle,  int _recurs2populate)
		{

			var cyclePart = radix.signific.abs.digits.Take( cycle);

			var toFill = nilnul.obj.str.of_._RepeatX._Repeat_1nonneg(cyclePart, _recurs2populate).SelectMany(x=>x);


			return (
				new integer_.Radix(
					new nilnul.num_.Radix1(
						radix.signific.abs.root
						,
						new str_.List(
							radix.signific.abs.digits.Concat(
								toFill.Select(x => new Num1(x.en))
							)
						)
					)
					,
					radix.signific.sign
				)
				,
				radix.indic - _recurs2populate * cycle
			);
		}
		public static (integer_.Radix, BigInteger) __Duo_0pos_1nonneg(RecurI recur,  int _recurs2populate)
		{
			return __Duo_0pos_1nonneg(recur.radix,(int) recur.cycle.eeByRef,_recurs2populate);
			;
		}


		public static (integer_.Radix, BigInteger) _Duo_01pos(RadixI recur, int cycle,  int _cycles)
		{
			return __Duo_0pos_1nonneg(recur, cycle, _cycles);
		}
		public static (integer_.Radix, BigInteger) _Duo_01pos(RecurI recur,   int _cycles)
		{
			return __Duo_0pos_1nonneg(recur,  _cycles);
		}



		static public (integer_.Radix, BigInteger) _NopIfRoundsIs0_0positive_1nonneg(
			RadixI radix
			,
			int cycle
			,
			int rounds
		)
		{
			if (rounds == 0)
			{
				return (radix.signific, radix.indic);
			}

			return _Duo_01pos(radix,cycle, rounds);
		}






	}
}
