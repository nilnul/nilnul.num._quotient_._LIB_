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

namespace nilnul.num.quotient_.nonneg_.radix_.floaty.recur.of_.unary_.downIndic_
{

	/// <summary>
	/// decrease indic in a rounds of cycles;
	/// </summary>
	static public class _InRoundsX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="floaty"></param>
		/// <param name="cycle"></param>
		/// <param name="_rounds8nonneg">a nonneg number; </param>
		/// <returns></returns>
		public static (num_.Radix2 precision, BigInteger indic) __Duo_0nonneg_1nonneg(
			FloatyI floaty, int cycle, int _rounds8nonneg
		)
		{

			return unary_._DecreaseIndicX.__Duo_0nonneg_1nonneg(floaty,cycle,_rounds8nonneg*cycle);
		}
		public static (num_.Radix2 precision, BigInteger indic) _Duo_01pos(
			FloatyI recur, int cycle, int _rounds8nonneg
		)
		{
			return __Duo_0nonneg_1nonneg(recur, cycle, _rounds8nonneg);
		}
		static public (num_.RadixI precision, BigInteger indic) _NopIfDecreaseIs0_0positive_1nonneg(
			FloatyI radix
			,
			int cycle
			,
			int _rounds8nonneg
		)
		{
			if (_rounds8nonneg == 0)
			{
				return (radix.precision, radix.indic);
			}

			return _Duo_01pos(radix, cycle, _rounds8nonneg);
		}

		public static (num_.Radix2 precision, BigInteger indic) __Duo_0nonneg(
			RecurI recur
			,
			int _rounds8nonneg
		)
		{
			return __Duo_0nonneg_1nonneg(recur.floaty, (int)recur.period.eeByRef, _rounds8nonneg);
			;
		}



		public static (num_.Radix2 precison, BigInteger indic) _Duo_0pos(
			RecurI recur, int _rounds8nonneg
		)
		{
			return __Duo_0nonneg(recur, _rounds8nonneg);
		}




		static public Recur _NopIfDecreaseIs0_1nonneg(
			Recur recur
			,
			int _rounds8nonneg
		)
		{
			var t = _Duo_0pos(recur, _rounds8nonneg);

			return new Recur(t, recur.period);

			//return new Recur(t.Item1,t.Item2,recur.cycle);


		}






	}
}
