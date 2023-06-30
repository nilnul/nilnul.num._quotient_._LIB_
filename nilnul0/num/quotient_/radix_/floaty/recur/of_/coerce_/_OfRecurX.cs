using nilnul.num.integer_;
using nilnul.num.quotient_.radix;
using nilnul.num.quotient_.radix_;
using nilnul.num.rational.float_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix_.floaty.recur.of_.coerce_
{

	/// <summary>
	/// decrease the indic meanwhile increase precision by appending 0s, such that point can be inside precision;
	/// note: the point may still exceed precision at the left;
	/// </summary>
	static public class _OfRecurX
	{

		public static radix_.floaty.Recur _AsFloatyRecur_1nonneg(Radix8unsignedI radix, int cycle)
		{
			return new radix_.floaty.Recur(
				quotient_.nonneg_.radix_.floaty.recur.of_._CoerceX.ToFloatyRecur(radix.unsigned, cycle)
				,
				radix.negated
			);

			//if (cycle==0)
			//{
			//	return new radix_.floaty.Recur(
			//		quotient_.radix_.floaty.of_.coerce_._OfRadixX.ToFloaty(radix)
			//		,
			//		0
			//	);
			//}
			//return recur_.pos.to_.coerce_._CycleInMantissaX._Recur_1positive(radix, cycle);
		}

		private static radix_.floaty.Recur _AsFloatyRecur_1nonneg(Radix3 radix, BigInteger period)
		{
			return _AsFloatyRecur_1nonneg((Radix8unsignedI)radix, (int)period);

		}
		public static radix_.floaty.Recur AsFloatyRecur(Radix3 radix, Num_ofIn cycle)
		{
			return _AsFloatyRecur_1nonneg(radix, cycle.eeByRef);
		}

		public static radix_.floaty.Recur AsFloatyRecur(radix.RecurI recur1)
		{
			return AsFloatyRecur(recur1.radix, recur1.period);

		}

		public static radix_.floaty.Recur AsFloatyRecur(radix.Recur8unsignedI recur1)
		{
			return new Recur(
				quotient_.nonneg_.radix_.floaty.recur.of_._CoerceX.ToFloatyRecur(recur1.unsigned)
				,
				recur1.negated
			);

		}
		public static Recur AsFloatyRecur(radix.recur_.ByNeg  periodic1111)
		{
			return AsFloatyRecur(
				(radix.Recur8unsignedI)periodic1111
			);
		}


		public  static radix_.floaty.Recur AsFloatyRecur(Periodic periodic)
		{
			return AsFloatyRecur(
				radix.recur.to_._RegressionsX.ToRecur(periodic)
			);
		}

		public static Recur AsFloatyRecur(radix.Recur periodic1111)
		{
			return AsFloatyRecur(
				(radix.Recur8unsignedI)periodic1111
			);
		}

	}
}