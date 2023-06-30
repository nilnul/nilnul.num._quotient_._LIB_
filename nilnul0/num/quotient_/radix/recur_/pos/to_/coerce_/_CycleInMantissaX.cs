using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using nilnul.num.quotient_.radix_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.recur_.pos.to_.coerce_
{

	/// <summary>
	/// decrease the indic meanwhile increase 
	/// </summary>
	static public class _CycleInMantissaX
	{

		public static radix.RecurI _IndicNonpos_0cyclePositive(radix.RecurI recur1)
		{
			return _IndicNonpos_1positive(recur1.radix, recur1.cycle);

		}

		public static RadixI _Radix_0cyclePositive(radix.RecurI recur1)
		{
			return _Radix_1positive(recur1.radix, recur1.cycle);

		}

		public static RecurI _IndicNonpos_1positive(Radix3 radix, Num_ofIn cycle)
		{
			return _Recur_1positive(radix,cycle.eeByRef);
		}
		public static RadixI _Radix_1positive(Radix3 radix, Num_ofIn cycle)
		{
			return _Radix_1positive(radix,cycle.eeByRef);
		}


		public static RecurI _Recur_1positive(RadixI radix, Num_ofIn cycle)
		{
			return _Recur_1positive(radix,cycle.eeByRef);
		}

		public static RadixI _Radix_1positive(RadixI radix, Num_ofIn cycle)
		{
			return _Radix_1positive(radix,cycle.eeByRef);
		}


		private static RecurI _Recur_1positive(Radix3 radix, BigInteger eeByRef)
		{
			return _Recur_1positive((RadixI)radix,eeByRef);

		}
		private static RadixI _Radix_1positive(Radix3 radix, BigInteger eeByRef)
		{
			return _Radix_1positive((RadixI)radix,eeByRef);

		}


		private static RecurI _Recur_1positive(RadixI radix, BigInteger eeByRef)
		{
			return _Recur_1positive(radix,(int)eeByRef);

		}

		private static RadixI _Radix_1positive(RadixI radix, BigInteger eeByRef)
		{
			return _Radix_1positive(radix,(int)eeByRef);

		}


		public static radix.RecurI _Recur_1positive(RadixI radix, int cycle)
		{

			var cycle2overreach = radix.indic + cycle; /// expected indic +cycle le 0;

			if (cycle2overreach>0)
			{
				var c = recur_.pos.of_.unary_._ExpandCyclesX._Duo_01pos(
					radix
					,
					(int)cycle
					,
					(int)nilnul.num_.positive.of_.binary_.divide_._CeilingX._DivideCeiling_01positive(
						cycle2overreach, cycle
					)
				);
				return new radix.Recur1(
					c.Item1
					,c.Item2
					,
					cycle
				);
			}
			return new Recur1(
				radix,cycle
			);
		}

	
	
		public static RadixI _Radix_1positive(RadixI radix, int cycle)
		{

			var cycle2overreach = radix.indic + cycle; /// expected indic +cycle le 0;

			if (cycle2overreach>0)
			{
				var c = recur_.pos.of_.unary_._ExpandCyclesX._Duo_01pos(
					radix
					,
					(int)cycle
					,
					(int)nilnul.num_.positive.of_.binary_.divide_._CeilingX._DivideCeiling_01positive(
						cycle2overreach, cycle
					)
				);
				return new Radix3(
					c.Item1
					,c.Item2
				
				);
			}
			return 	radix;
		}
	






	}
}
