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

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur_.mantissaed.of_.unary_
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
		/// <param name="cycle"></param>
		/// <param name="_indicDecrease">a nonneg number; </param>
		/// <returns></returns>
		public static (num_.Radix2 precision, BigInteger indic) __Duo_0nonneg_1nonneg(
			FloatyI floaty
			, int cycle
			, int _indicDecrease
		)
		{



			return recur.of_.unary_._DecreaseIndicX.__Duo_0nonneg_1nonneg(
				floaty,cycle,_indicDecrease
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

		public static (num_.Radix2 precision, BigInteger indic) __Duo_0nonneg(
			recur_.MantissaedI recur, int _indicDecrease
		)
		{
			return __Duo_0nonneg_1nonneg(recur.floaty, (int)recur.period.eeByRef, _indicDecrease);
			;
		}



		public static (num_.Radix2 precison, BigInteger indic) _Duo_0pos(
			recur_.MantissaedI recur, int _indicDecrease
		)
		{
			return __Duo_0nonneg(recur, _indicDecrease);
		}




		static public recur_.Mantissaed _NopIfDecreaseIs0_1nonneg(
			recur_.MantissaedI recur
			,
			int indicDegrease
		)
		{
			var t = _Duo_0pos(recur, indicDegrease);

			return new recur_.Mantissaed(t, recur.period);

			//return new Recur(t.Item1,t.Item2,recur.cycle);


		}






	}
}
