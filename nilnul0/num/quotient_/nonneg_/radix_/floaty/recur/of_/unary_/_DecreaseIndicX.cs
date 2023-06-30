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

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur.of_.unary_
{

	/// <summary>
	/// we can decrease the indic while appending to the precision, in order to move the cycle into the mantissa;
	/// eg:
	///		-010(230 * 10 ^ -01
	///			=>
	///				-01023(023 * 10^-03 = -01023.023023023
	/// </summary>
	static public class _DecreaseIndicX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="floaty"></param>
		/// <param name="period"></param>
		/// <param name="_indicDecrease">a nonneg number; </param>
		/// <returns></returns>
		public static (num_.Radix2 precision, BigInteger indic) __Duo_0nonneg_1nonneg(
			FloatyI floaty, int period, int _indicDecrease
		)
		{

			var cyclePart = floaty.precision.gits.Take(period); //eg: for 4(321, which is stored as 123(4  : "123"


			
			var toFill = nilnul.obj.stream.of_.str_.seq_.started_.cyclic_._WhileTrue.Seq_assumeStarted(
				cyclePart	//eg: 123
				.Reverse()	// eg: 321
			)	//eg: 321321321...
			.Take(_indicDecrease)//eg: 32
			.Reverse()	//23
			; 


			return (
				new nilnul.num_.Radix2(
					floaty.precision.radic.eeByRef
					,

					toFill.Concat(
						floaty.precision.gits
						
					)
					.		// 23123(4, as the cycle is unchanged, we get: 231(234 as stored, to human it is: 432(1.32
					Select(
						x => x.eeByRef
					)

				)
				,
				floaty.indic - _indicDecrease
			);
		}
		public static (num_.Radix2 precision, BigInteger indic) _Duo_01pos(
			FloatyI recur, int cycle, int _indicDecrease
		)
		{
			return __Duo_0nonneg_1nonneg(recur, cycle, _indicDecrease);
		}
		static public (num_.RadixI precision, BigInteger indic) _NopIfDecreaseIs0_0positive_1nonneg(
			FloatyI radix
			,
			int cycle
			,
			int indicDecrease
		)
		{
			if (indicDecrease == 0)
			{
				return (radix.precision, radix.indic);
			}

			return _Duo_01pos(radix, cycle, indicDecrease);
		}

		public static (num_.Radix2 precision, BigInteger indic) _Duo_0nonneg(
			RecurI recur, int _indicDecrease
		)
		{
			return __Duo_0nonneg_1nonneg(recur.floaty, (int)recur.period.eeByRef, _indicDecrease);
			;
		}

		public static (num_.Radix2 precision, BigInteger indic) _Duo_0nonneg(
			RecurI recur, BigInteger _indicDecrease
		)
		{
			return _Duo_0nonneg(recur, (int)_indicDecrease);
		}



		public static (num_.Radix2 precison, BigInteger indic) _Duo_0pos(
			RecurI recur, int _indicDecrease
		)
		{
			return _Duo_0nonneg(recur, _indicDecrease);
		}




		static public Recur _NopIfDecreaseIs0_1nonneg(
			Recur recur
			,
			int indicDegrease
		)
		{
			var t = _Duo_0pos(recur, indicDegrease);

			return new Recur(t, recur.period);

			//return new Recur(t.Item1,t.Item2,recur.cycle);


		}






	}
}
