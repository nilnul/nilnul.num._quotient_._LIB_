using nilnul.num.quotient_.radix.recur_;
using nilnul.num.rational.float_;
using nilnul.num.rational.float_.based.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient_.radix.recur.to_
{
	static public class _RegressionsX
	{
		static public Recur1 ToRecur1AsSignificed(
			quotient_.radix.recur_.ByNeg unsigned
		)
		{
			return new Recur1(
				unsigned.radix
				,
				unsigned.period

			);
		}

		static public Recur ToRecur(
			Recur1 unsigned
		)
		{
			var signific = quotient_.radix._ToX.ToSignified(
					unsigned.radix
				);
			return new Recur(
				
				 Radix1.OfSignific9radic9indic(signific)
				,
				unsigned.period

			);
		}
		static public Recur ToRecurAsSignificed(
			quotient_.radix.recur_.ByNeg unsigned
		)
		{
			return ToRecur(ToRecur1AsSignificed(
				unsigned



			)
				);
		}


		static public Recur1 ToSignificed(
			quotient_.nonneg_.radix.RecurI unsigned
			,
			bool negated = false
		)
		{
			return ToRecur1AsSignificed(
				new quotient_.radix.recur_.ByNeg(unsigned, negated)
			);
		}




		public static recur_.ByNeg ToRecur(nilnul.num.rational.float_.Periodic periodic)
		{
			var regressed = _radix.radic.indiced.significed._RegressionsX.AsRadic9sansroot(periodic.float_);

			var radix = quotient_.radix.of_._OfSignificedX.ToRadix(regressed); //zeros might be removed;


			return recur._OfX._PrependNecessaryNils_0nonneg(
				radix
				,
				periodic.recurSpanAsBigInt
			);

		}

	}
}
